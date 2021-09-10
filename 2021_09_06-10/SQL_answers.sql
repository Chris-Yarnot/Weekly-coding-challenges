CREATE TABLE IF NOT EXISTS worker(
	employee_id serial PRIMARY KEY,
	first_name VARCHAR(30) NOT NULL,
	last_name VARCHAR(30) NOT NULL,
	salary DECIMAL(10, 2) NOT NULL,
	joining_date DATETIME NOT NULL, --this might be filled IN automatically WITH the NOW() FUNCTION IF we were going TO automate this
	department VARCHAR(30) NOT NULL --this would be listed IN another TABLE IF we were USING DATA normalization
);
INSERT INTO worker (first_name, last_name, salary, joining_date, department) VALUES
	( 'Rick',	'Smith',	100000,	'2021-02-20 09:00:00',	'HR'),
	( 'Sam', 	'Williams',	 80000,	'2021-06-11 09:00:00',	'Admin'),
	( 'John',	'Brown',	300000,	'2021-02-20 09:00:00',	'HR'),
	( 'Amy', 	'Jones',	500000,	'2021-02-20 09:00:00',	'Admin'),
	( 'Sean',	'Garcia',	500000,	'2021-06-11 09:00:00',	'Admin'),
	( 'Ryan',	'Miller',	200000,	'2021-06-11 09:00:00',	'Account'),
	( 'Patty',	'Davis',	 75000,	'2021-01-20 09:00:00',	'Account'),
	( 'Monica',	'Rodriguez', 90000,	'2021-04-11 09:00:00',	'Admin');

CREATE TABLE IF NOT EXISTS bonus(
	WORKER_ref_id INT NOT NULL,
	Bonus_date DATETIME NOT NULL,
	Bonus_ammount DECIMAL(10, 2) NOT NULL,
	CONSTRAINT worker_ref_id_fk FOREIGN KEY (worker_ref_id) REFERENCES worker (employee_id)
);

INSERT INTO bonus (worker_ref_id, bonus_date, bonus_ammount) VALUES
	(1,	'2021-02-20 00:00:00',	5000),
	(2,	'2021-06-11 00:00:00',	3000),
	(3,	'2021-02-20 00:00:00',	4000),
	(1,	'2021-02-20 00:00:00',	4500),
	(2,	'2021-06-11 00:00:00',	3500);
	
CREATE TABLE IF NOT EXISTS title(
	worker_ref_id INT NOT NULL,
	worker_title VARCHAR(30) NOT NULL,
	affected_from DATETIME,
	CONSTRAINT worker_ref_id_fk FOREIGN KEY (worker_ref_id) REFERENCES worker (employee_id)
);

INSERT INTO title (worker_ref_id, worker_title, affected_from) VALUES
	(1, 'Manager',		'2021-02-20 00:00:00'),
	(2, 'Executive',	'2021-06-11 00:00:00'),
	(8, 'Executive',	'2021-06-11 00:00:00'),
	(5, 'Manager',		'2021-06-11 00:00:00'),
	(4, 'Asst. Manager','2021-06-11 00:00:00'),
	(7, 'Executive',	'2021-06-11 00:00:00'),
	(6, 'Lead',			'2021-06-11 00:00:00'),
	(3, 'Lead',			'2021-06-11 00:00:00');
--A
SELECT first_name,last_name FROM worker WHERE salary>=50000 AND salary<=100000;

--B
SELECT department, COUNT(*) FROM worker GROUP BY department;

--C
SELECT * FROM worker LEFT JOIN title ON title.worker_ref_id = worker.employee_id ;

--D
SELECT * from worker wrkr where 
        4 = (SELECT COUNT(*) from worker temp_wrkr 
        where wrkr.salary < temp_wrkr.salary);
        
