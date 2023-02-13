using Userinterface.Utilities;

namespace Userinterface.Models
{
    public class RandomUser
    {
        public string Password { get; set; }
        public string EmailUsername { get; set; }
        public string EmailDomain { get; set; }
        public string EmailTopLevelDomain { get; set; }

        public RandomUser()
        {
            Password = Randomizer.GetString(8, 2, 2, 2);
            EmailUsername = this.Password[0] + Randomizer.GetString();
            EmailDomain = Randomizer.GetString();
            EmailTopLevelDomain = Randomizer.GetTopLevelDomain();
        }
    }
}