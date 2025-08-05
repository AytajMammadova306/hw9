using homework8.models;
namespace homework8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student1 = new Student("Aytaj", "Mammadova", "PB306", 99/* umidler*/);
            //student1.PrintInfo();
            //student1.GetDiplomDegree();

            Product product1 = new Product("ASUS", "ViviBook", 1500, 200, 3);
            product1.PrintInfo();
            //product1.BrandName = "NewBrand";

            //Console.WriteLine(product1.Model);

            //product1.Price = 1200;
            //Console.WriteLine(product1.Price);

            //Console.WriteLine(product1.Cost);
            //product1.Cost = 150;
            //Console.WriteLine(product1.Cost);

            //Console.WriteLine(product1.Income);

            //Console.WriteLine(product1.Count);


            Phone phone1 = new Phone("sumsung", "S23", 1500, 300, 20, 256);
            phone1.PrintPhoneInfo();
            //phone1.Pay(5);
            //Console.WriteLine(phone1.Balance);
            //phone1.Call(30);
            //Console.WriteLine(phone1.Balance);
        }
    }
}
