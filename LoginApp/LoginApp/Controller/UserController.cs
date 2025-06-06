using LoginApp.Models;
using LoggingLib;

namespace LoginApp.Controller
{
    internal class UserController
    {
        public bool Authenticate(User usr)
        {
            Logger.LogInfo($"Login Request for: {usr.Username}");
            return usr.Username == "elliot" && usr.Password == "P@ssw0rd";
        }
    }
}
