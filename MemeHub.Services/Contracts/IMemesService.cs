using MemeHub.Models.BindingModels.Comments;
using MemeHub.Models.BindingModels.Memes;
using MemeHub.Models.ViewModels.Comments;
using MemeHub.Models.ViewModels.Memes;

namespace MemeHub.Services.Contracts
{
    public interface IMemesService
    {
        void CreateMeme(MemeCreateBindingModel mcbm, string userName);
        void DeleteMeme(int id);
        void EditMeme(int id, MemeEditBindingModel bind);
        MemeDeleteViewModel GetDeleteMeme(int? id);
        MemeEditViewModel GetEditMeme(int id);
        MemeDetailsViewModel GetMemeDetails(int? id);
        void CreateComment(CommentCreateBindingModel ccvm, int memeId);
    }
}