namespace LibrairieConversionNote
{
    public class ConversionAlphabetiqueToNote
    {
        public string Transformer(string alphabetic)
        {
            alphabetic = alphabetic.ToUpper().Trim();
            var strRetour = "Erreur, la note n’existe pas. Veuillez entrer une note alphabétique entre A et G:";
            if (alphabetic == "A")
            {
                strRetour = "LA";
            }
            else if (alphabetic == "B")
            {
                strRetour = "SI";
            }
            else if (alphabetic == "C")
            {
                strRetour = "DO";
            }
            else if (alphabetic == "D")
            {
                strRetour = "RE";
            }
            else if (alphabetic == "E")
            {
                strRetour = "MI";
            }
            else if (alphabetic == "F")
            {
                strRetour = "FA";
            }
            else if (alphabetic == "G")
            {
                strRetour = "SOL";
            }

            return strRetour;
        }
    }
}