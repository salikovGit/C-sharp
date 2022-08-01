Console.Write("Enter Username: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.WriteLine("Greetings, Masha!");
}
else{
    Console.Write("Hi, ");
    Console.WriteLine(username);
}
