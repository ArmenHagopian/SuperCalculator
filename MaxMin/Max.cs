using System;
using System.Collections.Generic;
using System.Linq;
namespace MaxMin
{
	public class Max : Command.Command
	{
		public Max()
		{
		}
		public override string execute(string[] values)
		{
			List<double> valueslist = new List<double>();

			foreach (string number in values)
			{
				valueslist.Add(Convert.ToDouble(number));
			}
			double max = valueslist.Max();
			//double argument = Convert.ToDouble(values);
			//double result = Math.Cos(argument);
			return max.ToString();
		}
	}
}
