using Tesseract;

class OCRProcessor
{
    private readonly string _tessDataPath;
    private readonly string _languageCode;

    public OCRProcessor(string tessDataPath, string languageCode)
    {
        _tessDataPath = tessDataPath;
        _languageCode = languageCode;
    }

    public string ProcessImage(string imagePath)
    {
        using var engine = new TesseractEngine(_tessDataPath, _languageCode, EngineMode.Default);
        using var img = Pix.LoadFromFile(imagePath);
        using var page = engine.Process(img);
        return page.GetText();
    }
}