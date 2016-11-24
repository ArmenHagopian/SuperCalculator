using System;
namespace Basics
{
	public class Div : Command.Computer
	{
		private string _name = "Div";
		public Div()
		{
		}
		public string Name
		{
			get { return _name; }
		}
		public double Execute(string[] values)
		{
			//We square the first member cause we divide 
			//it by itself once on the scope
			double result = Math.Pow(Convert.ToDouble(values[0]), 2);
			foreach (string val in values)
			{
				result /= Convert.ToDouble(val);
			}
			return result;
		}
	}
}
