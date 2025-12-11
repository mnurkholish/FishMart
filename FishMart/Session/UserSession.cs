namespace FishMart.Session
{
    public class UserSession
    {
        public static int Id { get; set; }
        public static string Email { get; set; }
        public static string Username { get; set; }
        public static bool IsAdmin { get; set; }

    public static void Clear()
        {
            Id = 0;
            Email = null;
            Username = null;
            IsAdmin = false;
        }
    }
}
