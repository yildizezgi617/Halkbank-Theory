using System.IO;

namespace _11_SystemIO
{
    internal class Program
    {
        const string filePath = @"C:\Users\fatih.alkan\Desktop\Products";
        static List<string> productCodes = new List<string>();
        static List<string> productNames = new List<string>();
        static List<double> productPrices = new List<double>();
        static List<string> customers = new List<string>();
        static List<string> orders = new List<string>();
        static void Main(string[] args)
        {

            #region File
            //Dosya işlemleri için kullanılan statik bir sınıftır.

            string filePath = @"C:\Users\fatih.alkan\Desktop\new.txt";

            //if (File.Exists(filePath))
            //{
            //    File.WriteAllText(filePath, "Merhaba Dünya! \n\tFatih Alkan");
            //}
            //else 
            //{
            //    File.Create(filePath);
            //    Console.WriteLine("TXT Oluşturuldu.");
            //}


            //string[] content = File.ReadAllLines(filePath);

            //foreach (var item in content)
            //{
            //    Console.WriteLine(item);
            //}


            //File.Copy(filePath, "C:\\Users\\fatih.alkan\\Desktop\\KD-26\\example.txt");


            //File.Delete("C:\\Users\\fatih.alkan\\Desktop\\KD-26\\example.txt");

            //File.WriteAllText(filePath,"Deneme");
            //File.AppendAllText(filePath, "Merhaba");
            #endregion

            #region FileInfo

            //FileInfo fileInfo = new FileInfo(filePath);

            //Console.WriteLine("Dosya Var mı: " + fileInfo.Exists);
            //Console.WriteLine("Dosya oluşturma tarihi: " + fileInfo.CreationTime);
            //Console.WriteLine("Dosyanın Tam İsmi: " + fileInfo.FullName);
            //Console.WriteLine("Dostanın Ismi: " + fileInfo.Name);
            //Console.WriteLine("Dosyanın Uzantısı: " + fileInfo.Extension);
            //Console.WriteLine("Dosyanın Değişiiklik Tarihi: " + fileInfo.LastWriteTime);
            //Console.WriteLine("Dosyanın Boyutu: " + fileInfo.Length);
            //Console.WriteLine("Dosyanın Adresi: " + fileInfo.DirectoryName);

            #endregion

            #region Directory
            //string folderPath = @"C:\Users\fatih.alkan\Desktop\new3";

            //Directory.CreateDirectory(folderPath);
            //Directory.Exists(folderPath);
            //Directory.Delete(folderPath);
            //Directory.Move(folderPath, "");
            #endregion

            #region DirectoryInfo
            //DirectoryInfo fi = new DirectoryInfo(folderPath);
            //Console.WriteLine("Klasörün Adı: " + fi.Name);
            //Console.WriteLine("Klasörün Tam Adı: " + fi.FullName);
            //Console.WriteLine("Klasörün Oluşma Tarihi: " + fi.CreationTime);
            //Console.WriteLine("Klasörün En Son Erişim Tarihi: " + fi.LastAccessTime);
            //Console.WriteLine("Klasörün Var mı: " + fi.Exists);
            //Console.WriteLine("Klasörün Kök Dizini: " + fi.Root);
            #endregion

            #region DriveInfo
            //DriveInfo info = new DriveInfo("C");

            //Console.WriteLine("Kulanılabilir: " + info.AvailableFreeSpace);
            //Console.WriteLine("Boş: " + info.TotalFreeSpace);
            //Console.WriteLine("Toplam: " + info.TotalSize);
            //Console.WriteLine("Format: " + info.DriveFormat);
            //Console.WriteLine("Tipi: " + info.DriveType);
            //Console.WriteLine("ismi: " + info.Name);
            //Console.WriteLine("Kök: " + info.RootDirectory);
            //Console.WriteLine("etiketi: " + info.VolumeLabel);

            //Console.WriteLine();
            #endregion

            #region Path
            Console.WriteLine("Dizin: " + Path.GetDirectoryName(filePath));
            Console.WriteLine("Dosya Adı: " + Path.GetFileName(filePath));
            Console.WriteLine("Uzantısız Dosya Adı: " + Path.GetFileNameWithoutExtension(filePath));
            Console.WriteLine("Uzantı: " + Path.GetExtension(filePath));

            string relativePath = @"..\..\readme.txt";
            Console.WriteLine(Path.GetFullPath(relativePath));

            string folder = @"D:\temp";
            string filename = "readme.txt";

            Console.WriteLine(Path.Combine(folder, filename));
            Console.WriteLine(Path.ChangeExtension(filePath, ".pdf"));

            #endregion

            #region FileStream
            //using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read)) 
            //{
            //    byte[] buffer = new byte[1024];
            //    int bytesRead = fileStream.Read(buffer, 0, buffer.Length);

            //    Console.WriteLine($"Okunan Bayt Sayısı: {bytesRead}");
            //    Console.WriteLine("İçerik: " + System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead));
            //}

            ////StreamReader

            //using (StreamReader reader = new StreamReader(filePath))
            //{
            //    string line;
            //    while ((line = reader.ReadLine()) != null) 
            //    {
            //        Console.WriteLine(line);
            //    }
            //}

            ////StreamWriter

            //using (StreamWriter writer = new StreamWriter(filePath)) 
            //{
            //    writer.WriteLine("Merhaba");
            //}


            #endregion


            while (true)
            {
                Console.WriteLine("[1] Müşteriler [2] Ürünler [3] Satış");
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        GetCustomers();
                        break;
                    case "2":
                        GetProducts();
                        break;
                    case "3":
                        bool isContinue = true;
                        while (isContinue)
                        {
                            Orders();
                            Console.WriteLine("Devam mı? [Evet] [Hayır]");
                            isContinue = Console.ReadLine().ToLower() == "hayır" ? false : true;

                        }
                        Completed();
                        break;
                    default:
                        break;
                }
            }

        }

        private static void GetProducts()
        {
            string path = Path.Combine(filePath, "products.txt");

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var items = line.Split('-');
                    productCodes.Add(items[0]);
                    productNames.Add(items[1]);
                    productPrices.Add(double.Parse(items[2]));
                    Console.WriteLine(line);
                }
            }
        }

        private static void GetCustomers()
        {
            string path = Path.Combine(filePath, "customers.txt");

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                int i = 1;
                while ((line = reader.ReadLine()) != null)
                {
                    customers.Add(line);
                    Console.WriteLine($"{i} - " + line);
                }
            }
        }

        private static void Orders()
        {
            Console.WriteLine("Ürün Kodu");
            string kod = Console.ReadLine();

            if (orders.Contains(kod))
            {
                Console.WriteLine("Bu ürün zaten ekli");
            }
            else
            {
                orders.Add(kod);
                Console.WriteLine("Ürün eklendi");
            }
        }

        private static void Completed()
        {
            int say = 0;
            foreach (var item in customers)
            {
                Console.WriteLine(say + " " + item);
                say++;
            }
            Console.Write("Müşteri No: ");
            int customerNo = int.Parse(Console.ReadLine());
            string customer = "";
            if (customers.Count >= customerNo)
            {
                customer = customers[customerNo];
            }

            string dPath = Path.Combine(filePath, customer);

            if (Directory.Exists(dPath))
            {
                CreateTax();
            }
            else
            {
                Directory.CreateDirectory(dPath);
                CreateTax();
            }

            void CreateTax()
            {
                string fPath = Path.Combine(dPath, Guid.NewGuid().ToString() + ".txt");
                File.WriteAllLines(fPath, orders.ToArray());
            }
        }

    }
}