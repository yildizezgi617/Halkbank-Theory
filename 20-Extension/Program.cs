namespace _20_Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!".ReverseString());

            string isim = "fatih";
            Console.WriteLine(isim.CapitaliceFirst(3));

            try
            {
                int x = int.Parse("asda");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetFirendlyMessage());
            }

            Student student = new Student();
            student.Scores.Add(70);
            student.Scores.Add(75);
            student.Scores.Add(55);

            Console.WriteLine(student.IsSuccessful());


            MovieCollection collection = new MovieCollection();
            collection[0] = "Inception";
            Console.WriteLine(collection[2]);

        }
    }
}