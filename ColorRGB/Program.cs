using System;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

ColorRGB red = new ColorRGB(255, 0, 0);
ColorRGB white = new ColorRGB(255, 255, 255);
ColorRGB custom = new ColorRGB(101, 150, 200);

Console.WriteLine($"빨강 - R: {red.R}, G: {red.G}, B: {red.B} → 밝기: {red.GetBrightness()}");
Console.WriteLine($"흰색 - R: {white.R}, G: {white.G}, B: {white.B} → 밝기: {white.GetBrightness()}");
Console.WriteLine($"커스텀 - R: {custom.R}, G: {custom.G}, B: {custom.B} → 밝기: {custom.GetBrightness()}");

struct ColorRGB 
{
    public uint R;
    public uint G;
    public uint B;

    public ColorRGB(uint r, uint g, uint b)
    {
        this.R = r;
        this.G = g;
        this.B = b;
    }

    public uint GetBrightness()
    {
        return (R + G + B) / 3;
    }
}