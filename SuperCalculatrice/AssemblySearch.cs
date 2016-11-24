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

		public string Compute()
		{
			foreach (Type t in this._assembly.GetTypes())
			{
				// Trigonometric functions only take 1 argument
				Console.WriteLine(t.ToString().Split(new Char[] { '.' })[0]);
				if (t.ToString().Split(new Char[] { '.' })[0] == "Trigonometric" && this._splitinput.Length > 2)
				{
					return "Veuillez entrer un seul argument";
				}
				else
				{
					Console.WriteLine(t.IsClass);
					Console.WriteLine(typeof(Command.Computer).IsAssignableFrom(t));
					Console.WriteLine((t.Name.ToLower() == this._splitinput[0] || t.Name == this._splitinput[0]));
					if (t.IsClass && typeof(Command.Computer).IsAssignableFrom(t) &&
						(t.Name.ToLower() == this._splitinput[0] || t.Name == this._splitinput[0]))
					{
						Console.WriteLine("test3");
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
							Command.Computer c = (Command.Computer)Activator.CreateInstance(t);

							foreach (string test in values.ToArray())
							{
								Console.WriteLine(test);
							}
							// Appel de la méthode "execute" avec les données
							// entrees par l'utilisateur
							return ("Result: " + c.Execute(values.ToArray()).ToString());
						}

						else
						{
							return "Veuillez entrer des nombres en parametre";
						}

						//this._valid_input = true;
					}
					else
					{
						return "Veuillez entrer une fonction valide";
					}
				}
			}
			return "test";
		
		}
	}
}
