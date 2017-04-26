using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MemeHub.Models.Enums;
using MemeHub.Models.Models;
using MemeHub.Models.ViewModels.Memes;
using MemeHub.Services.Contracts;

namespace MemeHub.Services
{
    public class HomeService : Service, IHomeService
    {
        public IEnumerable<MemeDisplayViewModel> GetAll()
        {
            IEnumerable<Meme> memes = this.Context.Memes.OrderByDescending(m => m.MemePoints);
            IEnumerable<MemeDisplayViewModel> mdvm =
                Mapper.Map<IEnumerable<Meme>, IEnumerable<MemeDisplayViewModel>>(memes);

            return mdvm;
        }

        public IEnumerable<MemeDisplayViewModel> GetNew()
        {
            IEnumerable<Meme> memes = this.Context.Memes.OrderByDescending(m => m.PostDate);
            IEnumerable<MemeDisplayViewModel> mdvm =
                Mapper.Map<IEnumerable<Meme>, IEnumerable<MemeDisplayViewModel>>(memes);

            return mdvm;
        }

        public IEnumerable<MemeDisplayViewModel> GetDank()
        {
            IEnumerable<Meme> memes = this.Context.Memes.Where(m => m.Category == Category.Dank).OrderByDescending(m => m.MemePoints);
            IEnumerable<MemeDisplayViewModel> mdvm =
                Mapper.Map<IEnumerable<Meme>, IEnumerable<MemeDisplayViewModel>>(memes);

            return mdvm;
        }

        public IEnumerable<MemeDisplayViewModel> GetFun()
        {
            IEnumerable<Meme> memes = this.Context.Memes.Where(m => m.Category == Category.Hilarious).OrderByDescending(m => m.MemePoints);
            IEnumerable<MemeDisplayViewModel> mdvm =
                Mapper.Map<IEnumerable<Meme>, IEnumerable<MemeDisplayViewModel>>(memes);

            return mdvm;
        }

        public IEnumerable<MemeDisplayViewModel> GetAwesome()
        {
            IEnumerable<Meme> memes = this.Context.Memes.Where(m => m.Category == Category.Awesome).OrderByDescending(m => m.MemePoints);
            IEnumerable<MemeDisplayViewModel> mdvm =
                Mapper.Map<IEnumerable<Meme>, IEnumerable<MemeDisplayViewModel>>(memes);

            return mdvm;
        }
    }
}
