using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sol_Demo.Models
{
    public class UserModel : ObservableObject
    {
        private String firstName;

        public String FirstName
        {
            get => firstName;
            set => base.SetProperty(ref firstName, value);
        }

        private String lastName;

        public String LastName
        {
            get => lastName;
            set => base.SetProperty(ref lastName, value);
        }
    }
}