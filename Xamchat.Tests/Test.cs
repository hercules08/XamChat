using NUnit.Framework;
using System;
using Xamchat.Core;
using Xamchat.Core.Interfaces;
using Xamchat.Core.Fakes;

namespace Xamchat.Tests
{
    [TestFixture()]
    public class Test
    {
        public static void SetUp()
        {
            ServiceContainer.Register<IWebService>(() => new FakeWebService(){ SleepDuration = 0});
            ServiceContainer.Register<ISettings>(() => new FakeSettings());
        }
    }
}
