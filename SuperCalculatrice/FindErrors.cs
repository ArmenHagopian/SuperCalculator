using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
namespace SuperCalculatrice
{
	public class FindErrors
	{
		private bool _valid_input;
		private string[] _splitinput;
		private string[] _filePaths;
		public FindErrors(bool valid_input, string[] splitinput, string[] filePaths)
		{
			this._valid_input = valid_input;
			this._splitinput = splitinput;
			this._filePaths = filePaths;
		}
		public bool Valid()
		{
			return this._valid_input;
				       
		}

		public override string ToString()
		{
			bool valid_input = false;

			List<string> values = this._splitinput.ToList();
			// Remove the user's command to only keep arguments 
			values.RemoveAt(0);

			int counterrors = 0;
			double number;
			// Check if the parameters are numbers
			foreach (string val in values)
			{
				if (Double.TryParse(val, out number) == false)
				{
					counterrors += 1;
				}
			}

			if (counterrors > 0)
			{
				return "Veuillez entrer un/des nombre(s) en parametre";
			}

			else
			{
				if (this._splitinput[0] != "" || this._splitinput[1] != "")
				{
					List<bool> valid_list = new List<bool>();
					int valid_count = 0;
					AssemblySearch result;
					foreach (string lib in this._filePaths)
					{
						// Load assemblies .dll
						Assembly assembly = Assembly.LoadFrom(lib);
						result = new AssemblySearch(assembly, valid_input, this._splitinput);
						valid_input = result.Compute();
						valid_list.Add(valid_input);
					}

					foreach (bool valid in valid_list)
					{
						if (valid == true)
						{
							valid_count += 1;
						}
					}
					if (valid_count == 0)
					{
						return "Veuillez entrer une fonction valide";
					}
					return "";
				}
				else if (this._splitinput.Length == 1)
				{
					return "Veuillez entrer un argument";
				}
				else
				{
					return "Veuillez entrer une commande et un argument";
				}
			}

		}
	}
}
