using System;
namespace Command
{
	public abstract class Command
	{
		public Command()
		{
		}

		public abstract string execute(string[] values);
	}
}
