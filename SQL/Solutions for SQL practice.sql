-- DROP DATABASE onlinestore;
/*
Завдання 1: Опис даних (DDL)
Мета: Створення об'єктів бази даних та встановлення взаємозв'язків.

1. Створіть базу даних з іменем 'OnlineStore.'
*/
CREATE DATABASE OnlineStore;
USE OnlineStore;

/*
2. Розробіть та створіть наступні таблиці з відповідними стовпцями:
a. Таблиця 'customers' із стовпцями: customer_id (автоінкрементне ціле число), first_name 
(рядок), last_name (рядок), email (рядок), registration_date (дата)
*/
CREATE TABLE customers (
customer_id INT AUTO_INCREMENT PRIMARY KEY,
first_name VARCHAR(50),
last_name VARCHAR(50),
email VARCHAR(255),
registration_date DATE
);

/*
b. Таблиця 'products' із стовпцями: product_id (автоінкрементне ціле число), product_name 
(рядок), price (десяткове число), description (текст)
*/
CREATE TABLE products(
product_id INT AUTO_INCREMENT PRIMARY KEY,
product_name VARCHAR(50),
price DECIMAL(10, 2),
description TEXT
);

/*
c. Таблиця 'orders' із стовпцями: order_id (автоінкрементне ціле число), customer_id (ціле 
число, зовнішній ключ до 'customers'), order_date (дата), total_amount (десяткове число)
*/
CREATE TABLE orders (
order_id INT AUTO_INCREMENT PRIMARY KEY,
customer_id INT,
order_date DATE,
total_amount DECIMAL(10, 2),
FOREIGN KEY (customer_id) REFERENCES customers(customer_id)
);

/*
d. Таблиця 'order_items' із стовпцями: item_id (автоінкрементне ціле число), order_id (ціле 
число, зовнішній ключ до 'orders'), product_id (ціле число, зовнішній ключ до 'products'), 
quantity (ціле число), subtotal (десяткове число)
*/
CREATE TABLE order_items(
item_id INT AUTO_INCREMENT PRIMARY KEY,
order_id INT,
product_id INT,
quantity INT,
subtotal DECIMAL(10, 2),
FOREIGN KEY (order_id) REFERENCES orders(order_id),
FOREIGN KEY (product_id) REFERENCES products(product_id)
)



/*
Завдання 2: Маніпуляція даними (DML)
Мета: Вставка, оновлення та видалення даних.

1. Вставте дані із розділу тестових даних 
*/
INSERT INTO customers
(first_name, last_name, email, registration_date)
VALUES
("John", "Smith", "john.smith@example.com", '2023-01-15'),
("Emily", "Johnson", "emily.johnson@example.com", '2023-02-10'),
("Michael", "Davis", "michael.davis@example.com", '2023-03-05');

INSERT INTO products
(product_name, price, description)
VALUES
('Laptop',800 , 'High-performance laptop'),
('Smartphone',400 , 'Latest smartphone model'),
('Tablet',300 , 'Portable tablet device');

INSERT INTO orders
(customer_id, order_date, total_amount)
VALUES
(1,'2023-04-20' , 1200.00),
(2,'2023-05-15' , 800.00),
(1,'2023-06-10' , 600.00);

INSERT INTO order_Items
(order_id, product_id, quantity, subtotal)
VALUES
(1, 1, 1, 800.00),
(1, 2, 2, 800.00),
(2, 1, 1, 400.00),
(3, 3, 3, 900.00);

SELECT * FROM customers;
SELECT * FROM products;
SELECT * FROM orders;
SELECT * FROM order_Items;

/*
2. Оновіть ціну конкретного продукту в таблиці 'products.'
*/
UPDATE products
SET price = 350
WHERE product_id = 3;

/*
3. Видаліть замовлення з таблиці 'orders,' переконавшись, що відповідні записи у таблиці 
'order_items' також видаляються.
*/
INSERT INTO order_items
(order_id, product_id, quantity, subtotal)
VALUES
(3, 3, 3, 500.00);

SELECT * FROM order_items;

DELETE FROM order_items
WHERE item_id = 5;

SELECT * FROM order_items;


/*
Завдання 3: JOINs та вибірка
Мета: Отримання даних з використанням JOIN та фільтрації.

1. Отримайте список клієнтів, які здійснили замовлення, включаючи їх імена, прізвища та загальну 
суму, яку вони витратили на замовлення. Використовуйте INNER JOIN між таблицями 'customers,' 
'orders' та 'order_items.'
*/
SELECT c.first_name, c.last_name, SUM(oi.subtotal) AS total_spent
FROM customers c
INNER JOIN orders o ON c.customer_id = o.customer_id
INNER JOIN order_items oi ON o.order_id = oi.order_id
GROUP BY c.customer_id, c.first_name, c.last_name;

/*
2. Знайдіть топ-5 продуктів з найвищими загальними продажами (сумою всіх значень 'subtotal' у 
'order_items'). Відобразіть назви продуктів та суми продажів
*/
SELECT p.product_name, SUM(oi.subtotal) AS total_sales
FROM products p
INNER JOIN order_items oi ON p.product_id = oi.product_id
GROUP BY p.product_name
ORDER BY total_sales DESC
LIMIT 5;

/*
3. Отримайте список продуктів, які не були замовлені жодним клієнтом. Використайте LEFT JOIN 
між таблицями 'products' та 'order_items' та відфільтруйте NULL значення в стовпці 'order_id.'
*/
INSERT INTO products
(product_name, price, description)
VALUES
('Macbook',500 , 'High-performance laptop');

SELECT p.product_name
FROM products p
LEFT JOIN order_items oi ON p.product_id = oi.product_id
WHERE oi.order_id IS NULL
GROUP BY p.product_name;

/*
Завдання 4: Агрегація та групування даних
Мета: Виконання агрегації та групування даних.

 1. Розрахуйте та відобразіть загальний дохід для кожного місяця в таблиці 'orders' 
за поточний рік. Згрупуйте результати за місяцями.
*/
SELECT MONTH(order_date) AS month, SUM(total_amount) as total_sum
FROM orders
WHERE YEAR(order_date) = 2023
GROUP BY month;

/*
2. Знайдіть клієнта з найвищими витратами в таблиці 'orders.' 
Відобразіть їх ім'я, електронну пошту та загальні витрати
*/
SELECT c.first_name, c.email, SUM(o.total_amount) AS total_spent
FROM customers c
INNER JOIN orders o ON c.customer_id = o.customer_id
GROUP BY c.customer_id, c.first_name
ORDER BY total_spent DESC
LIMIT 1;

/*
3. Порахуйте кількість замовлень для кожного клієнта в таблиці 'orders.' 
Відобразіть імена клієнтів та кількість замовлень, сортуючи їх у спадному 
порядку кількості замовлень
*/
SELECT c.first_name, c.last_name, COUNT(o.order_id) AS total_orders
FROM customers c
INNER JOIN orders o ON c.customer_id = o.customer_id
GROUP BY c.customer_id, c.first_name, c.last_name;