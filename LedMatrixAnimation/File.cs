using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedMatrixAnimation
{
    /// <summary>
    /// Thanks to: https://stackoverflow.com/questions/7343465/compression-decompression-string-with-c-sharp
    /// </summary>
    public class File
    {
        public void SaveToFile(IEnumerable<LedMatrix> content, string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }

            var rawContent = content.Select(m => m.Content);
            var serializedContent = System.Text.Json.JsonSerializer.Serialize<IEnumerable<byte[]>>(rawContent);
            var zippedContent = Zip(serializedContent);

            var file = System.IO.File.Create(filePath);
            file.Write(zippedContent, 0, zippedContent.Length);
            file.Close();
        }

        public IEnumerable<LedMatrix> ReadFromFile(string filePath)
        {
            var file = System.IO.File.OpenRead(filePath);
            var zippedContent = new byte[file.Length];

            file.Read(zippedContent, 0, zippedContent.Length);
            file.Close();

            var serializedContent = Unzip(zippedContent);
            var rawContent = System.Text.Json.JsonSerializer.Deserialize<IEnumerable<byte[]>>(serializedContent);
            var clips = new List<LedMatrix>();

            foreach (var matrixContent in rawContent)
            {
                var clip = new LedMatrix();
                clip.Content = matrixContent;
                clips.Add(clip);
            }

            return clips.ToArray();
        }

        private byte[] Zip(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);

            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(mso, CompressionMode.Compress))
                {
                    CopyTo(msi, gs);
                }

                return mso.ToArray();
            }
        }

        private string Unzip(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                {
                    CopyTo(gs, mso);
                }

                return Encoding.UTF8.GetString(mso.ToArray());
            }
        }

        private void CopyTo(Stream src, Stream dest)
        {
            byte[] bytes = new byte[4096];

            int cnt;

            while ((cnt = src.Read(bytes, 0, bytes.Length)) != 0)
            {
                dest.Write(bytes, 0, cnt);
            }
        }
    }
}
