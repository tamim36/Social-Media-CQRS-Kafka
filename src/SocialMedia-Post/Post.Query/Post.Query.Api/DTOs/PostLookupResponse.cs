using Post.Common.DTOs;

namespace Post.Query.Api.DTOs
{
    public class PostLookupResponse : BaseResponse
    {
        public List<PostEntity> Posts { get; set; }
    }
}
