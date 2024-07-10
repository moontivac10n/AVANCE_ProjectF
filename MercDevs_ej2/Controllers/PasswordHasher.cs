using BCrypt.Net;

public class PasswordHasher
{
    public static void Main()
    {
        string password = "futbol"; // Aquí colocas la contraseña que quieres hashear
        string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

        Console.WriteLine("Contraseña original: " + password);
        Console.WriteLine("Contraseña hasheada: " + hashedPassword);
    }
}
