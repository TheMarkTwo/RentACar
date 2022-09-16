using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Model
{
    internal class Vozilo
    {
        public int ID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public decimal Kubikaza { get; set; }
        public int Snaga { get; set; }
        public int Brzina { get; set; }
        public decimal NulaDoSto { get; set; }
        public decimal CijenaDan { get; set; }
        public string Slika { get; set; }
    }
}
