using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Zamestnanec
    {
        public int Id { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public Zamestnanec(int id, string jmeno, string prijmeni)
        {
            Id = id;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }
        public override string ToString()
        {
            return $"{Id}\t{Jmeno}\t{Prijmeni}";
        }
    }
}
