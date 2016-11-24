using System;
using System.Collections.Generic;
using System.Linq;
namespace MaxMin
{
	public class Max : Command.Computer
	{
		private string _name = "Max";
		public Max()
		{
		}
		public string Name
		{
			get { return _name;}
		}
		public double Execute(string[] values)
		{
			List<double> valueslist = new List<double>();

			foreach (string number in values)
			{
				valueslist.Add(Convert.ToDouble(number));
			}
			double max = valueslist.Max();
			//double argument = Convert.ToDouble(values);
			//double result = Math.Cos(argument);
			return max;
		}
	}
}
