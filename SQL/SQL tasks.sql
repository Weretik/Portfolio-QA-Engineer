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
Завдання 4
Напишіть SQL-запити для модифікації існуючої таблиці та додавання різних обмежень.
Передумови:
1.Створіть таблицю "Автори" з такими стовпцями:
	·author_id (ціле число) як первинний ключ.
	·full_name (рядок) для повного імені автора.
	·birth_year (ціле число) для року народження автора.
    
2.Створіть таблицю "Книги" з такими стовпцями:
	·book_id (ціле число) як первинний ключ.
	·title (рядок) для назви книги.
	·author_id (ціле число) для посилання на автора книги.
	·publication_year (ціле число) для року публікації книги.
*/
DROP TABLE Authors;
CREATE TABLE Authors (
author_id INT AUTO_INCREMENT PRIMARY KEY,
full_name VARCHAR(100),
birth_year INT
);

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
	a.Додайте обмеження зовнішнього ключа (Foreign Key) на стовпець author_id, який посилається на існуючу таблицю під назвою 'authors' з первинним ключем author_id.
	b.Додайте обмеження NOT NULL для стовпця title, забезпечивши, що у кожної книги є назва.
	c.Додайте обмеження CHECK до стовпця publication_year, щоб переконатися, що рік більше або дорівнює 1800.
	d.Створіть унікальне обмеження, яке забезпечує унікальність комбінації title та author_id.
2.Назвіть обмеження іноземного ключа 'fk_books_authors', а унікальне обмеження - 'uq_title_author_id'.
*/

ALTER TABLE books
ADD CONSTRAINT fk_books_authors
FOREIGN KEY (author_id)
REFERENCES authors(author_id);

ALTER TABLE books
MODIFY title VARCHAR(255) NOT NULL;

ALTER TABLE books
ADD CONSTRAINT chk_publication_year
CHECK (publication_year >= 1800);

ALTER TABLE books
ADD CONSTRAINT uq_title_author_id
UNIQUE (title, author_id);