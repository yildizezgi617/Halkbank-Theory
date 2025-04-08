using _25_LINQ.Models;
using System.Linq;

namespace _25_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Ahmet", Age = 20, City = "Istanbul", DepartmentId = 101 },
                new Student { Id = 2, Name = "Mehmet", Age = 22, City = "Ankara", DepartmentId = 102 },
                new Student { Id = 3, Name = "Ayşe", Age = 21, City = "Istanbul", DepartmentId = 101 },
                new Student { Id = 4, Name = "Fatma", Age = 19, City = "Izmir", DepartmentId = 102 },
                new Student { Id = 5, Name = "Hüseyin", Age = 23, City = "Ankara", DepartmentId = 101 }
            };

            List<Department> departments = new List<Department>()
            {
                new Department{Id = 101, Name="Bilgisayar Mühendisliği" },
                new Department{Id = 102, Name="Elektrik Mühendisliği" },
                new Department{Id = 101, Name="Makina Mühendisliği" },
            };

            #region LINQ
            //LINQ Expression (Language Integrated Query)
            //Iki ana kategoriye ayrilir:
            //1-Query Syntax

            //Yasi 20 den buyuk olanlari sirali bir sekilde dondur
            var query = from s in students where s.Age > 20 orderby s.Name select s;

            //2-Method Syntax (Daha cok bunu kullanacagiz.)

            //Yasi 20 den buyuk olanlari sirali bir sekilde dondur.
            var queryM = students.Where(s => s.Age > 20).OrderBy(s => s.Name).Select(s => s);
            #region (Notlar)
            //lambda expression nedir? : ('=>') geriye deger donduren method. uzun uzun yazmak yerine bu sekilde yazilabilir.

            //func icin..
            //mesela int Topla(int x,int y) => x+y; bunu func gibi yazalim.
            //Func<int, int, int> ToplamaIslemi = (x, y) => x + y; olur. (Func da giris ve cikis var sonuncusu cikis)
            // bir ornek daha:
            //bool CiftMi(int x) => x % 2 == 0;
            //Func<int, bool> CiftSayiMi = (x) => x % 2 == 0;
            #endregion
            #endregion

            #region WHERE
            //Method : 
            //Yasi 20 den buyuk öğrencileri dondur.
            var filteredStudents = students.Where(s => s.Age > 20).ToList();
            //birden fazla sorgu varsa && ile devam edilebilir. cunku her turlu sonda bool oluyor.
            var filteredStudentsM = students.Where(s => s.Age > 20 && s.City == "Istanbul").ToList();
            //Zincirleme method cagirimi (where ... where)
            var filteredStudentsM2 = students.Where(s => s.Age > 20).Where(s => s.City == "Istanbul").ToList();

            //Query : 
            //Yasi 20 den buyuk öğrencileri dondur.
            var filteredStudentsQ = (from x in students where x.Age > 20 select x).ToList();
            //birden fazla sorgu varsa && ile devam.
            var filteredStudentsQM = (from x in students where x.Age > 20 && x.City == "Istanbul" select x).ToList();
            #endregion

            #region ORDER BY
            // Method Syntax :
            //(once neyin siralanacagi sonra neye gore siralanacagi yazilir.):
            var sortedStudents = students.OrderBy(s => s.Name).ToList();
            //tersten siralama:
            var sortedStudentsD = students.OrderByDescending(s => s.Name).ToList();
            //ada gore normal, yaşa gore tersten siralama yapmak istersek:
            var sortedStudentsM = students.OrderBy(s => s.Name).ThenBy(s => s.Age).ToList();

            //Query Syntax : 
            //ada göre normal, yaşa göre tersten siralama:
            var sortedStudentsQ = from s in students orderby s.Name, s.Age descending select s;
            #endregion

            #region GROUP BY
            //Method Syntax : 
            var groupedStudent = students.GroupBy(s => s.City).ToList();
            foreach (var item in groupedStudent)
            {
                Console.WriteLine(item.Key);
                foreach (var s in item)
                {
                    Console.WriteLine("\t" + s.Name);
                }
            }
            //listeliyoruz ama liste icerisinde grup var.(IGrouping). gruptaki elemanlara erismek icin dongu icerisinde dongu kullanmamiz lazim yukaridaki foreach icinde foreach gibi

            //Query Syntax :
            var groupedStudentQ = from s in students group s by s.City;

            #endregion

            #region SELECT
            //belirli bir datayi getirmek isteyebiliriz. (generic yapi ile hangi türden oldugunu belirleriz yani name dedigimizde string listesi doner gibi.)

            //Method Syntax : 
            var selectStudent = students.Select(s => s.Name).ToList();
            var selectStudent2 = students.Select(s => new StudentDTO { Name = s.Name, Age = s.Age }); //bu sekilde olusturdugumuz studentDTO listesi donecek. bu sekilde uzerinde islemler yapilabilir.

            //ama her zaman elimizde hazir bir class(tip) olamaz. anlik class lara da ihtiyacimiz olabilir;
            var deneme1 = new StudentDTO { Name = "Fatih", Age = 38 }; // burada hazir bir class var (StudentDTO)
            var deneme2 = new { Adi = "Fatih", Yasi = "38" }; // herhangi bir isim vermeden anlik olarak class hazirladik. bunlara anonim class lar denir. (type a)

            var selectStudent3 = students.Select(s => new { Name = s.Name, Age = s.Age }); //(***bu sekilde de bir anonim class olur (type a)) yine icinde foreach ile donulebilir.

            //Query Syntax : 
            var selectStudentQ = from s in students select new { Name = s.Name, Yas = s.Age };
            #endregion

            #region JOIN
            //birlestirme.

            //Method Syntax :
            var joinedData = students.Join(departments,         // Inner
                                           s => s.DepartmentId, //Outher key
                                           d => d.Id,           //Inner key
                                           (s, d) => new        //Result
                                           {
                                               OgrenciAdi = s.Name,
                                               OgrenciYasi = s.Age,
                                               OgrenciBolumu = d.Name
                                           });
            //burada bir class olusturmussun ve onun icerisinde OgrenciAdi, OgrenciYasi ve OgrenciBolumu olarak 3 adet prop var gibi dusun.

            //Query Syntax :
            var joinedDataQ = from s in students
                              join d in departments on s.DepartmentId equals d.Id
                              select new
                              { OgrenciAdi = s.Name, OgrenciYasi = s.Age, OgrenciBolumu = d.Name };
            #endregion

            //Method Syntax in ekstra olarak sagladigi ozellikler :
            #region All
            //Hepsi belirli bir kosulu sagliyorsa true doner aksi takdirde false doner.
            bool allStudentsPassed = students.All(x => x.Age > 20);  //false doner. (true donmesi icin hepsinin 20 den buyuk olmasi gerekiyordu.)
            bool allStudentsPassed1 = students.All(x => x.Age > 17); //true doner.
            #endregion

            #region Any
            bool hasPassedStudent = students.Any(x => x.Age > 20); //true doner. 20 den buyuk data var.
            #endregion

            #region Contains
            bool containsStudent = students.Contains(new Student { Id = 5, Name = "Huseyin", Age = 23, City = "Ankara", DepartmentId = 101 }); // yeni bir nesne olusturuldugu icin false doner.

           // bool containsStudent1 = students.Contains(new Student { Id = 5, Name = "Huseyin", Age = 23, City = "Ankara", DepartmentId = 101 }, new StudentEqualityComparer()); // karsilastirmayi olusturdugumuz bu(StudentEqualityComparer) algoritmaya gore yapacagindan dolayi true doner.
            #endregion

            //Aggregate fonksiyonlar:
            #region Average
            //ortalama alir.
            double avarageAge = students.Average(x => x.Age);
            #endregion

            #region Count
            var adultStudents = students.Count(x => x.Age > 20); // yasi yirmiden buyuk olanlari topla
            #endregion

            #region Max-Min
            var max = students.Max(x => x.Age); //en buyuk yas.
            var min = students.Min(x => x.Age); //en kucuk yas.

            #endregion

            #region Sum
            //yaslarin toplami :
            var sumOfAge = students.Sum(x => x.Age);

            //asagidaki sonuc 4 cikar. (bu sekilde detaylandirilabilir.)
            var numOfAdults = students.Sum(s =>
            {
                if (s.Age >= 20)
                    return 1;
                else
                    return 0;
            });
            #endregion

            //--

            #region Element
            //Belirli bir ogeyi yakalamk icin kullanilir. Belirtilen indekste eleman varsa o elemani dondurur, yoksa hata verir.
            var student1 = students.ElementAt(2); // 2.indeksteki ogrencinin bilgisini yani nesneyi bana getirir. bulamazsa hata verir.
            var student2 = students.ElementAtOrDefault(9); // Aslinda digeri ile ayni, sadece indekste eleman yoksa default degeri olan null doner ve hata vermez.

            #endregion

            #region First-FirstOrDefault
            var first1 = students.First(s => s.Age > 20); // istenilen datalardan ilk buldugunu dondurur. bulamazsa hata verir.
            var first2 = students.FirstOrDefault(s => s.Age > 50); // istenilen datalardan ilk buldugunu dondurur. bulamazsa default degeri olan null doner ve hata vermez.
            #endregion

            #region Last-LastOrDefault
            var Last1 = students.Last(s => s.Age > 20); // istenilen datalardan son buldugunu dondurur. bulamazsa hata verir.
            var Last2 = students.LastOrDefault(s => s.Age > 50); // istenilen datalardan son buldugunu dondurur. bulamazsa default degeri olan null doner ve hata vermez.
            #endregion

            #region Single-SingleOrDefault
            var single1 = students.Single(s => s.Age > 20); // istenilen datalardan sadece bir tane buldugunu dondurur. birden fazla varsa hata verir. yani burada hata verir. bunu daha cok birden fazla var mi? kontrolu yapmak istedigimiz zaman kullaniriz.
            var single2 = students.SingleOrDefault(s => s.Age > 50); // istenilen datalardan sadece bir tane buldugunu dondurur. birden fazla varsa hata verir. hic yoksa default degeri olan null doner.
            #endregion

            #region Skip-SkipWhile
            //Belirli bir sayida ogeyi atlamak icin kullanilir.
            var afterSkip = students.Skip(2).ToList(); // ilk 2 elemani atla ve sonrasini getir. (5 elemanli listemiz vardi 3 elemanli dondu.) 
            var afterSkip2 = students.SkipWhile(s => s.Age < 21).ToList(); // ilk 21 den kucuk olanlari atla ve sonrasini getir. Fatma ve ahmeti atlar digerlerini getirir.
            #endregion

            #region Take-TakeWhile
            var firstThreeStudents = students.Take(3).ToList(); // ilk 3 elemani alir. (ilk 3 elemani alir ve sonrasini atlar.)
            var firstThreeStudents2 = students.TakeWhile(s => s.Age < 21).ToList(); // ilk 21 den kucuk olanlari alir.
            #endregion
        }
    }
}
