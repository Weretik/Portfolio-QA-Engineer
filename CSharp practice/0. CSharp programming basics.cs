// Вивести іформацію на консоль

Console.WriteLine("My first text in that program");
Console.WriteLine("Hello peple!");
Console.WriteLine();

//Змінні та константи
{
    string name;
    name = "Hello, this is C#";
    byte age = 27;
    const string NAME_LANGUAGE = "C#";
}
/*
Типи даних

bool (System.Boolean): true або false

byte (System.Byte): ціле число від 0 до 255 і займає 1 байт / 8 біт ( від 0 до 2^8-1 )
sbyte (System.SByte): зберігає ціле число від -128 до 127 і займає 1 байт ( від -2^(8-1) до 2^(8-1)-1 )

short (System.Int16): зберігає ціле число від -32768 до 32767 і займає 2 байти / 16 біт ( від -2^(16-1) до 2^(16-1)-1 )
ushort (System.UInt16): зберігає ціле число від 0 до 65535 і займає 2 байти ( від 0 до 2^16-1 )

int (System.Int32): зберігає ціле число від -2147483648 до 2147483647 і займає 4 байти / 32 біти ( від -2^(32-1) до 2^(32-1-1)-1 )
uint (System.UInt32): зберігає ціле число від 0 до 4294967295 і займає 4 байти ( від 0 до 2^32-1 )

long (System.Int64): зберігає ціле число від -9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 і займає 8 байт / 64 біт ( від -2^(64-1) до 2^(64-1)-1 )
ulong (System.UInt64): зберігає ціле число від 0 до 18 446 744 073 709 551 615 і займає 8 байт ( від 0 до 2^64-1 )

float (System.Single): зберігає число з плаваючою крапкою від -3.4*1038 до 3.4*1038 і займає 4 байти, може зберігати 7 знаків після коми
double (System.Double): зберігає число з плаваючою крапкою від ±5.0*10-324 до ±1.7*10308 і займає 8 байтів, може зберігати 14 знаків після коми
decimal (System.Decimal): зберігає десяткове дробове число  від ±1.0*10-28 до ±7.9228*1028, може зберігати 28 знаків після коми

char (System.Char): зберігає одиночний символ у кодуванні Unicode і займає 2 байти
string (System.String): зберігає набір символів Unicode. Цьому типу відповідають рядкові літерали.

object (System.Object): може зберігати значення будь-якого типу даних і займає 4 байти на 32-розрядній платформі та 8 байт на 64-розрядній платформі. Є базовим для всіх інших типів і класів .NET.
*/
int myInt = 125;
float myFloat = 5.6f;
double myDouble = 12.798;
Console.WriteLine(myInt + myFloat + myDouble);
Console.WriteLine();

// Консольне введення-виведення
{
    string name = "Igor";
    int age = 35;
    double height = 1.79;
    Console.WriteLine($"Name: {name}, age: {age}, height: {height}");
}
Console.WriteLine();

//Перетворення базових типів даних
{
    byte a = 121;
    int b = a;
    Console.WriteLine(b);

    int x = 101;
    byte y = (byte)x;
    Console.WriteLine(y);
}

//Умовні вирази
{
    int a = 10;
    int b = 4;
    bool c, d, f, g;
    c = a >= b;
    d = a <= b;
    f = a == b;
    g = a != b;
    Console.WriteLine($"c : {c}\nb : {d},\nf {f},\ng {g}");
}
{
    bool x1 = (5 > 6) | (4 < 6);
    bool x2 = (5 > 6) | (4 > 6); 
   
    bool x3 = (5 > 6) & (4 < 6); 
    bool x4 = (5 < 6) & (4 < 6); 
        
    bool x5 = (5 > 6) || (4 < 6);
    bool x6 = (5 > 6) || (4 > 6); 
   
    bool x7 = (5 > 6) && (4 < 6); 
    bool x8 = (5 < 6) && (4 < 6);
   
    bool a = true;
    bool b = !a;
    
    bool x9 = (5 > 6) ^ (4 < 6);
    bool x10 = (50 > 6) ^ (4 / 2 < 3); 
}
Console.WriteLine();

//Конструкція if..else і тернарна операція
{
    string name = "Alex";

    if (name == "Tom")
    {
        Console.WriteLine("name is Tomas");
    }
    else if (name == "Bob")
    {
        Console.WriteLine("name is Robert");
    }
    else if (name == "Mike")
    {
        Console.WriteLine("name is Michael");
    }
    else
    {
        Console.WriteLine("unknown name"); 
    }

    int age = name == "Alex" ? 29 : 0;
    Console.WriteLine(age);
}

//Цикли
Console.WriteLine();
{
    for (int i = 0; i <= 5; i++)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine();
    
    int x = 5;
    
    while (x > 0)
    {
        Console.Write(x + " ");
        x--;
    }

    Console.WriteLine();
    
    do
    {
        Console.Write(x + " ");
    } while (x != 0);

    Console.WriteLine();

    foreach (char c in "Name")
    {
        Console.Write(c + " ");
    }
}

//Масиви
Console.WriteLine();
{
    int[] numbers = new int[4];
    int[] num = new int[5]{ 1, 2, 3, 4, 5 };
    string[] people = { "Tom", "Sam", "Bob" };
    
    foreach (int i in num)
    {
        Console.Write(i + "");
    }

    Console.WriteLine();
    for (int i = 0; i < people.Length; i++)
    {
        Console.Write(people[i] + " ");
    }

    Console.WriteLine();
    Console.WriteLine(people[^1]);
    
    int[,] nums1 = { { 0, 1, 2 }, { 3, 4, 5 } };
    Console.WriteLine(nums1[1,2]);
    int[,,] nums2 = new int[2, 3, 4];
    int[][] nums3 = new int[3][];
}

//Методи
Console.WriteLine();
{
    void Greetings()
    {
        Console.WriteLine("Hello, people");
    }
    
    Greetings();
    
    void PrintPerson(string name, int age = 18, string company = "Undefined")
    {
        Console.WriteLine($"Name: {name}  Age: {age}  Company: {company}");
    }
 
    PrintPerson("Tom", 37, "Microsoft");
    PrintPerson("Tom");
    
    Console.WriteLine();
    
    string GetMessage()
    {
        return "Hello";
    }
    void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
    PrintMessage(GetMessage());

    Console.WriteLine();
    
    void PrintMainPerson(string name, int age)
    {
        if(age > 120 || age < 1)
        {
            Console.WriteLine("Unacceptable age");
            return;
        }
        Console.WriteLine($"name: {name}  age: {age}");
    }
 
    PrintMainPerson("Tom", 37);
    PrintMainPerson("Bob", 1234);
    
    void Sum(int x, int y, out int result)
    {
        result = x + y;
    }
 
    int number;
 
    Sum(10, 15, out number);
 
    Console.WriteLine(number);
}
Console.WriteLine();
{
    void Sum(params int[]  numbers)
    {
        int result = 0;
        foreach (int n in numbers)
        {
            result += n;
        }
        Console.WriteLine(result);
    }
 
    int[] nums = { 1, 2, 3, 4, 5 };
    Sum(nums);
    Sum(1, 2, 3, 4);
    Sum(1, 2, 3);
    Sum();
}

//Рекурсивні функції
Console.WriteLine();
{
    int Factorial(int num)
    {
        if (num == 1) return 1;
        return num * Factorial(num - 1);
    }
    Console.WriteLine(Factorial(5));

    int Fibonachi(int n)
    {
        if (n == 0 || n == 1) return n;
        return Fibonachi(n - 1) + Fibonachi(n - 2);
    }

    int fib = Fibonachi(4);
    Console.WriteLine(fib);
}
//Конструкція switch
{
    string name = "Alex";
 
    switch (name)
    {
        case "Bob":
            Console.WriteLine("Your name - Bob");
            break;
        case "Tom":
            Console.WriteLine("Your name - Tom");
            break;
        case "Sam":
            Console.WriteLine("Your name - Sam");
            break;
        default:
            Console.WriteLine("Unknown name");
            break;
    }
}
/*
Перерахування enum
*/
{
    DayTime now = DayTime.Evening;
 
    PrintMessage(now);
    PrintMessage(DayTime.Afternoon);  
    PrintMessage(DayTime.Night);     
 
    void PrintMessage(DayTime dayTime)
    {
        switch (dayTime)
        {
            case DayTime.Morning:
                Console.WriteLine("Good Morning");
                break;
            case DayTime.Afternoon:
                Console.WriteLine("Good Afternoon");
                break;
            case DayTime.Evening:
                Console.WriteLine("Good Evening");
                break;
            case DayTime.Night:
                Console.WriteLine("Good Night");
                break;
        }
    }
}
enum DayTime
{
    Morning,
    Afternoon,
    Evening,
    Night
}