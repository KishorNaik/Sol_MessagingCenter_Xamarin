using MvvmHelpers;
using Sol_Demo.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Sol_Demo.ViewModels
{
    public class UserReceiveViewModel : BaseViewModel
    {
        public UserReceiveViewModel()
        {
            // Constructor will call when Navigation call from User Send View Model class
            // it will subscribe first
            // once the Message Center Send function call from User Send view Model Class then call back function will call to get message data.
            MessagingCenter.Subscribe<UserSendViewModel, UserModel>(this, "User-Model-Object", (userSendViewModel, userModel) =>
             {
                 FullName = $"{userModel.FirstName} {userModel.LastName}";
             });
        }

        private String fullName;

        public String FullName
        {
            get => fullName;
            set => base.SetProperty(ref fullName, value);
        }
    }
}