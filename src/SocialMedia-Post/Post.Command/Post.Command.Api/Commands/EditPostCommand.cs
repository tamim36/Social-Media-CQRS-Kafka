using CQRS.Core.Commands;

namespace Post.Command.Api.Commands
{
    public class EditPostCommand : BaseCommand
    {
        public string Message { get; set; }
    }
}