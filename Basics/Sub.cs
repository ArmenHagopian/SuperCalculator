using System;
namespace Basics
{
	public class Sub : Command.Command
	{
		private string _name = "Sub";
		public Sub()
		{
		}
		public string Name
		{
			get { return _name; }
		}
		public string Execute(string[] values)
		{
			//We take 2 times the first member cause we substract 
			//it once on the scope
			double result = 2*Convert.ToDouble(values[0]);
			foreach (string val in values)
			{
				result -= Convert.ToDouble(val);
			}
			return result.ToString();
		}
	}
}
