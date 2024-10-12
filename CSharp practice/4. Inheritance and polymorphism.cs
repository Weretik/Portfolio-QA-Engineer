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

using System.Threading.Channels;

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
    
}

class Pupil
{
    public virtual void Study() => Console.WriteLine("Pupil is studying");
    public virtual void Read() => Console.WriteLine("Pupil is reading");
    public virtual void Write() => Console.WriteLine("Pupil is writing");
    public virtual void Relax() => Console.WriteLine("Pupil is relaxing");
}