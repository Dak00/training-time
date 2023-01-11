Console.Write("What type of training are you going to do? ");
string trType = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("So now you have to type how many days are you going to do " + trType);
int days;
Console.Write("Days: ");
days = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Now how many times are u going to do a  " + trType + " every day");
int trTypeChosen;
Console.Write($"{trType}: ");
trTypeChosen = Convert.ToInt32(Console.ReadLine());

int totalAmount = trTypeChosen  / days;
Console.WriteLine($"Total you have to do: {totalAmount} {trType} all day");