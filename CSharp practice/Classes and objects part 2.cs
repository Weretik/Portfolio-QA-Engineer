﻿/*
 Задание 1

Требуется: 
Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата заполнения анкеты). 
Поле дата заполнения анкеты должно быть проинициализировано только один раз 
(при создании экземпляра данного класса) без возможности его дальнейшего изменения. 
Реализуйте вывод на экран информации о пользователе
 */

User userVova = new User("Vivian", "Oleg", "Frankovich", 29);
userVova.ShowInfo();

/*
Задание 2 

Требуется: 
Создать класс Converter. 
В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента, 
и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне – public
Converter(double usd, double eur, double chf).
Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют, 
также программа должна производить конвертацию из указанных валют в гривну.
*/

Console.WriteLine();
Converter myConverter = new Converter(41.40, 45.05, 47.87);

{
    int totalUah = 25249;
    string currency = "usd";
    double resultConvert = myConverter.Convert(currency, totalUah);
    Console.WriteLine($"When converting {totalUah} uah to {currency} the result is {resultConvert:F} {currency}");
}
{
    string currency = "chf";
    int totalChf = 1571;
    double resultConvertToUah = myConverter.ConvertToUah(currency, totalChf);
    Console.WriteLine($"When converting {totalChf} {currency} to uah the result is {resultConvertToUah:F} uah");
}

/*
 Задание 3
Требуется: 
Создать класс Employee. 
В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и 
инициализирует поля, соответствующие фамилии и имени сотрудника. 
Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый 
сбор. 
Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность), 
оклад и налоговый сбор. 
 */
Console.WriteLine();
Employee employee = new Employee("Victor", "Victorovich")
{
    Position = "Developer",
    Experience = 5 
};
employee.DisplayInfo();





/*
 * 
 */

public class Employee
{
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Position { get; set; }
    public int Experience { get; set; }

    
    public Employee(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    
    public decimal CalculateSalary()
    {
        decimal baseSalary;

        switch (Position.ToLower())
        {
            case "manager":
                baseSalary = 50000;
                break;
            case "developer":
                baseSalary = 60000;
                break;
            case "tester":
                baseSalary = 40000;
                break;
            default:
                baseSalary = 30000; 
                break;
        }

        
        decimal experienceBonus = baseSalary * 0.1m * Experience;
        return baseSalary + experienceBonus;
    }
    
    public decimal CalculateTax()
    {
        decimal salary = CalculateSalary();
        return salary * 0.18m;
    }

    // Метод для вывода информации о сотруднике
    public void DisplayInfo()
    {
        Console.WriteLine($"Last name: {LastName}");
        Console.WriteLine($"Name: {FirstName}");
        Console.WriteLine($"Position: {Position}");
        Console.WriteLine($"Salary: {CalculateSalary()} uah");
        Console.WriteLine($"Tax levy: {CalculateTax()} uah");
    }
}

class User
{
    public string Login { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public DateTime DateFilling { get; }
    
    public User(string login, string firstName, string lastName, int age)
    {
        Login = login;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        DateFilling = DateTime.Now;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Login:" + " " + Login);
        Console.WriteLine("First name:" + " " + FirstName);
        Console.WriteLine("Seconmd name:" + " " + LastName);
        Console.WriteLine("Age:" + " " + Age);
        Console.WriteLine("Date of filling" + " " + DateFilling);
    }
}

class Converter
{
    public double UsdRate { get; set; }
    public double EurRate { get; set; }
    public double ChfRate { get; set; }
    
    public Converter(double usdRate, double eurRate,double chfRate)
    {
        UsdRate = usdRate;
        EurRate = eurRate;
        ChfRate = chfRate;
    }

    public double Convert(string currency, int totalUah) => currency switch
    {
        "usd" => totalUah / UsdRate,
        "eur" => totalUah / EurRate,
        "chf" => totalUah / ChfRate,
        _ => 0
    };

    public double ConvertToUah(string currency, int total) => currency switch
    {   
        "usd" => total * UsdRate,
        "eur" => total * EurRate,
        "chf" => total * ChfRate,
        _ => 0
    };
}

