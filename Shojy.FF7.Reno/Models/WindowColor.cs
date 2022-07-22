using System.Drawing;
using System.Runtime.InteropServices;

namespace Shojy.FF7.Reno.Models;

[PublicAPI]
[StructLayout(LayoutKind.Explicit, Size = 0xC)]
public record struct WindowColor
{
    [FieldOffset(0x0)]
    public FFColor TopLeft;

    [FieldOffset(0x3)]
    public FFColor TopRight;

    [FieldOffset(0x6)]
    public FFColor BottomLeft;

    [FieldOffset(0x9)]
    public FFColor BottomRight;

    public Color Average => GetAverageColor();


    /// <summary>
    /// Calculates the average color from the 4 positional colors. 
    /// </summary>
    /// <returns></returns>
    private Color GetAverageColor()
    {
        return Color.FromArgb(
            red: GetValueAverage(TopLeft.Red, TopRight.Red, BottomLeft.Red, BottomRight.Red),
            green: GetValueAverage(TopLeft.Green, TopRight.Green, BottomLeft.Green, BottomRight.Green),
            blue: GetValueAverage(TopLeft.Blue, TopRight.Blue, BottomLeft.Blue, BottomRight.Blue)
        );
    }

    /// <summary>
    /// Uses a squared mean to calculate the average color
    /// </summary>
    /// <param name="values"></param>
    /// <returns></returns>
    private static int GetValueAverage(params int[] values)
    {
        double sum = values.Sum(v => v * v);
        var mean = Math.Sqrt(sum / values.Length);
        return (int)Math.Round(mean);
    }
}