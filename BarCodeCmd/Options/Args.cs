using CommandLine;

namespace BarCodeCmd.Options;

internal sealed class Args
{
    [Option('i', "input", Required = true, HelpText = "Input string")]
    public string? Input { get; set; }

    [Option('w', "width", Required = true, HelpText = "Width of the target image")]
    public int Width { get; set; }

    [Option('h', "height", Required = true, HelpText = "Height of the target image")]
    public int Height { get; set; }

    [Option('d', "dest", Required = true, HelpText = "Destination image file. Should have .png extension")]
    public string? Destination { get; set; }
}