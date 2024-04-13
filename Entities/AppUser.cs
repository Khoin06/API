namespace API.Entities
{
    public class AppUser
    {
        public int Id{get;set;}
        public string UserName{set;get;}

        public byte[] PasswordHash {set;get;}

        public byte[] PasswordSalt {set;get;}

    }
}