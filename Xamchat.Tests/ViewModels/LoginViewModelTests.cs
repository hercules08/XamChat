﻿using NUnit.Framework;
using System;
using Xamchat.Core.ViewModels;
using Xamchat.Core.Interfaces;
using Xamchat.Core;
using System.Threading.Tasks;

namespace Xamchat.Tests.ViewModels
{
    [TestFixture()]
    public class LoginViewModelTests
    {
        LoginViewModel loginViewModel;
        ISettings settings;

        [SetUp]
        public void SetUp()
        {
            Test.SetUp();

            settings = ServiceContainer.Resolve<ISettings>();
            loginViewModel = new LoginViewModel();
        }

        [Test()]
        public async Task LoginSuccessfully()
        {
            loginViewModel.Username = "testuser";
            loginViewModel.Password = "password";
            await loginViewModel.Login();
            Assert.That(settings.User, Is.Not.Null);
        }

        [Test, ExpectedException(typeof(Exception), ExpectedMessage = "Username is blank.")]
        public async Task LoginWithNoUsernameOrPassword()
        {
            //Throws an exception
            await loginViewModel.Login();
        }
    }
}
