using System;
namespace Trigonometric
{
	public class Cos : Command.Command
	{
		public Cos()
		{
		}

		public override string execute(string[] values)
		{
			if (values.Length > 1)
			{
				return "Veuillez entrer un seul argument";
			}
			if (values.Length == 0)
			{
				return "Veuillez donner un argument au cos (laissez un espace entre le cos et l'argument)";
			}
			double argument = Convert.ToDouble(values[0]);
			double result = Math.Cos(argument);
			return result.ToString();
		}
	}
}
