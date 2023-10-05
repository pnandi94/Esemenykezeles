using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Esemenykezeles
{
	class Program
	{
		static void Main(string[] args)
		{
			Sef teszt = new Sef();
			teszt.RendelesTeljesitve += elkeszult;
			teszt.RendelesNemTeljesitheto = Nemsikerult;
			Szakacs Viktor = new Szakacs("Viktor", "viz");
			teszt.Felvesz(Viktor);
			teszt.Megrendeles("poharviz");
			teszt.Megrendeles("madártej");
			KorlatosSzakacs Reka = new KorlatosSzakacs("Réka", "repa", 2);
			KorlatosSzakacs Hugo = new KorlatosSzakacs("Hugó", "hus", 3);
			KorlatosSzakacs Klara = new KorlatosSzakacs("Klára", "krumpli", 4);
			teszt.Felvesz(Reka);
			teszt.Felvesz(Hugo);
			teszt.Felvesz(Klara);
			teszt.Megrendeles("rantothus");
			teszt.Megrendeles("fozelek");
			teszt.Megrendeles("leves");
			teszt.Megrendeles("rantothus");
			teszt.Megrendeles("fozelek");
			;
		}
		public static void elkeszult(string Etelneve) { Console.WriteLine(Etelneve); }
		public static void Nemsikerult(string Etelneve) { Console.WriteLine(Etelneve); }
	}
}
