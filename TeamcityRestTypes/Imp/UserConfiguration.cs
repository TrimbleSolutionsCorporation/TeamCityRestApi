namespace TeamcityRestTypes.Imp
{
    public class TeamcityUserConfig : ITeamcityConfiguration
    {
        public TeamcityUserConfig(string url, string token)
        {
            Hostname = url;
            Token = token;
        }

        public TeamcityUserConfig(string url, string username, string pass)
        {
            Hostname = url;
            Username = username;
            Password = pass;
        }

        public string Hostname { get; set; }

        public string Password { get; set; }

        public string Username { get; set; }

        public string Token { get; set; }
    }
}
