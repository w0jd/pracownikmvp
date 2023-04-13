using System;
namespace pracownik.Model
{


	public class MainModel
	{
		private string imie;
		private string nazwisko;
		DateTime dt;
		private int zarobki;
		private string RadioBox;
		private string Stanowisko;
		private string tekst;
		public MainModel() {
			
		}
		public void Dopis(string imie, string nazwisko, DateTime dt, int zarobki,  string Stanowisko, string RadioBox)
		{
			this.imie = imie;
			this.nazwisko = nazwisko;
			this.dt = dt;
			this.zarobki = zarobki;
			this.RadioBox = RadioBox;
			this.Stanowisko = Stanowisko;
		}
		public string Test()
		{
			if (imie == "")
			{
				return "imie";
			}
			else if (nazwisko == "")
			{
				return "nazwisko";
			}else if(Stanowisko== "")
			{
				return "stanowisko";
			}

			return "nic";
		}
		
		public string Fromat()
		{
			string dat =dt.ToString();
			string output = dat.Remove(10);
			
			string val="";
			val = imie + ", " + nazwisko+ ", " +output + ", " + zarobki.ToString() + " PLN, " + RadioBox +", "+ Stanowisko;
			return val;
		}
	}
}