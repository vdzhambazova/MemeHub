using System;
using System.Linq;
using System.Web;
using AutoMapper;
using MemeHub.Data;
using MemeHub.Models.BindingModels.Comments;
using MemeHub.Models.BindingModels.Memes;
using MemeHub.Models.Models;
using MemeHub.Models.ViewModels.Memes;
using MemeHub.Services.Contracts;
using Microsoft.AspNet.Identity;

namespace MemeHub.Services
{
    public class MemesService : Service, IMemesService
    {

        public void CreateMeme(MemeCreateBindingModel mcbm, string userName)
        {
            Meme meme = Mapper.Map<MemeCreateBindingModel, Meme>(mcbm);
            Poster poster = this.Context.Posters.FirstOrDefault(p => p.User.UserName == userName);
            meme.PostDate = DateTime.Now;
            poster.Memes.Add(meme);
            this.Context.SaveChanges();
        }

        public MemeDetailsViewModel GetMemeDetails(int? id)
        {
            Meme meme = this.Context.Memes.Find(id);
            MemeDetailsViewModel mdvm = Mapper.Map<Meme, MemeDetailsViewModel>(meme);

            return mdvm;
        }

        public MemeEditViewModel GetEditMeme(int id)
        {
            Meme meme = this.Context.Memes.Find(id);
            MemeEditViewModel mevm = Mapper.Map<Meme, MemeEditViewModel>(meme);

            return mevm;
        }

        public void EditMeme(int id, MemeEditBindingModel bind)
        {
            Meme meme = this.Context.Memes.Find(id);
            meme.Caption = bind.Caption;

            this.Context.SaveChanges();
        }

        public MemeDeleteViewModel GetDeleteMeme(int? id)
        {
            Meme meme = this.Context.Memes.Find(id);
            MemeDeleteViewModel mdvm = Mapper.Map<Meme, MemeDeleteViewModel>(meme);

            return mdvm;
        }

        public void DeleteMeme(int id)
        {
            Meme meme = this.Context.Memes.Find(id);
            meme.IsDeleted = true;

            this.Context.SaveChanges();
        }

        public void CreateComment(CommentCreateBindingModel mdvm, int memeId)
        {
            var userId = HttpContext.Current.User.Identity.GetUserId();
            ApplicationUser user = this.Context.Users.Find(userId);
            Meme meme = this.Context.Memes.Find(memeId);
            Comment comment = Mapper.Map<CommentCreateBindingModel, Comment>(mdvm);
            comment.PostDate = DateTime.Now;
            comment.Writer = user;
            meme.Comments.Add(comment);

            this.Context.SaveChanges();
        }

        public void LoveMeme(int memeId)
        {
            Meme meme = this.Context.Memes.Find(memeId);
            meme.MemePoints++;

            this.Context.SaveChanges();
        }

        public override MemeHubContext Context { get; set; }
    }
}
