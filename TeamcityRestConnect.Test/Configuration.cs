namespace TeamcityRestConnect.Test
{
    using TeamcityRestTypes;

    public class Configuration : ITeamcityConfiguration
    {
        public string Hostname { get; set; } = "";

        public string Password { get; set; } = "";

        public string Username { get; set; } = "";

        public string Token { get; set; } = "";
    }
}
