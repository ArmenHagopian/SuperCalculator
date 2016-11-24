using System;
namespace Basics
{
	public class Sum : Command.Command
	{
		private string _name = "Sum";
		public Sum()
		{
		}
		public string Name
		{
			get { return _name; }
		}
		public string Execute(string[] values)
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
