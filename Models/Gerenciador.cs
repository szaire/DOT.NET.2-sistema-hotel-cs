using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Sistema.Models
{
    public static class Gerenciador
    {
		private static string folder = "Res";

		public static void WriteFile(List<Reserva> r, string name)
		{
			string path = $"{folder}/";

			if (!System.IO.Directory.Exists(path))
			{
				System.IO.Directory.CreateDirectory(path);
			}
			string jsonFile = JsonConvert.SerializeObject(r, Formatting.Indented);
			File.WriteAllText(path + $"{name}.json", jsonFile);
		}
	}
}