Console.WriteLine("Введите имя пользователя ");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
{
    Console.Write("Ура!!! Привет, Маша!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}