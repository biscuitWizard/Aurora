using System;

using Aurora.Models;

namespace Aurora.Typeclasses
{
    public class DefaultScript : ScriptDataObject
    {
        /// <summary>
        /// If the script is actively running.
        /// </summary>
        public bool IsActive { get; protected set; }

        /// <summary>
        /// If the script should be wiped on a server reload/reset or not.
        /// </summary>
        public bool Persistent { get; protected set; }

        public int Repeats { get; protected set; }

        public bool StartDelay { get; protected set; }

        public int Interval { get; protected set; }

        public virtual void Start()
        {
            
        }

        public virtual void Stop()
        {
            
        }

        public virtual void Pause()
        {
            
        }

        public virtual void UnPause()
        {
            
        }

        /// <summary>
        /// if a timed script (interval>0), returns time until next tick
        /// </summary>
        /// <returns></returns>
        public int GetTimeUntilNextRepeat()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// is called to check if the script is valid to be running
        /// at the current time. If IsValid() returns False, the running
        /// script is stopped and removed from the game. You can use this
        /// to check state changes (i.e. an script tracking some combat
        /// stats at regular intervals is only valid to run while there is
        /// actual combat going on)
        /// </summary>
        /// <returns></returns>
        public virtual bool IsValid()
        {
            throw new NotImplementedException();
        }

        protected virtual void OnScriptCreation()
        {
            
        }

        protected virtual void OnStart()
        {
            
        }

        protected virtual void OnRepeat()
        {
            
        }

        protected virtual void OnServerReload()
        {
            
        }

        protected virtual void OnServerShutdown()
        {
            
        }
    }
}
