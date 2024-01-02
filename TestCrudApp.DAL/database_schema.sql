CREATE DATABASE IF NOT EXISTS synergies;
USE synergies;

CREATE TABLE employees (
	id INT NOT NULL AUTO_INCREMENT,
	employee_name VARCHAR(50),
	employee_age INT,
	employee_phone VARCHAR(10),
    PRIMARY KEY (id)
);

DELIMITER //
CREATE PROCEDURE sp_get_employees ()
BEGIN	
	SELECT * FROM employees;
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE sp_search_employee (IN term VARCHAR(50))
BEGIN
	SELECT * FROM employees
    WHERE employee_name LIKE CONCAT(term, '%');
END //
DELIMITER ;

DELIMITER //
CREATE PROCEDURE sp_maintain_employee (
	IN v_id INT,
    IN v_name VARCHAR(50),
    IN v_age INT,
	IN v_phone VARCHAR(10),
    INOUT v_action VARCHAR(30)
)
BEGIN
	IF (v_action = 'CREATE') THEN
		INSERT INTO employees (employee_name, employee_age, employee_phone)
        VALUES (v_name, v_age, v_phone);
	ELSEIF (v_action = 'UPDATE') THEN
		UPDATE employees
        SET employee_name = v_name, employee_age = v_age, employee_phone = v_phone
        WHERE id = v_id;
	ELSEIF (v_action = 'DELETE') THEN
		DELETE FROM employees
        WHERE id = v_id;
	END IF;
END //
DELIMITER ;
