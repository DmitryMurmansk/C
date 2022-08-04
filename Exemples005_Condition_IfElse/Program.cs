Console.WriteLine("Введите имя пользовтеля: ");
string username = Console.ReadLine();

if(username.ToLower() == "лиля") // вот ТУТ после скобок не надо ставить знак ";"!!!!
{
    Console.WriteLine("Лиля, сделаешь красиво?");
}
else
{
    Console.Write("Приветствую тебя испытатель!");
    Console.WriteLine(username);
}
