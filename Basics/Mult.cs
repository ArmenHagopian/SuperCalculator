using System;
namespace Basics
{
	public class Mult : Command.Command
	{
		private string _name = "Mult";
		public Mult()
		{
		}
		public string Name
		{
			get { return _name; }
		}
		public string Execute(string[] values)
		{
			double result = 1;
			foreach (string val in values)
			{
				result *= Convert.ToDouble(val);
			}
			return result.ToString();
		}
	}
}
