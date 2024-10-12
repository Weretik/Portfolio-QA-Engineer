/*
 Задание 1

Требуется: 
Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата заполнения анкеты). 
Поле дата заполнения анкеты должно быть проинициализировано только один раз 
(при создании экземпляра данного класса) без возможности его дальнейшего изменения. 
Реализуйте вывод на экран информации о пользователе
 */
Console.WriteLine("Task 1");
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
Console.WriteLine("Task 2");
Converter myConverter = new Converter(41.40, 45.05, 47.87);

{
    int totalUah = 25249;
    string currency = "usd";
    double resultConvert = myConverter.Convert(currency, totalUah);
    Console.WriteLine($"When converting {totalUah:N0} uah to {currency} the result is {resultConvert:F} {currency}");
}
{
    string currency = "chf";
    int totalChf = 1571;
    double resultConvertToUah = myConverter.ConvertToUah(currency, totalChf);
    Console.WriteLine($"When converting {totalChf:N0} {currency} to uah the result is {resultConvertToUah:F} uah");
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
Console.WriteLine("Task 3");
Employee employee = new Employee("Victor", "Victorovich")
{
    Position = "Developer",
    Experience = 5 
};
employee.DisplayInfo();


/*
  Задание 4
Требуется: 
Создать класс Invoice. 
В теле класса создать три поля int account, string customer, string provider, которые должны 
быть проинициализированы один раз (при создании экземпляра данного класса) без возможности их дальнейшего изменения. 
В теле класса создать два закрытых поля string article, int quantity Создать метод расчета 
стоимости заказа с НДС и без НДС. 
Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.
 */
Console.WriteLine();
Console.WriteLine("Task 4");
Invoice invoice = new Invoice(00534, "Atlant", "Doorios");
invoice.SetOrderDetails("Door", 3);
decimal pricePerItem = 22500.00m;

invoice.DisplayInvoice(true, pricePerItem); 
invoice.DisplayInvoice(false, pricePerItem); 



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

class  Invoice
{
    public int Account { get; }
    public string Customer { get; }
    public string Provider { get; }
    
    private string Article { get; set; }
    private int Quantity { get; set; }
    
    public Invoice(int account, string customer, string provider)
    {
        Account = account;
        Customer = customer;
        Provider = provider;
    }

    public void SetOrderDetails(string article, int quantity)
    {
        Article = article;
        Quantity = quantity;
    }

    public decimal CalculateTotalWithoutVAT(decimal pricePerItem)
    {
        return pricePerItem * Quantity;
    }
    
    public decimal CalculateTotalWithVAT(decimal pricePerItem)
    {
        decimal totalWithoutVAT = CalculateTotalWithVAT(pricePerItem);
        decimal vatRate = 0.20m;
        return totalWithoutVAT + (totalWithoutVAT * vatRate);
    }
    
    public void DisplayInvoice(bool includeVAT, decimal pricePerItem)
    {
        Console.WriteLine($"Account: {Account}");
        Console.WriteLine($"Customer: {Customer}");
        Console.WriteLine($"Provider: {Provider}");
        Console.WriteLine($"Product: {Article}");
        Console.WriteLine($"Quantity: {Quantity}");
            
        if (includeVAT)
        {
            Console.WriteLine($"Total with VAT: {CalculateTotalWithVAT(pricePerItem)} uah");
        }
        else
        {
            Console.WriteLine($"Total without VAT: {CalculateTotalWithoutVAT(pricePerItem)} uah");
        }
    }
}