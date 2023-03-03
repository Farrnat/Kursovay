using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoParts
{
    public class Engine
    {
        public int id { get; set; }
        private string brand, type, rub;


        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Rub
        {
            get { return rub; }
            set { rub = value; }
        }

        public Engine() { }

        public Engine(string Brand, string Type)
        {
            this.Brand = Brand;
            this.Type = Type;
            this.Rub = Rub;

        }

        public override string ToString()
        {
            return "Брэнд: " + Brand + ". Тип: " + Type + ". Цена: "+Rub;
        }
    }
}
