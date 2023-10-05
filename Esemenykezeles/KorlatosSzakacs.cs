using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esemenykezeles
{
    internal class KorlatosSzakacs : Szakacs
    {
		public int mennyiseg;
		public KorlatosSzakacs(string nev, string specialitas, int mennyiseg) : base(nev, specialitas)
		{
			this.mennyiseg = mennyiseg;
		}
		public HozzavaloElkeszultKezelo HozzavaloNemKeszithetoEl;
		public override void Foz()
		{
			if (mennyiseg > 0)
			{
				base.Foz();
				mennyiseg--;
			}
			else
			{
				HozzavaloNemKeszithetoEl.Invoke("Sajnos egy hozzávaló nem készíthető el.");
			}

		}
	}
}
