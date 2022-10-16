/*● Начало
● Ввести имя пользователя
● ЕСЛИ имя пользователя совпадает с “Маша” то… поприветствовать по особенному
● ИНАЧЕ поприветствовать по обычному
● Конец*/

System.Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    System.Console.WriteLine("Ура, это же Masha!");
}
else
{
    System.Console.WriteLine("Привет, " + username + "!");
}
