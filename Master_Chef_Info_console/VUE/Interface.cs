using System;

namespace Master_Chef_Info_console.VUE {
	public class Interface {
		public int Input( int nb_client, bool reserv) {
			return nb_client;
		}
		public void Output(string mess) {
			//mess = out_mess;
			Console.Writeline(mess)
		}

		private global::CONTROLLEUR.Controlleur controlleur;

	}

}
