namespace TeamcityRestTypes
{
    public class TeamcityUserConfig : ITeamcityConfiguration
    {
        public TeamcityUserConfig(string url, string username, string pass)
        {
            this.Hostname = url;
            this.Username = username;
            this.Password = pass;
        }

        public string Hostname { get; set; }

        public string Password { get; set; }

        public string Username { get; set; }
    }
}
