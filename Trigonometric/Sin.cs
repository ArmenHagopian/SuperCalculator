using System;
namespace Trigonometric
{
	public class Sin : Command.Command
	{
		public Sin()
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
				return "Veuillez donner un argument au sin (laissez un espace entre le sin et l'argument)";
			}
			double argument = Convert.ToDouble(values[0]);
			double result = Math.Sin(argument);
			return result.ToString();
		}
	}
}