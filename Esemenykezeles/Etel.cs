using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esemenykezeles
{
    class Etel
    {
		public string megnevezes;
		public string[] hozzavalok;

		public Etel(string megnevezes, string[] hozzavalok)
		{
			this.megnevezes = megnevezes;
			this.hozzavalok = hozzavalok;
		}
	}

	public delegate void RendelesTeljesitesKezelo(string etelNeve);
	public delegate void HozzavaloSzuksegesKezelo(string hozzavalo);
	public delegate void HozzavaloElkeszultKezelo(string hozzavalo);

}
