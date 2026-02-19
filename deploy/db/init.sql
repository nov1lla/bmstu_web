CREATE TABLE IF NOT EXISTS UserDB (
  id SERIAL PRIMARY KEY,
  name TEXT NOT NULL,
  phone TEXT NOT NULL,
  address TEXT NOT NULL,
  email TEXT NOT NULL,
  login TEXT NOT NULL UNIQUE,
  password TEXT NOT NULL,
  role TEXT NOT NULL
);

DO $$
BEGIN
  IF NOT EXISTS (SELECT 1 FROM pg_roles WHERE rolname = 'replicator') THEN
    CREATE ROLE replicator WITH REPLICATION LOGIN PASSWORD 'replpass';
  END IF;
  IF NOT EXISTS (SELECT 1 FROM pg_roles WHERE rolname = 'app_readonly') THEN
    CREATE ROLE app_readonly WITH LOGIN PASSWORD 'readonly';
  END IF;
END
$$;

CREATE TABLE IF NOT EXISTS PromoDB (
  id SERIAL PRIMARY KEY,
  code TEXT NOT NULL UNIQUE,
  discount INT NOT NULL,
  data_start TIMESTAMP NOT NULL,
  data_end TIMESTAMP NOT NULL
);

CREATE TABLE IF NOT EXISTS ProductDB (
  id SERIAL PRIMARY KEY,
  name TEXT NOT NULL,
  price INT NOT NULL,
  quantity INT NOT NULL,
  manufacturer TEXT NOT NULL,
  description TEXT NOT NULL,
  id_seller INT
);

CREATE TABLE IF NOT EXISTS CartDB (
  id SERIAL PRIMARY KEY,
  data_created TIMESTAMP NOT NULL DEFAULT NOW(),
  id_user INT NOT NULL
);

CREATE TABLE IF NOT EXISTS ItemCartDB (
  id SERIAL PRIMARY KEY,
  id_product INT NOT NULL,
  id_cart INT NOT NULL,
  quantity INT NOT NULL
);

CREATE TABLE IF NOT EXISTS OrderDB (
  id SERIAL PRIMARY KEY,
  status TEXT NOT NULL,
  data_created TIMESTAMP NOT NULL DEFAULT NOW(),
  id_user INT NOT NULL,
  id_promo INT NOT NULL DEFAULT 0
);

CREATE TABLE IF NOT EXISTS ItemOrderDB (
  id SERIAL PRIMARY KEY,
  id_product INT NOT NULL,
  id_order INT NOT NULL,
  quantity INT NOT NULL
);

CREATE TABLE IF NOT EXISTS UserPromoDB (
  id SERIAL PRIMARY KEY,
  id_user INT NOT NULL,
  id_promo INT NOT NULL
);

GRANT CONNECT ON DATABASE db_ppo TO app_readonly;
GRANT USAGE ON SCHEMA public TO app_readonly;
GRANT SELECT ON ALL TABLES IN SCHEMA public TO app_readonly;
ALTER DEFAULT PRIVILEGES IN SCHEMA public GRANT SELECT ON TABLES TO app_readonly;

-- Seed data
INSERT INTO UserDB (name, phone, address, email, login, password, role) VALUES
  ('Admin User', '+70000000001', 'Moscow, Lenina 1', 'admin@example.com', 'admin', 'admin', 'Admin'),
  ('Seller User', '+70000000002', 'Moscow, Tverskaya 5', 'seller@example.com', 'seller', 'seller', 'Seller'),
  ('Client User', '+70000000003', 'Moscow, Arbat 10', 'client@example.com', 'client', 'client', 'Client');

INSERT INTO PromoDB (code, discount, data_start, data_end) VALUES
  ('WELCOME10', 10, NOW() - INTERVAL '30 days', NOW() + INTERVAL '365 days'),
  ('SPRING15', 15, NOW() - INTERVAL '10 days', NOW() + INTERVAL '90 days');

INSERT INTO ProductDB (name, price, quantity, manufacturer, description, id_seller) VALUES
  ('Pro Gaming Mouse', 4990, 50, 'LogiTech', 'Lightweight FPS mouse', 2),
  ('Mechanical Keyboard', 8990, 30, 'KeyChron', 'Hot‑swappable, RGB', 2),
  ('Gaming Headset', 7990, 40, 'HyperX', '7.1 surround sound', 2);

INSERT INTO CartDB (data_created, id_user) VALUES
  (NOW() - INTERVAL '1 day', 3);

INSERT INTO ItemCartDB (id_product, id_cart, quantity) VALUES
  (1, 1, 1),
  (2, 1, 1);

INSERT INTO OrderDB (status, data_created, id_user, id_promo) VALUES
  ('Init', NOW() - INTERVAL '2 days', 3, 1),
  ('Delivering', NOW() - INTERVAL '1 day', 3, 0);

INSERT INTO ItemOrderDB (id_product, id_order, quantity) VALUES
  (1, 1, 1),
  (3, 1, 1),
  (2, 2, 1);

INSERT INTO UserPromoDB (id_user, id_promo) VALUES
  (3, 1);
