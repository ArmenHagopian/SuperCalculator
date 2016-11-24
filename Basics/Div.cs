using System;
namespace Basics
{
	public class Div : Command.Command
	{
		public Div()
		{
		}
		public override string execute(string[] values)
		{
			//We square the first member cause we divide 
			//it by itself once on the scope
			double result = Math.Pow(Convert.ToDouble(values[0]), 2);
			foreach (string val in values)
			{
				result /= Convert.ToDouble(val);
			}
			return result.ToString();
		}
	}
}
