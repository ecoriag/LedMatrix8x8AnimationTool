# LedMatrix8x8AnimationTool
A little initiative to help making matrix 8x8 animation easier

# Disclaimer
This project is in an early stage so changes can come very frequently.

# Description
These are a couple of projects to generate hexadecimal code that you can use in your project.
Code is in general format that makers usually use to display figures into a 8x8 matrix.

Example:

```c
0x00, 0x00, 0x00, 0x12, 0x12, 0x1E, 0x12, 0x12
```

Each value corresponds with a row in the matrix


You have a couple of tools:

1. **LedMatrixAnimation:** General purpose 8x8 matrix animation
2. **LedMatrixTextScroll:** Text Scrolling

Both of them work for a 8x8 matrix for now, but I have plans to make them generic

# Usage

Both are very easy to understand and use:

## LedMatrixAnimation

You have a sequence of matrixes that represent clips, you can Add/Remove clips, also you can make some actions in every single clip.
Just draw any figure into the clips using the mouse and then test your results in the simulator, once you are happy with the results you can generate the hexadecimal code and paste it to your project.
You can also save and open your designs.

![LedMatrixAnimation](https://user-images.githubusercontent.com/7650467/75801734-ff965d80-5d51-11ea-835a-8a95568d370f.png)

## LedMatrixTextScroll

***Note.*** *This tool is in a very early stage.*

You have a textbox in which you put your text, then you can generate the code and see the results

![LedMatrixTextScroll](https://user-images.githubusercontent.com/7650467/75801839-26ed2a80-5d52-11ea-9173-38ac1a11a73e.png)

# Latest Releases
You can download latest versions

1. [LedMatrixAnimation v1.0](https://github.com/ecoriag/LedMatrix8x8AnimationTools/files/4282825/LedMatrixAnimation_1.0.zip)
2. [LedMatrixScroll v0.9](https://github.com/ecoriag/LedMatrix8x8AnimationTools/files/4282801/LedMatrixTextScroll_0.9.zip)


Any suggestion is welcomed!
