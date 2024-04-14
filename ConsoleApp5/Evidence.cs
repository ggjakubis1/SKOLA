using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Evidence
    {
        private List<Zamestnanec> zamestnanci;
        public Evidence()
        {
            zamestnanci = new();
        }
        public List<Zamestnanec> Zamestnanci => zamestnanci;

        public void vytvorZaznam(string jmeno, string prijmeni)
        {
            zamestnanci.Add(new(getID(), jmeno, prijmeni));

        }
        public void vypisZaznamy()
        {
            Console.WriteLine("ID\tJMENO\tPRIJMENI\n");
            zamestnanci.ForEach(z => Console.WriteLine(z));

        }
        public Zamestnanec vyheldejPodleID(int id) => zamestnanci.First(z => z.Id == id);

        private int getID()
        {
            return zamestnanci.Count == 0 ? 1 : zamestnanci.OrderBy(x => x.Id).Last().Id + 1;
        }
    }
}
