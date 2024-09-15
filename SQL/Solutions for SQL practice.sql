-- DROP DATABASE onlinestore;
-- CREATE DATABASE OnlineStore;

/*
Завдання 1: Опис даних (DDL)
Мета: Створення об'єктів бази даних та встановлення взаємозв'язків.
*/

USE OnlineStore;

CREATE TABLE customers (
customer_id INT AUTO_INCREMENT PRIMARY KEY,
first_name VARCHAR(50),
last_name VARCHAR(50),
email VARCHAR(255),
registration_date DATE
);

CREATE TABLE products(
products_id INT AUTO_INCREMENT PRIMARY KEY,
products_name VARCHAR(50),
price DECIMAL(10, 2),
description TEXT
);

CREATE TABLE orders (
order_id INT AUTO_INCREMENT PRIMARY KEY,
customer_id INT,
order_date DATE,
total_amount DECIMAL(10, 2),
FOREIGN KEY (customer_id) REFERENCES customers(customer_id)
);

CREATE TABLE order_items(
item_id INT AUTO_INCREMENT PRIMARY KEY,
order_id INT,
product_id INT,
quantity INT,
subtotal DECIMAL(10, 2),
FOREIGN KEY (order_id) REFERENCES orders(order_id),
FOREIGN KEY (product_id) REFERENCES products(products_id)
)



/*
Завдання 2: Маніпуляція даними (DML)
Мета: Вставка, оновлення та видалення даних.
*/

INSERT INTO customers
(first_name, last_name, email, registration_date)
VALUES
("John", "Smith", "john.smith@example.com", '2023-01-15'),
("Emily", "Johnson", "emily.johnson@example.com", '2023-02-10'),
("Michael", "Davis", "michael.davis@example.com", '2023-03-05');

INSERT INTO products
(products_name, price, description)
VALUES
('Laptop',8800 , 'High-performance laptop'),
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
Завдання 3: JOINs та вибірка
Мета: Отримання даних з використанням JOIN та фільтрації.
*/
