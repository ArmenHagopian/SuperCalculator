using System;
namespace Command
{
	public interface Command
	{
		string Name
		{
			get;
		}

		string Execute(string[] values);
	}
}
