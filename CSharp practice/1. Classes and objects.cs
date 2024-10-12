/*
Задание 1
Требуется: Создать класс с именем Rectangle. 
В теле класса создать два поля, описывающие длины сторон double side1, side2.
Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого
поля side1 и side2 инициализируются значениями аргументов.
Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр
прямоугольника - double PerimeterCalculator().
Создать два свойства double Area и double Perimeter с одним методом доступа get.
Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит
на экран периметр и площадь.
*/

Rectangle a = new Rectangle(2.7, 3.1);

/*
Задание 2
Требуется:
Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать
одно строковое поле и метод void Show().
Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.
Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание.
*/

Book darkBook = new Book();

Console.OutputEncoding = System.Text.Encoding.UTF8;

darkBook.Title.bookTitle = "Dark Souls: Спокута. Том 1. Утрачена людяність";
darkBook.Author.bookAuthor = "Жульєн Блондель";
darkBook.Content.bookContent = "У даному творі ми знайомимося з героїнею, яку повернув до життя таємничий знак. " +
                               "Вона прокидається в розбитому світі без спогадів про своє минуле, що створює загадкову " +
                               "основу для подальшого розвитку сюжету. Втрата пам'яті є класичним літературним прийомом," +
                               " і Блондель використовує його, щоб поглибити інтригу і навести читача на роздуми про " +
                               "людську ідентичність і долю.\n\nВідразу після пробудження героїня потрапляє під загрозу" +
                               " від небезпечної гільдії Вартових луски, які прагнуть її захопити. Це створює " +
                               "безперервний натиск та інтригу, які тримають читача в напрузі від початку до кінця. " +
                               "Здається, що небезпека оточує героїню з усіх боків, і вона має боротися не лише з " +
                               "фізичними загрозами, але й з глибокими внутрішніми конфліктами.\n\nРекомендуємо придбати" +
                               " книгу саме у мережі магазинів \"Книгарня Є\". Видання знаходиться у розділі манги. " +
                               "Радимо звернути увагу і на книгу «Мої близнюки» із цього ж розділу.";

darkBook.show();

/*
Задание 3
Требуется:

Создать классы Point и Figure.

Класс Point должен содержать два целочисленных поля и одно строковое поле.

Создать три свойства с одним методом доступа get.

Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями
аргументов. Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти
аргументов типа Point.

Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину
стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр
многоугольника.

Написать программу, которая выводит на экран название и периметр многоугольника. 

*/
Point point1 = new Point(1, 1, "A");
Point point2 = new Point(4, 1, "B");
Point point3 = new Point(4, 3, "C");
Point point4 = new Point(1, 3, "D");

Figure figure = new Figure(point1, point2, point3, point4);

figure.PerimeterCalculator();

/*
 *
 *
 *
 *
 * 
 */
class Rectangle
{
    public double side1;
    public double side2;

    public double Area { get; }
    public double Perimeter{ get; }
    
    public double AreaCalculator()
    {   
        return side1 * side2;
        
    }

    public double PerimeterCalculator()
    {
        return 2 * (side1 + side2);
    }

    public Rectangle(double side1 = 1, double side2 = 1)
    {
        this.side1 = side1;
        this.side2 = side2;
        
        Area = AreaCalculator();
        Perimeter = PerimeterCalculator();
        Console.WriteLine($"Area Rectangle : {Area:F2}\nPerimeter Rectangel {Perimeter:F2}");
    }
}

class Title
{
    public string bookTitle;

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"book title: {bookTitle}");
        Console.ResetColor();
    }
}

class Author
{
    public string bookAuthor;

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"book author: {bookAuthor}");
        Console.ResetColor();
    }
}

class Content
{
    public string bookContent;

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine($"book content: {bookContent}");
        Console.ResetColor();
    }
}

class Book
{
    public Title Title{ get; set; }
    public Author Author{ get; set; }
    public Content Content{ get; set; }

    public void show()
    {
        Title.Show();
        Author.Show();
        Content.Show();
    }

    public Book()
    {
        Title = new Title();
        Author = new Author();
        Content = new Content();
    }
}

class Point(int x, int y, string name)
{
    public int X { get; } = x;
    public int Y { get; } = y;
    public string Name { get; } = name;
    
}

class Figure
{
    public Point[] Points;

    public Figure(Point p1, Point p2, Point p3)
    {
        Points = new Point[] { p1, p2, p3 };
    }
    public Figure(Point p1, Point p2, Point p3, Point p4)
    {
        Points = new Point[] { p1, p2, p3, p4 };
    }
    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
    {
        Points = new Point[] { p1, p2, p3, p4, p5 };
    }

    public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }
    public void PerimeterCalculator()
    {
        double perimeter = 0;
        for (int i = 0; i < Points.Length; i++)
        {
            Point nextPoint = (i == Points.Length - 1) ? Points[0] : Points[i + 1];
            perimeter += LengthSide(Points[i], nextPoint);
        }
        Console.WriteLine($"Perimeter: {perimeter}");
    }

}