using SixLabors.ImageSharp;
if (args.Length == 0)
    return; 

foreach(var arg in args)
{
    try
    {
        using (var image = Image.Load(arg))
        {
            var outPath = Path.GetFileNameWithoutExtension(arg) + ".png";
            image.SaveAsPng(outPath);
        }
        File.Delete(arg);
    }catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}