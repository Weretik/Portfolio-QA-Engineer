CREATE DATABASE CarsShop;
 
USE CarsShop; 

CREATE TABLE cars
(
	car_id int auto_increment,
	mark Varchar(20) NOT NULL,
	model Varchar(20) NULL,
	speed int NOT NULL,
	price int NOT NULL,
    primary key(car_id)
);

CREATE TABLE clients
(
	 id INT AUTO_INCREMENT NOT NULL,
     name VARCHAR(30),
     age TINYINT,
     phone VARCHAR(15),
     PRIMARY KEY (id)
)

-------------------------------------------------------------------------
INSERT INTO cars             
(mark, model, speed, price) 
VALUES
	('Audi', 'A5', 250, 50000),
    ('Porsche', '911', 285, 100000),
    ('Toyota', 'Camry', 150, 25000),
    ('Honda', 'Civic', 140, 22000),
    ('Ford', 'Mustang', 180, 35000),
    ('Chevrolet', 'Cruze', 130, 20000),
    ('Nissan', 'Altima', 140, 23000),
    ('BMW', 'X5', 200, 50000),
    ('Audi', 'A4', 160, 38000),
    ('Mercedes-Benz', 'C-Class', 170, 42000),
    ('Hyundai', 'Elantra', 130, 19000),
    ('Kia', 'Sorento', 160, 27000),
    ('Jeep', 'Wrangler', 190, 40000),
    ('Subaru', 'Outback', 150, 28000),
    ('Mazda', 'CX-5', 160, 26000),
    ('Lexus', 'RX', 190, 48000),
    ('Volkswagen', 'Passat', 150, 24000),
    ('Tesla', 'Model 3', 210, 45000),
    ('Volvo', 'S60', 170, 35000),
    ('Jaguar', 'XF', 190, 55000),
    ('Porsche', '911', 200, 80000),
    ('Land Rover', 'Discovery', 170, 65000),
    ('Acura', 'MDX', 160, 42000),
    ('Infiniti', 'Q50', 170, 38000),
    ('Cadillac', 'Escalade', 180, 75000),
    ('GMC', 'Sierra', 160, 35000),
    ('Lincoln', 'Navigator', 170, 72000),
    ('Chrysler', '300', 140, 32000),
    ('Buick', 'Enclave', 150, 36000),
    ('Mitsubishi', 'Outlander', 140, 25000),
    ('Fiat', '500', 120, 18000);

INSERT INTO clients            
(name, age, phone) 
VALUES
	('Andrew', 20, '0385078273'),
	('Sergey', 40, '9348174822'),
	('Alex', 22, '0385173482'),
	('Oleg', 24, '6972564216'),
    ('John Doe', 35, '555-123-4567'),
    ('Jane Smith', 28, '555-987-6543'),
    ('Robert Johnson', 45, '555-555-5555'),
    ('Emily Davis', 22, '555-777-8888'),
    ('Sarah Johnson', 32, '555-222-3333'),
    ('Michael Wilson', 40, '555-444-5555'),
    ('Jessica Lee', 27, '555-666-7777'),
    ('David Brown', 33, '555-888-9999'),
    ('Linda Martinez', 55, '555-111-2222'),
    ('James Taylor', 50, '555-333-4444'),
    ('Mary Wilson', 29, '555-777-1111'),
    ('Richard Smith', 37, '555-222-8888'),
    ('Patricia Davis', 43, '555-555-7777'),
    ('William Johnson', 60, '555-444-2222'),
    ('Jennifer Lee', 26, '555-999-1111'),
    ('Charles Miller', 48, '555-777-3333'),
    ('Karen Harris', 31, '555-333-6666'),
    ('George Taylor', 55, '555-111-5555'),
    ('Susan Anderson', 34, '555-222-1111'),
    ('Edward White', 41, '555-666-3333'),
    ('Lisa Robinson', 37, '555-444-7777'),
    ('Daniel Jackson', 29, '555-888-4444'),
    ('Margaret Davis', 45, '555-222-7777'),
    ('Joseph Clark', 50, '555-555-9999'),
    ('Nancy Martin', 28, '555-777-2222'),
    ('Paul Turner', 39, '555-666-8888'),
    ('Elizabeth Harris', 36, '555-444-6666'),
    ('Kevin Johnson', 42, '555-333-1111');
-------------------------------------------------------------------------

