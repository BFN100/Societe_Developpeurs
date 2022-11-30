using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Societe_Developpeurs
{
    public class CplusPlus : iDeveloppeurs
    {
		private iDeveloppeurs dev;
		private eLangagesProg competence;

		public CplusPlus(iDeveloppeurs dev)
		{
			this.dev = dev;
			this.competence = eLangagesProg.CplusPlus;
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
