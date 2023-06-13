using LibrairieConversionNote;

class Program
{
    private static void Main(string[] args)
    {

        while (true)
        {
            Console.Write("Type de conversion: ");
            var input = Console.ReadLine();

            if (input == "Note")
            {
                while (true)
                {
                    Console.Write("NOTE: ");
                    var note = Console.ReadLine();
                    ConversionAlphabetiqueToNote convertiseur = new ConversionAlphabetiqueToNote();
                    string ret = convertiseur.Transformer(note);
                    Console.WriteLine(ret);
                }
            }
        }

        

    }
}