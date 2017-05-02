using MemeHub.Models.BindingModels.Comments;

namespace MemeHub.Models.BindingModels.Memes
{
    public class MemeDetailsBindingModel
    {
        public int Id { get; set; }
     
        public virtual CommentCreateBindingModel CreateComment { get; set; }
    }
}
