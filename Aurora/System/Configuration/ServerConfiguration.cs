namespace Aurora.System.Configuration
{
    public class ServerConfiguration : IConfigurationModel
    {
        public string FileName { get {  return "server.config"; } }

        public TelnetConfiguration Telnet { get; set; }
        public PortalConfiguration Portal { get; set; }

        public ServerConfiguration()
        {
            Telnet = new TelnetConfiguration();
            Portal = new PortalConfiguration();
        }
    }
}
