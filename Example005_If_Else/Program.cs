Console.Write("Enter your name: ");
string userName = Console.ReadLine()+"-Сан";

if (userName.ToLower() == "маша"+"-сан") 
{
    Console.WriteLine("Ура! Это же Маша!");
}
else
{
    Console.WriteLine("Привет " + userName);
};