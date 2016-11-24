using System;
namespace Basics
{
	public class Sum : Command.Command
	{
		public Sum()
		{
		}
		public override string execute(string[] values)
		{
			double result = 0;
			foreach (string val in values)
			{
				result += Convert.ToDouble(val);
			}
			return result.ToString();
		}
	}
}
