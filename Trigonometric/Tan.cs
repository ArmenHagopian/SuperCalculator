using System;
namespace Trigonometric
{
	public class Tan : Command.Computer
	{
		private string _name = "Tan";
		public Tan()
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
				Console.WriteLine("Veuillez entrer un seul argument");
			}
			//if (values.Length == 0)
			//{
			//	return "Veuillez donner un argument au tan (laissez un espace entre le tan et l'argument)";
			//}
			double argument = Convert.ToDouble(values[0]);
			double result = Math.Tan(argument);
			return result;
		}
		public string Error(string[] values)
		{
			if (values.Length > 1)
			{
				return "Veuillez entrer un seul argument";
			}
			return "";
		}
	}
}
