using CommandLine;

namespace BarCodeCmd.Options;

internal sealed class Args
{
    [Option('i', "input", Required = true)]
    public string? Input { get; set; }

    [Option('w', "width", Required = true)]
    public int Width { get; set; }

    [Option('h', "height", Required = true)]
    public int Height { get; set; }

    [Option('d', "dest", Required = true)]
    public string? Destination { get; set; }
}