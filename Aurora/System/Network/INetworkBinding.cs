using System;

namespace Aurora
{
	/// <summary>
	/// Network bindings abstract I/O implementations dealing with
	/// different network protocols, such as SSH, Telnet, or Web.
	/// </summary>
	public interface INetworkBinding
	{
		/// <summary>
		/// Start listening for new connections.
		/// </summary>
		void Start();

		/// <summary>
		/// Stop listening for new connections.
		/// </summary>
		void Stop();
	}
}

