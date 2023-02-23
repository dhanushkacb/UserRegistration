namespace ApiUser.Models
{
    public class User
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? SecretCode { get; set; }
    }

    public class UserDTO
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}
