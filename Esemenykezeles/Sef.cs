using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Esemenykezeles
{
    internal class Sef
    {
		Etel[] receptek = new Etel[]
		{
			new Etel("poharviz", new string[] { "viz" }),
			new Etel("leves", new string[] { "repa", "hus", "krumpli", "viz" }),
			new Etel("rantothus", new string[] { "hus", "krumpli" }),
			new Etel("fozelek", new string[] { "viz", "repa" })
		};

		public RendelesTeljesitesKezelo RendelesTeljesitve;
		public RendelesTeljesitesKezelo RendelesNemTeljesitheto;
		public HozzavaloSzuksegesKezelo HozzavaloSzukseges;

		private Etel cel;
		private int szuksegesHozzavaloSzam;

		public void Megrendeles(string etelNeve)
		{
			Console.WriteLine("Séf: Rendelés beérkezett " + etelNeve);
			bool vane = false;
			int index = -1;
			for (int i = 0; i < receptek.Length; i++)
			{
				if (receptek[i].megnevezes == etelNeve)
				{
					vane = true;
					index = i;
				}
			}
			if (vane)
			{
				Elkeszites(receptek[index]);
			}
			else
			{
				RendelesNemTeljesitheto.Invoke("Séf: A(z) " +etelNeve+ " rendelés nem teljesíthető!");
			}
		}

		public void Elkeszites(Etel recept)
		{
			cel = recept;
			szuksegesHozzavaloSzam = recept.hozzavalok.Length;
			for (int i = 0; i < recept.hozzavalok.Length; i++)
			{
				HozzavaloSzukseges(recept.hozzavalok[i]);
			}

		}

		public void SzakacsElkeszult(string hozzavalo)
		{
			szuksegesHozzavaloSzam--;
			if (szuksegesHozzavaloSzam == 0)
			{
				RendelesTeljesitve("Séf: A(z) " + cel.megnevezes + " elkészült! ");
				//Console.WriteLine("A " + cel.megnevezes + "-et, az alábbi személyzet készítette:");
			}

		}

		public void SzakacsHibatJelez(string hozzavalo)
		{

			RendelesNemTeljesitheto.Invoke("Séf: A(z) " + cel.megnevezes + " sajnos nem készíthető el!");
		}

		public void Felvesz(Szakacs szakacs)
		{
			HozzavaloSzukseges += szakacs.SefKerValamit;
			szakacs.HozzavaloElkeszult += SzakacsElkeszult;
			if (szakacs is KorlatosSzakacs)
			{
				(szakacs as KorlatosSzakacs).HozzavaloNemKeszithetoEl += SzakacsHibatJelez;
			}
		}
	}
}
