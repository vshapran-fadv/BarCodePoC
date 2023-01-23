using BarcodeLib;
using System.Drawing.Imaging;
using System.Drawing;
using BarCodeCmd.Options;
using CommandLine;

Parser.Default.ParseArguments<Args>(args).WithParsed(a =>
{
    var foreColor = Color.Black;
    var backColor = Color.White;

    using var barcode = new Barcode();

    var img = barcode.Encode(TYPE.CODE128, a.Input, foreColor, backColor,
        a.Width, a.Height);

    if (string.IsNullOrEmpty(a.Destination))
    {
        throw new ArgumentException("Destination cannot be empty. Please specify valid png file path");
    }

    var outputDir = Path.GetDirectoryName(a.Destination);
    if (outputDir != null && !Directory.Exists(outputDir))
    {
        Directory.CreateDirectory(outputDir);
    }

    img.Save(a.Destination, ImageFormat.Png);
});