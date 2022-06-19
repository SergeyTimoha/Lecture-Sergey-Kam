Cosole.Clear();
Console.Write("Введите имя пользователя: ");
string uzername = Console.ReadLine();

if(uzername.ToLower() == "маша")
{
    Console.WriteLine("Ура это же Маша");
}
    
else
{
    Console.Write("Привет,");
    Console.WriteLine(uzername);
}
