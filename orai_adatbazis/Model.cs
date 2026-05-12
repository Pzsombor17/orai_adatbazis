using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orai_adatbazis
{
    public class Muzeum
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int Price { get; set; }
        public double Rating { get; set; }
        public string Type { get; set; }

    }
    public class Model
    {
        public List<Muzeum> muzeums = new();
        public Model() 
        {
            Import();
        }
        private void Import()
        {
            muzeums = File.ReadAllLines("muzeumok.txt").Skip(1)
                .Select(x=> x.Split(';')).Select(x=> new Muzeum 
                {
                    Name = x[0],
                    City = x[1],
                    Address = x[2],
                    Price = Convert.ToInt32 (x[3]),
                    Rating = Convert.ToDouble (x[4]),
                    Type = x[5]
                }).ToList();
        }
    }
}
