using System;

using Aurora.Typeclasses;

namespace Aurora.Commands
{
	public interface IMuxParser
	{
		object[] GetMatchingCommands (string rawInput, TypedObject caller);
	}
}

