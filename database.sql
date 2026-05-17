-- SMART FARMING DATABASE
-- =========================

-- ========= TABLES =========

CREATE TABLE "roles" (
    role_id BIGINT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    role_name TEXT NOT NULL
);

CREATE TABLE "users" (
    user_id BIGINT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    username TEXT NOT NULL,
    password TEXT NOT NULL,
    full_name TEXT NOT NULL,
    role_id BIGINT,
    CONSTRAINT fk_role
        FOREIGN KEY (role_id)
        REFERENCES "Roles"(role_id)
        ON DELETE SET NULL
);

CREATE TABLE "farms" (
    farm_id BIGINT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    farm_name TEXT NOT NULL,
    location TEXT NOT NULL,
    size_acre NUMERIC
);

CREATE TABLE "fields" (
    field_id BIGINT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    farm_id BIGINT,
    field_name TEXT NOT NULL,
    soil_type TEXT,
    area NUMERIC,
    CONSTRAINT fk_farm
        FOREIGN KEY (farm_id)
        REFERENCES "Farms"(farm_id)
        ON DELETE CASCADE
);

CREATE TABLE "crops" (
    crop_id BIGINT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    field_id BIGINT,
    crop_name TEXT NOT NULL,
    planting_date DATE,
    status TEXT,
    CONSTRAINT fk_field
        FOREIGN KEY (field_id)
        REFERENCES "Fields"(field_id)
        ON DELETE CASCADE
);

CREATE TABLE "sensorreadings" (
    reading_id BIGINT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    field_id BIGINT,
    temperature NUMERIC,
    moisture NUMERIC,
    reading_date TIMESTAMP,
    CONSTRAINT fk_sensor_field
        FOREIGN KEY (field_id)
        REFERENCES "Fields"(field_id)
        ON DELETE CASCADE
);

-- ========= DATA =========

INSERT INTO "roles" (role_name) VALUES
('Admin'),
('Technician'),
('Farmer');

INSERT INTO "users" (username, password, full_name, role_id) VALUES
('admin', '1234', 'System Admin', 1),
('tech1', '1234', 'Hydroponic Technician', 2),
('farmer1', '1234', 'Strawberry Grower', 3);

INSERT INTO "farms" (farm_name, location, size_acre) VALUES
('Hydro Strawberry Farm', 'Nicosia', 12),
('Smart Berry Lab', 'Kyrenia', 8);

INSERT INTO "fields" (farm_id, field_name, soil_type, area) VALUES
(1, 'Greenhouse A', 'Hydroponic', 3),
(1, 'Greenhouse B', 'Hydroponic', 4),
(2, 'Vertical Tower 1', 'Hydroponic', 2);

INSERT INTO "crops" (field_id, crop_name, planting_date, status) VALUES
(1, 'Strawberry Albion', '2026-03-01', 'Growing'),
(2, 'Strawberry Festival', '2026-02-15', 'Ready'),
(3, 'Strawberry San Andreas', '2026-03-10', 'Planted');

INSERT INTO "sensorreadings" (field_id, temperature, moisture, reading_date) VALUES
(1, 22, 70, '2026-05-06 10:00:00'),
(2, 24, 65, '2026-05-06 10:05:00'),
(3, 21, 75, '2026-05-06 10:10:00');


=======	QUERIES=======

 1-EMPTY FIELDS
SELECT f.field_name
FROM fields f
LEFT JOIN crops c ON f.field_id = c.field_id
WHERE c.crop_id IS NULL;

 This query lists fields that do not have any crops.

2**-** LATEST SENSOR DATA
SELECT f.field_name, s.temperature, s.reading_date
FROM sensorreadings s
JOIN fields f ON s.field_id = f.field_id
WHERE s.reading_date = (
    SELECT MAX(s2.reading_date)
    FROM sensorreadings s2
    WHERE s2.field_id = s.field_id
);

This query retrieves the most recent sensor reading for each field.


3-MIN & MAX TEMPERATURE
SELECT f.field_name,
       MAX(s.temperature) AS max_temp,
       MIN(s.temperature) AS min_temp
FROM sensorreadings s
JOIN fields f ON s.field_id = f.field_id
GROUP BY f.field_name;

 This query shows the minimum and maximum temperature recorded in each field.


4-CROPS PER FARM
SELECT fa.farm_name,
       COUNT(c.crop_id) AS total_crops
FROM farms fa
JOIN fields f ON fa.farm_id = f.farm_id
JOIN crops c ON f.field_id = c.field_id
GROUP BY fa.farm_name
ORDER BY total_crops DESC;

 This query counts the number of crops in each farm.

5-ABOVE AVERAGE TEMPERATURE
SELECT f.field_name,
       AVG(s.temperature) AS avg_temp
FROM sensorreadings s
JOIN fields f ON s.field_id = f.field_id
GROUP BY f.field_name
HAVING AVG(s.temperature) > (
    SELECT AVG(temperature)
    FROM sensorreadings
);

 This query lists fields with an average temperature above the overall average.


6-MAX MOISTURE
SELECT f.field_name,
	MAX(s.moisture) AS highest_moisture
FROM "fields" f
JOIN "sensorreadings" s ON f.field_id = s.field_id
 GROUP BY f.field_name ORDER BY highest_moisture DESC LIMIT 1
;
This query finds the field with the highest moisture value.


========PL/SQL =======

1. Procedure: add_crop
CREATE OR REPLACE PROCEDURE add_crop(
    p_field_id INT,
    p_crop_name TEXT,
    p_date DATE
)
LANGUAGE plpgsql
AS $$
BEGIN
    IF NOT EXISTS (
        SELECT 1 FROM crops
        WHERE field_id = p_field_id AND crop_name = p_crop_name
    ) THEN
        INSERT INTO crops(field_id, crop_name, planting_date, status)
        VALUES (p_field_id, p_crop_name, p_date, 'New');
    ELSE
        RAISE NOTICE 'Crop already exists in this field';
    END IF;
END;
$$;

CALL add_crop(1, 'StrawberryX', '2026-05-14');

2. Procedure: check_sensor_status
CREATE OR REPLACE PROCEDURE check_sensor_status(
    p_field_id INT,
    p_temperature NUMERIC,
    p_moisture NUMERIC
)
LANGUAGE plpgsql
AS $$
BEGIN
    IF p_temperature > 30 THEN
        UPDATE crops
        SET status = 'High Temperature Risk'
        WHERE field_id = p_field_id;

        RAISE NOTICE 'Temperature is too high. Crop status updated.';

    ELSIF p_moisture < 40 THEN
        UPDATE crops
        SET status = 'Low Moisture Risk'
        WHERE field_id = p_field_id;

        RAISE NOTICE 'Moisture is too low. Crop status updated.';

    ELSE
        UPDATE crops
        SET status = 'Healthy'
        WHERE field_id = p_field_id;

        RAISE NOTICE 'Field conditions are normal.';
    END IF;
END;
$$;

CALL check_sensor_status(1, 35, 50);

3. Procedure: add_new_user
CREATE OR REPLACE PROCEDURE add_new_user(
    p_username TEXT,
    p_password TEXT,
    p_full_name TEXT,
    p_role_id BIGINT
)
LANGUAGE plpgsql
AS $$
BEGIN
    INSERT INTO users(
        username,
        password,
        full_name,
        role_id
    )
    VALUES (
        p_username,
        p_password,
        p_full_name,
        p_role_id
    );

    RAISE NOTICE 'New user added successfully.';
END;
$$;

CALL add_new_user('zehra', '1234', 'Zehra Tas', 1);


4. Function: get_crop_count
CREATE OR REPLACE FUNCTION get_crop_count(p_field_id INT)
RETURNS INT
LANGUAGE plpgsql
AS $$
DECLARE
    total INT;
BEGIN
    SELECT COUNT(*) INTO total
    FROM crops
    WHERE field_id = p_field_id;

    RETURN total;
END;
$$;

SELECT get_crop_count(1);


5. Trigger: low_moisture_warning
CREATE OR REPLACE FUNCTION low_moisture_warning()
RETURNS TRIGGER AS $$
BEGIN
    IF NEW.moisture < 60 THEN
        RAISE NOTICE 'Warning: Low moisture detected!';
    END IF;

    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER trg_low_moisture
AFTER INSERT ON sensorreadings
FOR EACH ROW
EXECUTE FUNCTION low_moisture_warning();

6. Trigger: prevent_duplicate_farm
CREATE OR REPLACE FUNCTION prevent_duplicate_farm()
RETURNS TRIGGER
LANGUAGE plpgsql
AS $$
BEGIN
    IF EXISTS (
        SELECT 1 FROM farms WHERE farm_name = NEW.farm_name
    ) THEN
        RAISE EXCEPTION 'Farm name already exists!';
    END IF;

    RETURN NEW;
END;
$$;

CREATE TRIGGER trg_unique_farm
BEFORE INSERT ON farms
FOR EACH ROW
EXECUTE FUNCTION prevent_duplicate_farm();

7. Trigger + Table: high_temperature_alert
CREATE TABLE alerts (
    alert_id BIGINT GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    field_id BIGINT,
    message TEXT,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE OR REPLACE FUNCTION high_temperature_alert()
RETURNS TRIGGER AS $$
BEGIN
    IF NEW.temperature > 30 THEN
        INSERT INTO alerts(field_id, message)
        VALUES (
            NEW.field_id,
            'Critical temperature detected'
        );
    END IF;

    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER trg_high_temperature
AFTER INSERT ON sensorreadings
FOR EACH ROW
EXECUTE FUNCTION high_temperature_alert();


8. Function: monitor_all_fields
CREATE OR REPLACE FUNCTION monitor_all_fields()
RETURNS VOID AS $$
DECLARE
    field_record RECORD;
    avg_temp NUMERIC;
    avg_moisture NUMERIC;
BEGIN
    FOR field_record IN SELECT field_id FROM fields LOOP

        SELECT AVG(temperature), AVG(moisture)
        INTO avg_temp, avg_moisture
        FROM sensorreadings
        WHERE field_id = field_record.field_id;

        IF avg_temp IS NOT NULL THEN
            CALL check_sensor_status(field_record.field_id, avg_temp, avg_moisture);
        END IF;

    END LOOP;
END;
$$ LANGUAGE plpgsql;

SELECT monitor_all_fields();


9. view: crop monitoring dashboard view.
	CREATE OR REPLACE VIEW v_crop_monitoring_dashboard AS
SELECT 
    f.farm_id,
    f.farm_name,
    fi.field_id,
    fi.field_name,
    fi.soil_type AS farming_method, 
    c.crop_id,
    c.status AS crop_status,
    c.planting_date
FROM farms f
JOIN fields fi ON f.farm_id = fi.farm_id
JOIN crops c ON fi.field_id = c.field_id;

SELECT * FROM v_crop_monitoring_dashboard;
