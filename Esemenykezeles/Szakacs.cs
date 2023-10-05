using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Esemenykezeles
{
    internal class Szakacs
	{
		public string nev { get; }
		public string specialitas { get; }

		public Szakacs(string nev, string specialitas)
		{
			this.nev = nev;
			this.specialitas = specialitas;
		}

		public HozzavaloElkeszultKezelo HozzavaloElkeszult;
        public virtual void Foz()
        {
			Console.WriteLine(nev + " dolgozik rajta");
			HozzavaloElkeszult(specialitas);
			
		}

		public void SefKerValamit(string hozzavalo)
		{
			if (hozzavalo == specialitas)
			{
				Foz();
			}
		}


	}
}
