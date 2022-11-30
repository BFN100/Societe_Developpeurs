using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Societe_Developpeurs
{
    public class Csharp : iDeveloppeurs
    {
		private iDeveloppeurs dev;
		private eLangagesProg competence;

		public Csharp(iDeveloppeurs dev)
		{
			this.dev = dev;
			this.competence = eLangagesProg.Csharp;
		}


		public String getCompetence()
		{
			return this.competence + ", " + dev.getCompetence();
		}


		public String getNom()
		{
			return dev.getNom();
		}
	}
}
