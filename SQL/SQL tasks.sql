USE CarsShop; 


/*
Завдання 1 
Напишіть SQL-запит для отримання списку унікальних марок і моделей автомобілів з таблиці 'cars'.
Вимоги:
1. Використовуйте команди SELECT та DISTINCT для забезпечення того, що результат містить лише 
унікальні комбінації марок і моделей автомобілів.
2. Впорядкуйте результат в алфавітному порядку за маркою і моделлю автомобіля.
3. Обмежте результат максимум 10 рядками.
*/
 
SELECT DISTINCT mark, model FROM cars
LIMIT 10;


/*
Завдання 2
Напишіть SQL-запит для пошуку клієнтів з таблиці 'clients', номери телефонів яких відповідають  певному шаблону.
Вимоги:
1. Використовуйте команди SELECT та WHERE для фільтрації клієнтів за номерами телефонів.
2. Шаблон для пошуку - це номери телефонів, які починаються з '555-222' або '555-777'.
3. Впорядкуйте результат у зворотному алфавітному порядку за ім'ям клієнта.
4. Обмежте результат максимум 5 рядками.
*/

SELECT * FROM clients
WHERE phone LIKE '555-222%' OR phone LIKE '555-777%'
ORDER BY name DESC
LIMIT 5; 

/*
Завдання 3
Напишіть SQL-запити для створення нової таблиці, визначення обмеження первинного ключа та використання автоматичного збільшення для стовпця.
Вимоги:
1. Створіть таблицю під назвою 'employees' з такими стовпцями:
	a. employee_id (ціле число) як первинний ключ та автоматично збільшуваний.
	b. first_name (рядок) не більше 50 символів.
	c. last_name (рядок) не більше 50 символів.
	d. department (рядок) не більше 100 символів.
	e. salary (десяткове число) з точністю 10 та масштабом 2.
	f. hire_date (дата) для відстеження дати прийому на роботу.
2. Переконайтеся, що employee_id є первинним ключем таблиці та автоматично збільшується з кожним новим записом.
3. Визначте унікальне обмеження (UNIQUE) на комбінацію стовпців first_name та last_name, щоб забезпечити унікальність імені працівника.
4. Визначте обмеження NOT NULL для стовпця title, забезпечивши, що у кожного працівника є ім'я.
5. Переконайтеся, що ви визначили відповідні типи даних та обмеження для кожного стовпця.
*/

CREATE TABLE employees (
employee_id INT AUTO_INCREMENT PRIMARY KEY,
first_name VARCHAR(50) NOT NULL,
last_name VARCHAR(50) NOT NULL,
department VARCHAR(100),
salary DECIMAL(10, 2),
hire_date DATE,
UNIQUE (first_name, last_name)
)


/*
Створіть таблицю "Автори" з такими стовпцями:
	·author_id (ціле число) як первинний ключ.
	·full_name (рядок) для повного імені автора.
	·birth_year (ціле число) для року народження автора.
*/
CREATE TABLE Authors (
author_id INT AUTO_INCREMENT PRIMARY KEY,
full_name VARCHAR(100),
birth_year INT
);

/*
2.Створіть таблицю "Книги" з такими стовпцями:
	·book_id (ціле число) як первинний ключ.
	·title (рядок) для назви книги.
	·author_id (ціле число) для посилання на автора книги.
	·publication_year (ціле число) для року публікації книги.
*/
CREATE TABLE Books (
book_id INT AUTO_INCREMENT PRIMARY KEY,
title VARCHAR(255),
author_id INT,
publication_year INT,
FOREIGN KEY (author_id) REFERENCES Authors(author_id)
);

/*
Задача 5
1.Змініть таблицю 'books', щоб додати такі обмеження:
*/		
-- a.Додайте обмеження зовнішнього ключа (Foreign Key) на стовпець author_id, який посилається на існуючу таблицю під назвою 'authors' з первинним ключем author_id.
ALTER TABLE books
ADD CONSTRAINT fk_books_authors
FOREIGN KEY (author_id)
REFERENCES authors(author_id);

-- b.Додайте обмеження NOT NULL для стовпця title, забезпечивши, що у кожної книги є назва.
ALTER TABLE books
MODIFY title VARCHAR(255) NOT NULL;

-- c.Додайте обмеження CHECK до стовпця publication_year, щоб переконатися, що рік більше або дорівнює 1800.
ALTER TABLE books
ADD CONSTRAINT chk_publication_year
CHECK (publication_year >= 1800);

-- d.Створіть унікальне обмеження, яке забезпечує унікальність комбінації title та author_id.
ALTER TABLE books
ADD CONSTRAINT uq_title_author_id
UNIQUE (title, author_id);


-- Завдання 6
SET SQL_SAFE_UPDATES = 0;

-- Вставте новий запис в таблицю 'cars,' що представляє автомобіль з брендом 'Kia', моделлю 'Sportage', швидкістю 170 та ціною 27000.
INSERT INTO cars 
(mark, model, speed, price)
VALUES 
("Kia", "Sportage", 170, 27000)

-- Оновіть існуючий запис в таблиці 'cars.' Змініть ціну автомобіля 'Porsche 911' на 85000.
UPDATE cars 
SET price = 85000
WHERE mark = "Porsche" AND model = "911";

-- Видаліть автомобіль з таблиці 'cars,' де бренд 'Ford' та модель 'Mustang.
DELETE FROM cars
WHERE mark = "Ford" AND model = "Mustang"

-- Створіть SQL-запит, який видалить всі записи про автомобілі в таблиці 'cars,' де бренд починається на літеру 'C.'
DELETE FROM cars
WHERE mark LIKE 'C%'

-- Вставте нового клієнта в таблицю 'clients' з ім'ям 'Ірина,' віком 28 та номером телефону '0671234567'
INSERT INTO clients 
(name, age, phone)
VALUES
("Ірина", 28, "0671234567")

-- Оновіть існуючий запис в таблиці 'clients.' Змініть номер телефону клієнта з ім'ям 'Andrew' на '0999876543.'
UPDATE clients
SET phone = '0999876543.'
WHERE name = 'Andrew';

-- Видаліть клієнта з таблиці 'clients' за його іменем 'Alex.'
DELETE FROM clients
WHERE name = 'Alex'

SET SQL_SAFE_UPDATES = 1;

/*
Завдання 7

1. З'єднайте таблиці 'cars' та 'clients' за допомогою стовпця 'mark' (бренд автомобіля) та відобразіть інформацію про клієнтів, які купили автомобілі. 
	Поділіть результат на дві групи: клієнти, які купили новий автомобіль (ціна більше 30000), і клієнти, які купили б/в автомобіль (ціна менше або рівна 30000).
*/
SELECT clients.name, cars.mark, cars.model, cars.price
FROM clients
INNER JOIN cars ON clients.id = cars.car_id
WHERE cars.price > 30000;

SELECT clients.name, cars.mark, cars.model, cars.price
FROM clients
INNER JOIN cars ON clients.id = cars.car_id
WHERE cars.price <= 30000;

-- 2. Відобразіть усі записи з таблиці 'clients' та відповідні записи з таблиці 'cars' для клієнтів, які здійснили покупку. Також відобразіть тих клієнтів, які ще не купили автомобіль.
SELECT clients.name, clients.phone, cars.mark, cars.model, cars.price
FROM clients
LEFT JOIN cars ON clients.id = cars.car_id;

-- 3. Відобразіть усі записи з таблиці 'cars' та відповідні записи з таблиці 'clients' для автомобілів, які були куплені. Також відобразіть автомобілі, які ще не були придбані жодним клієнтом.
SELECT cars.mark, cars.model, cars.price, clients.name, clients.phone
FROM cars
RIGHT JOIN clients ON clients.id = cars.car_id;

-- 4. З'єднайте таблиці 'cars' та 'clients' і відобразіть усі доступні дані про покупки автомобілів.
SELECT clients.name, clients.phone, cars.mark, cars.model, cars.price
FROM clients
INNER JOIN cars ON clients.id = cars.car_id;

/*
Завдання 8
Мета: Практика використання агрегатних функцій, таких як COUNT, MAX, MIN, SUM, AVG, на таблиці 'cars'.
*/
-- Підрахуйте та відобразіть загальну кількість автомобілів, доступних у таблиці 'cars'.
SELECT COUNT(*) AS total_cars FROM cars;

-- Знайдіть та відобразіть максимальну швидкість серед усіх автомобілів у таблиці 'cars'.
SELECT MAX(speed) AS max_speed FROM cars;

-- Визначте та відобразіть мінімальну ціну автомобіля у таблиці 'cars'.
SELECT MIN(price) AS min_price FROM cars;

-- Розрахуйте загальну суму цін на автомобілі у таблиці 'cars' та відобразіть результат.
SELECT SUM(price) AS total_price FROM cars;

-- Знайдіть та відобразіть середню швидкість усіх автомобілів у таблиці 'cars'.
SELECT AVG(speed) AS avg_speed FROM cars;


/*
Завдання 9
Мета: Практика використання клозів GROUP BY та HAVING для аналізу даних про автомобілі.
*/
-- Згрупуйте автомобілі у таблиці 'cars' за їхньою 'mark' (брендом) та відобразіть кількість автомобілів для кожного бренду.
SELECT mark, COUNT(*) AS car_count FROM cars
GROUP BY mark;

-- Відфільтруйте результат з попереднього завдання, щоб відобразити лише ті бренди, де кількість автомобілів перевищує 2 одиниці.
SELECT mark, COUNT(*) AS car_count FROM cars
GROUP BY mark
HAVING car_count >= 2;

-- Згрупуйте автомобілі у таблиці 'cars' за їхньою 'speed' (швидкістю) та відобразіть середню ціну для автомобілів у кожній категорії швидкості.
SELECT speed, AVG(price) AS avg_price FROM cars
GROUP BY speed
ORDER BY speed ASC;

-- Відфільтруйте результат з попереднього завдання, щоб відобразити лише ті категорії швидкості, де середня ціна перевищує $30,000.
SELECT speed, AVG(price) AS avg_price FROM cars
GROUP BY speed
HAVING avg_price >= 30000;

-- Згрупуйте автомобілі у таблиці 'cars' за їхньою 'mark' (брендом) та розрахуйте загальну ціну для автомобілів у кожному бренді.
SELECT mark, SUM(price) AS total_price FROM cars
GROUP BY mark
ORDER BY total_price DESC;