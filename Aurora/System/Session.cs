using System;
using System.Net;

namespace Aurora.System
{
	public class Session
	{
		public int SessionID { get; protected set; }
		public int ClientSessionID { get; protected set; }
		public int UserID { get; protected set; }
		public string Username { get; protected set; }
		public bool LoggedIn { get; protected set; }
		public int PuppetID { get; protected set; }

		public enum ProtocolKey {
			Telnet,
			Ssh,
			Web,
			Ssl
		}

		public Session ()
		{
			
		}

		public static Session Initialize(ProtocolKey protocol, IPEndPoint address, SessionHandler sessionHandler) {
			return new Session ();
		}
	}
}

