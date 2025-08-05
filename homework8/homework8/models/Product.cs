
namespace homework8.models
{
    internal class Product
    {
        private string _brandName;
        private string _model;
        private decimal _price;
        private decimal _cost;
        private decimal _income;
        private double _count;
        public string BrandName
        {
            get
            {
                return _brandName;
            }
            set
            {
                Console.WriteLine("Are you sure you want to change Brand Name? (yes/no)");
                if (Console.ReadLine() == "yes")
                {
                    _brandName = value;
                    Console.WriteLine($"New Brand new created:{_brandName}");
                }
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
        }

        public decimal Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public decimal Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                _cost = value;
            }
        }

        public decimal Income
        {
            get
            {
                return _income;
            }
        }

        public double Count
        {
            get
            {
                return _count;
            }
        }

        public Product(string brandName, string model, decimal price,decimal cost,double count)
        {
            _brandName = brandName;
            _model = model;
            Price = price;
            Cost = cost;
            if (count > 0)
            {
                _count = count;
            }
            else
            {
                count = 0;
            }
            
        }
        
        public void PrintInfo()
        {
            Console.WriteLine($"Brand Name:{BrandName}, Model:{Model}, Price:{Price}, Cost:{Cost}, Count:{Count}");
        }

        public void Sale(int soldcount)
        {
            if (soldcount <= _count)
            {
                _count -= soldcount;
                _income += soldcount * Price - Cost;
            }
            else
            {
                Console.WriteLine("you don't have that much products");
            }
        }

        public double Refill(double count)
        {
            _count += count;
            return -count;
        }

    }
}
