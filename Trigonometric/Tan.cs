using System;
namespace Trigonometric
{
	public class Tan : Command.Command
	{
		public Tan()
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
				return "Veuillez donner un argument au tan (laissez un espace entre le tan et l'argument)";
			}
			double argument = Convert.ToDouble(values[0]);
			double result = Math.Tan(argument);
			return result.ToString();
		}
	}
}
