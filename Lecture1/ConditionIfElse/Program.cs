Console.WriteLine("Введите имя пользователя");
string? userName = Console.ReadLine();

if (userName == null) userName = "";

if (userName.ToLower() == "маша") Console.WriteLine("Ура! Это же Маша!");
else Console.WriteLine($"Привет {userName}");