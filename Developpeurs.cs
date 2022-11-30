using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Societe_Developpeurs
{
    public class Developpeurs : iDeveloppeurs
    {

		private String nom;

		public Developpeurs(String nom)
		{
			this.nom = nom;
		}

		public String getNom()
		{
			return nom;
		}

		public String getCompetence()
		{
			return "";
		}
	}
}
