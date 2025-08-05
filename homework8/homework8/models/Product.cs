
namespace homework8.models
{
    internal class Product
    {
        protected string _brandName;
        protected string _model;
        protected decimal _price;
        protected decimal _cost;
        protected decimal _income;
        protected double _count;
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
                if (_price <= 0)
                {
                    Console.WriteLine("Wrong price");
                }
                
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
            Console.WriteLine($"Brand Name:{_brandName}, Model:{_model}, Price:{_price}, Cost:{_cost}, Count:{_count}");
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
