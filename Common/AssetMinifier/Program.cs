#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
// See https://aka.ms/new-console-template for more information
using NUglify;

if (args.Length == 0)
{
    return;
}

foreach (var file in args)
{
    if (!File.Exists(file))
    {
        continue;
    }

    var ext = Path.GetExtension(file);
    var content = File.ReadAllText(file);
    string? minified = null;

    try
    {
        if (ext == ".js")
            minified = Uglify.Js(content).Code;
        else if (ext == ".css")
            minified = Uglify.Css(content).Code;
        else
        {
            Console.WriteLine($"Unsupported file: {file}");
            continue;
        }

        var outputFile = Path.Combine(
            Path.GetDirectoryName(file)!,
            Path.GetFileNameWithoutExtension(file) + ".min" + ext
        );

        File.WriteAllText(outputFile, minified);
        Console.WriteLine($"Minified: {outputFile}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Failed to minify {file}: {ex.Message}");
    }
}
