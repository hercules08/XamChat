using System;
using System.Threading.Tasks;
using Xamchat.Core.Models;

namespace Xamchat.Core.Interfaces
{
    public interface ISettings
    {
        User User { get; set; }
        void Save();
        Task SaveRemote();
    }
}
