using API.Contracts;
using API.Data;
using API.DTO;
using API.Entities;

namespace API.Repositories
{
    public class LikesRepository : ILikeRepository
    {
        private readonly DataContext _context;

        public LikesRepository(DataContext context)
        {
            _context = context;
        }
      /*  public async  Task<UserLike> GetUserLike(int sourceUserId, int targetUserId)
        {
            return await _context.Likes.FindAsync(sourceUserId, targetUserId);
        }

        public Task<IEnumerable<LikeDTO>> GetUserLikes(string predicate, int userId)
        {
            var users = _context.Users.OrderBy(u => u.UserName).AsQueryable();
            var likes = _context.Likes.AsQueryable();
           
        }

        public Task<AppUser> GetUserWithLike(int userId)
        {
            throw new NotImplementedException();
        }*/
    }
}
