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
				if (t.IsClass && typeof(Command.Computer).IsAssignableFrom(t) &&
					(t.Name.ToLower() == this._splitinput[0] || t.Name == this._splitinput[0]))
				{
				
					List<string> values = this._splitinput.ToList();
					//Remove the user's command to only keep arguments 
					values.RemoveAt(0);

					Console.WriteLine(">>> Calling: " + t.Name);

					// Création d'un instance de la classe de type "t"
					// et on peut l'affecter à une variable de type "Command"
					// puisqu'elle implémente cette interface
					Command.Computer c = (Command.Computer)Activator.CreateInstance(t);

					// Appel de la méthode "execute" avec les données
					// entrees par l'utilisateur
					Console.WriteLine("Result: " + c.Execute(values.ToArray()).ToString());
					this._valid_input = true;

				}

			}

			return this._valid_input;
		
		}
	}
}
