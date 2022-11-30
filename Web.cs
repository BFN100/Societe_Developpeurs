using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Societe_Developpeurs
{
    public class Web : iDeveloppeurs
    {
		private iDeveloppeurs dev;
		private eLangagesProg competence;

		public Web(iDeveloppeurs dev)
		{
			this.dev = dev;
			this.competence = eLangagesProg.Web;
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
