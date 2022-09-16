using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Model
{
    internal class Najam
    {
        public int ID { get; set; }
        public int ID_vozila { get; set; }
        public string OIB_kupca { get; set; }
        public DateOnly DatumNajma { get; set; }
        public int BrojDana { get; set; }
        public int Cijena { get; set; }
    }
}
