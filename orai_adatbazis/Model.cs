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
        public List<string> BeginChar(char betu)
        {
            return muzeums.Where(x => x.Name[0]==betu).Select(x => x.Name).ToList();
        }
        public string LowestRating()
        {
            return muzeums.OrderBy(x => x.Rating).Select(x=>x.Name).First();
        }
        public double HighestRating(string type)
        {
            return muzeums.Where(x => x.Type == type).Max(x => x.Rating);
        }
        public double AvgRating()
        {
            return muzeums.Average(x => x.Rating);
        }
        public int CountCity(string city)
        {
            return muzeums.Where(x => x.City == city).Count();
        }
        public List<string> EqualRating(double rating)
        {
            return muzeums.Where(x => x.Rating == rating).Select(x => x.Name).ToList();
        }
        public int CountRating()
        {
            return muzeums.Where(x => x.Rating > 3.6).Count();
        }
        public List<string> Idontknow(string type, double maxrating)
        {
            return muzeums.Where(x => x.Type == type && x.Rating < maxrating).Select(x => x.Name).ToList();
        }
        public List<string> MuseumType(string citynamepart)
        {
            return muzeums.Where(x => x.City.Contains(citynamepart)).Select(x => x.Name).ToList();
        }
        public int MinRating(double minrating)
        {
            return muzeums.Where(x => x.Rating > minrating).Count();
        }
        public string MuseumType2(string name)
        {
            return muzeums.Where(x => x.Name == name).Select(x => x.Type).First();
        }
        public List<string> BetweenRating(double minrating, double maxrating)
        {
            return muzeums.Where(x => x.Rating >= minrating && x.Rating <= maxrating).Select(x => x.Name).ToList();
        }
        public List<string> MuseumType3(string type)
        {
            return muzeums.Where(x => x.Type == type).Select(x => x.Name).ToList();
        }
        public List<string> NameLength(int minnamelength)
        {
            return muzeums.Where(x => x.Name.Length > minnamelength).Select(x => x.Name).ToList();
        }
        public List<string> WordCount(int number)
        {
            return  muzeums.Where(x=> x.Name.Split(' ').Length == number).Select(x => x.Name).ToList();
        }
        public List<string> WordCount2(string type,double minrating)
        {
            return muzeums.Where(x => x.Type == type && x.Name.Split(' ').Length > 2 && x.Rating > minrating).Select(x => x.Name).ToList();
        }
        public List<string> AvgMuseumRating(string cityname)
        {
            double avg = muzeums.Where(x => x.City == cityname).Average(x => x.Rating);
            return muzeums.Where(x => x.City == cityname && x.Rating > avg).Select(x => x.Name).ToList();
        }

        
        

    }
}
