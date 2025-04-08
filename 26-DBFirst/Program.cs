namespace _26_DBFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbRehberContext db = new DbRehberContext();
           var rehbers = db.TelefonRehberis.Where(x => x.KisiId > 2).ToList();
           

            foreach (var item in rehbers) 
            {
                Console.WriteLine(item.KisiAd + " " + item.KisiTelefon);
            }

            db.TelefonRehberis.Add(new TelefonRehberi()
            {
                KisiAd = "Ali",
                KisiSoyadi = "Yılmaz",
                KisiTelefon = "1234567890"
            });
            db.SaveChanges();

        }
    }
}
