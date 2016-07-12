using System;

namespace Aurora
{
	/// <summary>
	/// An abstract implementation for a game server. The default is
	/// Server, which is Aurora's main GameServer.
	/// </summary>
	public interface IGameServer
	{
		/// <summary>
		/// Performs whatever setup is necessary for the game to setup on a cold
		/// boot. (After shutdown/reset).
		/// </summary>
		void ColdInitialize();
	}
}

