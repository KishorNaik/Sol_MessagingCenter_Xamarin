using MvvmHelpers;
using Sol_Demo.Models;
using Sol_Demo.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sol_Demo.ViewModels
{
    public class UserSendViewModel : BaseViewModel
    {
        private INavigation navigation = null;

        public UserSendViewModel()
        {
            UserM = new UserModel();

            Send = new Command(async () => await this.OnSend());
        }

        private UserModel userM;

        public UserModel UserM
        {
            get => userM;
            set => base.SetProperty(ref userM, value);
        }

        public ICommand Send { get; set; }

        private async Task OnSend()
        {
            // Step 1: Navigate first to Another View Model to subscribe Messaging center
            navigation = Application.Current.MainPage.Navigation;
            await navigation.PushAsync(new ReceiveUser());

            // Step 2: Send Message, it will automatically pick up message in another view Model
            MessagingCenter.Send<UserSendViewModel, UserModel>(this, "User-Model-Object", UserM);

            //return Task.CompletedTask;
        }
    }
}