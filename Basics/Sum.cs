using System;
namespace Basics
{
	public class Sum : Command.Computer
	{
		private string _name = "Sum";
		public Sum()
		{
		}
		public string Name
		{
			get { return _name; }
		}
		public double Execute(string[] values)
		{
			double result = 0;
			foreach (string val in values)
			{
				result += Convert.ToDouble(val);
			}
			return result;
		}
	}
}
