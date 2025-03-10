  namespace _20_Extension 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Extension genişletme metotları, var olan bir tipin(sınıf interface method) içini genişletmemizi sağlar.
            //yapıyı değiştirmedn ozellik eklenebilir.
            Console.WriteLine("Hello World".ReverseString());

            string isim = "fatih";
            Console.WriteLine(isim.ToFirstUpper());

            Console.WriteLine(isim.ToFirstUpper(2));


            try
            {
                int x = int.Parse("asdA");
            }
            catch (Exception)
            {

                Console.WriteLine(Exception.);
            }


            Student student = new Student();
            student.Scores.Add(50);
            student.Scores.Add(60);
            student.Scores.Add(80);
            Console.WriteLine( student.IsSuccessfull());


            MovieCollection movieCollection = new MovieCollection();    
            movieCollection[0] = "film1";
            Console.WriteLine(movieCollection[2]);
        }
    }
}
