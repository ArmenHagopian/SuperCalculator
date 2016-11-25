using System;
namespace Trigonometric
{
	public class Cos : Command.Computer
	{
		private string _name = "Cos";
		public Cos()
		{
		}
		public string Name
		{
			get { return _name;}
		}

		public double Execute(string[] values)
		{
			if (values.Length > 1)
			{
				throw new ArgumentException("Veuillez entrer un seul argument");
			}
			double argument = Convert.ToDouble(values[0]);
			double result = Math.Cos(argument);
			return result;
		}
	}
}
