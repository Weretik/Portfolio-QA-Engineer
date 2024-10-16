/*
Задание 1
    Требуется:
Создайте класс Printer.
    В теле класса создайте метод void Print(string value), который выводит на экран значение
аргумента.
    Реализуйте возможность того, чтобы в случае наследования от данного класса других классов, и вызове
    соответствующего метода их экземпляра, строки, переданные в качестве аргументов методов,
    выводились разными цветами.
    Обязательно используйте приведение типов.
*/



BluePrinter bluePrinter = new();
bluePrinter.Print("Hello");

Printer printer = bluePrinter;
if (printer is Printer)
{
    printer.Print("By");
}

BluePrinter? newBluePrinter = printer as BluePrinter;
if (newBluePrinter is not null)
{
    newBluePrinter.Print("New blue");
}

/*
Задание 2 
Требуется: 
Создать класс, представляющий учебный класс ClassRoom. 
Создайте класс ученик Pupil. В теле класса создайте методы void Study(), void Read(), void
Write(), void Relax(). 
Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса 
Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика. 
Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников. 
Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента. 
Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, 
писать, отдыхать
 */
Console.WriteLine();
Pupil excelentPupil = new ExcelentPupil();
Pupil goodPupil = new GoodPupil();
Pupil badPupil = new BadPupil();
ClassRoom classRoom = new(excelentPupil, goodPupil, badPupil);

classRoom.ShowPupils();


/*
Задание 3 
Требуется: 
Создать класс Vehicle. 
В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год 
выпуска). 
Создайте 3 производных класса Plane, Саг и Ship. 
Для класса Plane должна быть определена высота и количество пассажиров. 
Для класса Ship — количество пассажиров и порт приписки. 
Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
 */
Console.WriteLine();
Plane plane = new Plane(100, 200, 1000, 900_000, 2021, 10000, 150);
Car car = new Car(10, 20, 180, 180_000, 2018);
Ship ship = new Ship(30, 40, 80, 5_000_000, 2015, "Port of Odesa", 50);

// Вывод информации о каждом транспортном средстве
plane.ShowInfoVehicle();
car.ShowInfoVehicle();
ship.ShowInfoVehicle();

/*
Задание 4 
Создайте класс DocumentWorker. 
В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument(). 

В тело каждого из методов добавьте вывод на экран соответствующих строк: 
- "Документ открыт"
- "Редактирование документа доступно в версии Про"
- "Сохранение документа доступно в версии Про"

Создайте производный класс ProDocumentWorker. 
Переопределите соответствующие методы, при переопределении методов выводите следующие строки: 
- "Документ отредактирован"
- "Документ сохранен в старом формате, сохранение в остальных  форматах доступно в версии Эксперт"

Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker. 
Переопределите соответствующий метод. При вызове данного метода необходимо выводить на экран
- "Документ сохранен в новом формате".

В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp. 
Если пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается 
экземпляр базового класса), если пользователь ввел номера ключа доступа pro и exp, то должен 
создаться экземпляр соответствующей версии класса, приведенный к базовому – DocumentWorker.

 */
Console.WriteLine();
string proKey = "pro658";
string expKey = "exp915";

Console.WriteLine("Введите ключ доступа (если у вас его нет, нажмите Enter):");
string? userKey = Console.ReadLine();

DocumentWorker documentWorker;

if (userKey == proKey) documentWorker = new ProDocumentWorker();
else if (userKey == expKey) documentWorker = new ExpertDocumentWorker();
else documentWorker = new DocumentWorker();

documentWorker.OpenDocument();
documentWorker.EditDocument();
documentWorker.SaveDocument();

/*
 * Task 1
 */
class Printer
{
    public void Print(string value)
    {
        Console.WriteLine(value);
    }
    
}
class RedPrinter : Printer
{
    public void Print(string value)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(value);
        Console.ResetColor();
    }
}
class BluePrinter : Printer
{
    public void Print(string value)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(value);
        Console.ResetColor();
    }
}


/*
 * Task 2
*/
class ClassRoom
{
    private Pupil[] pupils = new Pupil[4];

    public ClassRoom(params Pupil[] pupils)
    {
        for (int i = 0; i < pupils.Length; i++)
        {
            this.pupils[i] = pupils[i];
        }
    }

    public void ShowPupils()
    {
        for (int i = 0; i < pupils.Length; i++)
        {
            if (pupils[i] is not null)
            {
                Console.WriteLine($"Student {i + 1}");
                pupils[i].Study();
                pupils[i].Read();
                pupils[i].Write();
                pupils[i].Relax();
                Console.WriteLine();
            }
        }
    }
}

class Pupil
{
    public virtual void Study() => Console.WriteLine("Pupil is studying");
    public virtual void Read() => Console.WriteLine("Pupil is reading");
    public virtual void Write() => Console.WriteLine("Pupil is writing");
    public virtual void Relax() => Console.WriteLine("Pupil is relaxing");
}

class ExcelentPupil : Pupil
{
    public override void Study() => Console.WriteLine("Pupil is studying perfectly");
    public override void Read() => Console.WriteLine("Pupil is reading perfectly");
    public override void Write() => Console.WriteLine("Pupil is writing perfectly");
    public override void Relax() => Console.WriteLine("Pupil is relaxing with great balance");
}

class GoodPupil : Pupil
{
    public override void Study() => Console.WriteLine("Pupil is studying good");
    public override void Read() => Console.WriteLine("Pupil is reading good");
    public override void Write() => Console.WriteLine("Pupil is writing good");
    public override void Relax() => Console.WriteLine("Pupil is relaxing as he tires");
}

class BadPupil : Pupil
{
    public override void Study() => Console.WriteLine("Pupil is studying bad");
    public override void Read() => Console.WriteLine("Pupil is reading bad");
    public override void Write() => Console.WriteLine("Pupil is writing bad");
    public override void Relax() => Console.WriteLine("Pupil is relaxing often");
}

/*
 * Task 3
 */
class Vehicle(int x, int y, double velocity, double price, double year)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;
    public double Velocity { get; set; } = velocity;
    public double Price { set; get; } = price;
    public double Year { get; set; } = year;

    public virtual void ShowInfoVehicle()
    {
        
        Console.WriteLine($"Cordinates: ({X}, {Y})");
        Console.WriteLine($"Velocity: {Velocity} km/h");
        Console.WriteLine($"Price: {Price}  USD");
        Console.WriteLine($"Year of manufacture: {Year}"); 
    }
}

class Plane(int x, int y, double velocity, double price, double year, double height, int passengers) 
    : Vehicle(x, y, velocity, price, year)
{
    public double Height { get; set; } = height;
    public int Passengers { get; set; } = passengers;
    
    public override void ShowInfoVehicle()
    {
        Console.WriteLine();
        Console.WriteLine("Plane");
        base.ShowInfoVehicle();
        Console.WriteLine($"Height: {Height} m");
        Console.WriteLine($"Passengers: {Passengers}");
    }
}

class Car(int x, int y, double velocity, double price, double year) : Vehicle(x, y, velocity, price, year)
{
    public override void ShowInfoVehicle()
    {
        Console.WriteLine();
        Console.WriteLine("Car");
        base.ShowInfoVehicle();
    }
}

class Ship(int x, int y, double velocity, double price, double year, string port, int passengers) 
    : Vehicle(x, y, velocity, price, year)
{
    public string Port { get; set; } = port;
    public int Passengers { get; set; } = passengers;
    
    public override void ShowInfoVehicle()
    {
        Console.WriteLine();
        Console.WriteLine("Ship");
        base.ShowInfoVehicle();
        Console.WriteLine($"Port: {Port}");
        Console.WriteLine($"Passengers: {Passengers}");
    }
}

/*
 * Task 4
 */

class DocumentWorker
{
    public void OpenDocument()
    {
        Console.WriteLine("Документ открыт");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Редактирование документа доступно в версии Про");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Сохранение документа доступно в версии Про");
    }
}

class ProDocumentWorker: DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Документ отредактирован");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно " +
                          "в версии Эксперт");
    }
}

class ExpertDocumentWorker: ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в новом формате");
    }
}