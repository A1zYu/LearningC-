var isContinuePlayer = true;
var isContinueComputer = true;
var random = new Random();
var currentComputer = 0;
do
{
    isContinuePlayer = AskPlayer(isContinuePlayer);

    isContinueComputer = AskComputer(isContinueComputer, random);
}
while (isContinuePlayer || isContinueComputer);

static bool AskPlayer(bool isContinuePlayer)
{
    Console.WriteLine("Будешь тянуть карту? (y)-тянешь карту (n)-пассуешь");
    var answer = Console.ReadLine();
    if (answer == "y")
    {
        Console.WriteLine("Вы тянете карту");
    }
    if (answer == "n")
    {
        Console.WriteLine("Вы пасуете");
        isContinuePlayer = false;
    }

    return isContinuePlayer;
}

static bool AskComputer(bool isContinueComputer, Random random)
{
    var currentComputer = 0;
    if (isContinueComputer)
    {
        currentComputer= random.Next(0, 2);
    }

    if (!isContinueComputer)
    {
        return isContinueComputer;
    }
    if (currentComputer ==0)
    {
        Console.WriteLine("Компьютер тянет карту");
    }
    if (currentComputer==1)
    {
        Console.WriteLine("Компьютер пасуете");
        isContinueComputer = false;
    }

    return isContinueComputer;
}