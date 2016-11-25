using System;
namespace Trigonometric
{
	public class Sin : Command.Computer
	{
		private string _name = "Sin";
		public Sin()
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
			double result = Math.Sin(argument);
			return result;
		}

	}
}