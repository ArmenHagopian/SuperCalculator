using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace SuperCalculatrice
{
	public class AssemblySearch
	{
		private bool _valid_input;
		private Assembly _assembly;
		private string[] _splitinput;
		public AssemblySearch(Assembly assembly, bool valid_input, string[] splitinput)
		{
			this._valid_input = valid_input;
			this._assembly = assembly;
			this._splitinput = splitinput;
		}

		public bool Compute()
		{
			foreach (Type t in this._assembly.GetTypes())
			{
				// Filtre pour ne garder que les classes
				// qui implémentent l'interface "Command"
				//Console.WriteLine(t.ToString());
				//Console.WriteLine(t.IsClass);
				//Console.WriteLine(typeof(Command.Command).IsAssignableFrom(t));
				//Console.WriteLine(t.Name.ToLower() == this._splitinput[0] || t.Name == this._splitinput[0]);
				//Console.WriteLine(t.Name);
				if (t.IsClass && typeof(Command.Command).IsAssignableFrom(t) && 
				    (t.Name.ToLower() == this._splitinput[0] || t.Name == this._splitinput[0]))
				{
					//Console.WriteLine("testtest");
					List<string> values = this._splitinput.ToList();
					//remove the user's command to only keep arguments 
					values.RemoveAt(0);

					int counterrors = 0;
					double number;
					//Check if the parameters are numbers
					foreach (string val in values)
					{
						if (Double.TryParse(val, out number) == false)
						{
							counterrors += 1;
						}
					}

					if (counterrors == 0)
					{
						Console.WriteLine(">>> Calling: " + t.Name);

						// Création d'un instance de la classe de type "t"
						// et on peut l'affecter à une variable de type "Command"
						// puisqu'elle implémente cette interface
						Command.Command c = (Command.Command)Activator.CreateInstance(t);

						foreach (string test in values.ToArray())
						{
							Console.WriteLine(test);
						}
						// Appel de la méthode "execute" avec les données
						// entrees par l'utilisateur
						Console.WriteLine("Result: " + c.execute(values.ToArray()));
					}

					else
					{
						Console.WriteLine("Veuillez entrer des nombres en parametre");
					}

					this._valid_input = true;
				}
			}
			return this._valid_input;
		
		}
	}
}
