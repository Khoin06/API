
using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);

        // lưu thay đổi
        Task<bool> SaveAllAsync();
        // trả vô số ng dùng và đồng bộ hóa 
        Task<IEnumerable<AppUser>> GetUsersAsync();
        // nhận ng dùng theo id
        Task<AppUser> GetUserByIdAsync(int id);

        Task<AppUser> GetUserByUsernameAsync(string username);
        Task<IEnumerable<MemberDto>>GetMembersAsync();
        Task<MemberDto>GetMemberAsync(string username);
        

    }
}