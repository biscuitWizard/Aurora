namespace Aurora.System.Configuration
{
    public class TelnetConfiguration
    {
        public int Port { get; set; }
        public string HostAddress { get; set; }
        public bool Enabled { get; set; }

        public TelnetConfiguration()
        {
            Port = 4000;
            HostAddress = "localhost";
            Enabled = true;
        }
    }
}
