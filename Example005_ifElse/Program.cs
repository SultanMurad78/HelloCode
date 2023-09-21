Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "sultan")
{
    Console.WriteLine("Приветствую Вас господин Sultan!");
}
else
{
    Console.Write("Привет!, ");
    Console.WriteLine(username);
}