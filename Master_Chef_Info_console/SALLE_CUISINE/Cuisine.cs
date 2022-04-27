using System;

namespace Master_Chef_Info_console.SALLE_CUISINE
{
	public class Cuisine {
		private String plongeur;
		private String cuisinier;
		private String commise_cuisine;
		private String chef_cuisine;

		public Cuisine(ref object plongeur, ref object cuisinier, ref object commise_cuisine, ref object chef_cuisine) {
			throw new System.NotImplementedException("Not implemented");
		}
		public void Traite_repas() {
			throw new System.NotImplementedException("Not implemented");
		}

		private global::TOOLS.Espace_cuisine espace_cuisine;
		private global::TOOLS.Materiel_Commun materiel_Commun;

		private global::CONTROLLEUR.Controlleur controlleur;

	}

}
