
namespace homework8.models
{
    internal class Phone:Product
    {
        private int _ram;
        private string _color;
        private decimal _balance;

        public int RAM
        {
            get 
            {
                return _ram;
            }
        }

        public string Color
        {
            get 
            {
                return _color;

            }
        }

        public decimal Balance
        {
            get
            {
                return _balance;
            }
        }

        public Phone(string brandname,string model, decimal price, decimal cost, double count, int ram, string color="Black"): base (brandname,model,price,cost,count)
        {
            _ram = ram;
            _color = color;
        }

        public void Pay(int money)
        {
            _balance += money;
        }

        public void Call(int seconds)
        {
            if (seconds * 0.1m <= _balance)
            {
                _balance -= seconds * 0.1m;
                Console.WriteLine("zeng edildi");
            }
            else
            {
                Console.WriteLine("balansda kifayet qeder vesait yoxdur");
            }
        }
    }
}
