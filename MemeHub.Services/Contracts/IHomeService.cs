using System.Collections.Generic;
using MemeHub.Models.ViewModels.Memes;

namespace MemeHub.Services
{
    public interface IHomeService
    {
        IEnumerable<MemeDisplayViewModel> GetAll();
        IEnumerable<MemeDisplayViewModel> GetAwesome();
        IEnumerable<MemeDisplayViewModel> GetDank();
        IEnumerable<MemeDisplayViewModel> GetFun();
        IEnumerable<MemeDisplayViewModel> GetNew();
    }
}