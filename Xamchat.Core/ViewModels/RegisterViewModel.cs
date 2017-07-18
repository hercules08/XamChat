using System;
using System.Threading.Tasks;

namespace Xamchat.Core.ViewModels
{
    public class RegisterViewModel : BaseViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public async Task Register()
        {
            if (string.IsNullOrEmpty(Username))
                throw new Exception("Username is blank.");

            if (string.IsNullOrEmpty(Password))
                throw new Exception("Password is blank.");

            if (ConfirmPassword != Password)
                throw new Exception("Your passwords do not match! Please double check.");

            IsBusy = true;

            try
            {
                settings.User = await service.Register(new Models.User() { Username = Username, Password = Password });
                settings.Save();
            }
            finally
            {
                IsBusy = false;
            }
        }
    }


}
