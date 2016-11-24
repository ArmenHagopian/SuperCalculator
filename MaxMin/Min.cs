using System;
using System.Collections.Generic;
using System.Linq;
namespace MaxMin
{
	public class Min : Command.Command
	{
		private string _name = "Min";
		public Min()
		{
		}
		public string Name
		{
			get { return _name; }
		}
		public string Execute(string[] values)
		{
			List<double> valueslist = new List<double>();

			foreach (string number in values)
			{
				valueslist.Add(Convert.ToDouble(number));
			}
			double min = valueslist.Min();
			//double argument = Convert.ToDouble(values);
			//double result = Math.Cos(argument);
			return min.ToString();
		}
	}
}
