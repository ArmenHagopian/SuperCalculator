using System;
namespace Basics
{
	public class Mult : Command.Command
	{
		public Mult()
		{
		}
		public override string execute(string[] values)
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
