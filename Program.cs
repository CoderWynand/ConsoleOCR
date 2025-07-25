using System;
using Tesseract;


class Program
{
    static void Main(string[] args)
    {

        // string languageCode = getUserInput();
        string languageCode = getLanguageCode();
        string path = getImagePath();
        var processor = new OCRProcessor(@"C:\Users\wynan\OneDrive\Desktop\C# stuff\Test\tessdata", languageCode);


        try
        {
            Console.WriteLine(processor.ProcessImage(path));
        }

        catch (FileNotFoundException fnf)
        {
            Console.WriteLine("Image file not found: " + fnf.Message);
        }
        catch (TesseractException tex)
        {
            Console.WriteLine("Tesseract failed to process the image: " + tex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }


    }

    public static string getLanguageCode()
    {
        Console.WriteLine(@"Please select the language you wish to translate from. 
        Options are: English(eng), Mandarin Chinese Simplified(chi_sim), 
        Mandarin Chinese Traditional(chi_tra), Hindi(hin),
        Spanish(spa) or French(fra)");

        string? userChoice = Console.ReadLine();

        while (true)
        {
            if (userChoice == "eng" || userChoice == "chi_sim" || userChoice == "chi_tra" || userChoice == "hin" || userChoice == "spa" || userChoice == "fra")
            {
                return userChoice;
            }
            else
            {
                Console.WriteLine("Please enter a valid choice, i.e. the language code between brackets, or type \"quit\" to quit");

                userChoice = Console.ReadLine();

                if (string.Equals(userChoice, "quit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            }
        }

        return "Console.ReadLine()";
    }

    public static string getImagePath()
    {
        Console.WriteLine("Please specify the image path");
        string path = "";

        while (true)
        {
            path = Console.ReadLine()!;

            if (path != null)
            {
                break;
            }

            Console.WriteLine("Please specify a valid path");

            path = Console.ReadLine()!;
        }

        return path;

    }
}
