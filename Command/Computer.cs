using System;
namespace Command
{
	public interface Computer
	{
		string Name
		{
			get;
		}

		double Execute(params string[] values);
	}
}
