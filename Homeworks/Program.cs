using System.IO;

string path = @"C:\Users\Home\Desktop\atm\data.txt";
string name;
string surname;
int amount;
using (StreamReader sr = new StreamReader(path))
{
    name = sr.ReadLine()!;
    surname = sr.ReadLine()!;
    amount = Convert.ToInt32(sr.ReadLine());
}
Console.WriteLine("Choose an option:");
Console.WriteLine("1. User balance check");
Console.WriteLine("2. Deposit money");
Console.WriteLine("3. Withdraw money");
Console.WriteLine("4. Display of user's personal data and balance information");
Console.WriteLine("Enter your choice:");

int digit = Convert.ToInt32(Console.ReadLine());

switch (digit)
{
    case 1:
        Console.WriteLine($"User balance: {amount}");
        break;
    case 2:
        Console.WriteLine("Enter amount to add to your balance");
        int addAmount = Convert.ToInt32(Console.ReadLine());
        amount += addAmount;
        Console.WriteLine($"Your balance after deposit: {amount}");
        break;
    case 3:
        Console.WriteLine("Enter amount to withdraw from your balance");
        int withdraw = Convert.ToInt32(Console.ReadLine());
        amount -= withdraw;
        Console.WriteLine($"Your balance after withdrawal: {amount}");

        break;
    case 4:
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Surname: {surname}");
        Console.WriteLine($"Amount: {amount}");
        break;
    default:
        Console.WriteLine("Invalid choice!");
        break;
}

