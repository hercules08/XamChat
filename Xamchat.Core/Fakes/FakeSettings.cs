using System;
using System.Threading.Tasks;
using Xamchat.Core.Interfaces;
using Xamchat.Core.Models;

namespace Xamchat.Core.Fakes
{
    public class FakeSettings : ISettings
    {
        public User User { get; set; }

        public void Save()
        {
            
        }

        public Task SaveRemote()
        {
            throw new NotImplementedException();
        }
    }
}
