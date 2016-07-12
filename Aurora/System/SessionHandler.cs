using System;

namespace Aurora.System
{
	public class SessionHandler
	{
		public SessionHandler ()
		{
		}

		/// <summary>
		/// Send a message to all connected sessions.
		/// </summary>
		/// <param name="message">Message.</param>
		public void BroadcastMessage(string message) {

		}

		/// <summary>
		/// Called from the server side to cleanly disconnect a session.
		/// </summary>
		/// <param name="session">Session.</param>
		/// <param name="reason">Reason.</param>
		public void DisconnectSession(Session session, string reason = "") {

		}

		/// <summary>
		/// Cleanly shuts down all sessions.
		/// </summary>
		/// <param name="reason">Reason.</param>
		public void DisconnectAllSessions(string reason = "You have been disconnected.") {

		}

		public Session[] GetSessions(bool includeLoggedOut = false) {
			throw new NotImplementedException();
		}

		/// <summary>
		/// Log in the previously unloggedin session and the player we by now should 
		/// know is connected to it. After this point we assume the session to be 
		/// logged in one way or another.
		/// </summary>
		public void Login(Session session, object player, force = false, testMode = false) {

		}

		/// <summary>
		/// Get the number of connected players (not sessions since a player may have more 
		/// than one session depending on settings). Only logged-in players are counted here.
		/// </summary>
		/// <returns>The player count.</returns>
		public int GetPlayerCount() {
			throw new NotImplementedException();
		}

		public Session GetPlayerSession(object player, params int[] sessionIDs) {
			throw new NotImplementedException();
		}

		public Session[] GetPlayerSessions(object player) {
			throw new NotImplementedException();
		}

		/// <summary>
		/// Check all currently connected sessions (logged in and not) and see if any are dead or idle.
		/// </summary>
		public void ValidateSessions() {

		}
	}
}

