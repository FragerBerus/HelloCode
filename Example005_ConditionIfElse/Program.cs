Console.WriteLine("Введите имя пользователя ");
// Ввод имени пользователя в консоли.
string username = Console.ReadLine();
// Проверка имени пользователя
// без учета регистра букв имени.
if(username.ToLower() == "маша")
{
    // Вывод в консоль приветствия пользователя с именем Маша.
    Console.Write("Ура!!! Привет, Маша!!!");
}
else
{
    // Вывод в консоль приветствия пользователя с другим именем.
    Console.Write("Привет, ");
    Console.WriteLine(username);
}