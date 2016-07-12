namespace Aurora.System.Configuration
{
    public class PortalConfiguration
    {
        public int Port { get; set; }
        public string HostAddress { get; set; }
        public bool Enabled { get; set; }

        public PortalConfiguration()
        {
            Port = 8000;
            HostAddress = "localhost";
            Enabled = true;
        }
    }
}
