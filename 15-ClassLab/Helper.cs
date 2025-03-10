namespace _15_ClassLab
{
    public static class Helper
    {
        public static string CheckTurkishChracter(string param)
        {
            string[] turkce = { "Ç", "Ğ", "İ", "Ö", "Ş", "Ü", "ç", "ğ", "ı", "ö", "ş", "ü" };
            string[] ingilizce = { "C", "G", "I", "O", "S", "U", "c", "g", "i", "o", "s", "u" };

            for (int i = 0; i < turkce.Length; i++)
            {
                param = param.Replace(turkce[i], ingilizce[i]);
            }

            return param.ToUpper();
        }
    }
}