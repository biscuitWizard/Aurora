using System;

using Aurora.Typeclasses;

namespace Aurora.Commands
{
	public class MuxParser : IMuxParser
	{
		public MuxParser ()
		{
		}

	    public object[] GetMatchingCommands(string rawInput, TypedObject caller)
	    {
	        throw new NotImplementedException();
	    }
	}
}

