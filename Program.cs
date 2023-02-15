// start main

System.Console.WriteLine("Please choose one of the following options: \n1. See Mint Condition Triangle\n2. See Modern Triangle\n3. Exit");
string temp = Console.ReadLine();
if(!int.TryParse(temp, out int a))
{
    System.Console.WriteLine("Invalid option.");
    Environment.Exit(0);
}

int input = int.Parse(temp);

if(input == 1)
{
    GetFull();
}
else if(input == 2)
{
    GetPartial();
}
else if(input == 3)
{
    Environment.Exit(0);
}
else
{
    System.Console.WriteLine("Inavlid option.");
}

//end main


static void GetFull()
{
    Random rand = new Random();
    int length = rand.Next(3,10);
    int count = 0;
    string otriangle = "";
    while(count < length)
    {
        otriangle = otriangle + "O ";
        count++;
        System.Console.WriteLine(otriangle);
    }

}


static void GetPartial()
{
    Random rand = new Random();
    int length = rand.Next(3,10);
    int count = 0;
    string otriangle = "O ";
    while(count < length)
    {
        System.Console.WriteLine(otriangle);
        count++;
        int part = rand.Next(1,4);
        if(part == 2)
        {
            otriangle = "  " + otriangle;
        }
        else
        {
            otriangle = "O " + otriangle;
        }

    }
}