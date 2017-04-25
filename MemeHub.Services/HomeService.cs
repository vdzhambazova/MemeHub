using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MemeHub.Models.Enums;
using MemeHub.Models.Models;
using MemeHub.Models.ViewModels.Memes;

namespace MemeHub.Services
{
    public class HomeService : Service
    {
        public IEnumerable<MemeпProfileViewModel> GetAll()
        {
            IEnumerable<Meme> memes = this.Context.Memes;
            IEnumerable<MemeпProfileViewModel> mdvm =
                Mapper.Map<IEnumerable<Meme>, IEnumerable<MemeпProfileViewModel>>(memes);

            return mdvm;
        }

        public IEnumerable<MemeпProfileViewModel> GetNew()
        {
            IEnumerable<Meme> memes = this.Context.Memes.OrderByDescending(m => m.PostDate);
            IEnumerable<MemeпProfileViewModel> mdvm =
                Mapper.Map<IEnumerable<Meme>, IEnumerable<MemeпProfileViewModel>>(memes);

            return mdvm;
        }

        public IEnumerable<MemeпProfileViewModel> GetDank()
        {
            IEnumerable<Meme> memes = this.Context.Memes.Where(m => m.Category == Category.Dank);
            IEnumerable<MemeпProfileViewModel> mdvm =
                Mapper.Map<IEnumerable<Meme>, IEnumerable<MemeпProfileViewModel>>(memes);

            return mdvm;
        }

        public IEnumerable<MemeпProfileViewModel> GetFun()
        {
            IEnumerable<Meme> memes = this.Context.Memes.Where(m => m.Category == Category.Fun);
            IEnumerable<MemeпProfileViewModel> mdvm =
                Mapper.Map<IEnumerable<Meme>, IEnumerable<MemeпProfileViewModel>>(memes);

            return mdvm;
        }

        public IEnumerable<MemeпProfileViewModel> GetAwesome()
        {
            IEnumerable<Meme> memes = this.Context.Memes.Where(m => m.Category == Category.Awesome);
            IEnumerable<MemeпProfileViewModel> mdvm =
                Mapper.Map<IEnumerable<Meme>, IEnumerable<MemeпProfileViewModel>>(memes);

            return mdvm;
        }
    }
}
