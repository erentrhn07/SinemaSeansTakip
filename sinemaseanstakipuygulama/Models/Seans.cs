using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinemaseanstakipuygulama
{
    public class Seans
    {
        public int SeansID { get; set; }
        public int FilmID { get; set; }
        public int SalonID { get; set; }
        public DateTime TarihSaat { get; set; }
        public int DoluKoltukSayisi { get; set; }
    }
}
