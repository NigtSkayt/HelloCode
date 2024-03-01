Console.Write("Write user name: ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
    Console.Write("Ura, this is Masha!");   
}
else 
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}