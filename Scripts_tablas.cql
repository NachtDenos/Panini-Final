CREATE TABLE pia_hoteles.usuario (
name text,
p_lastname text,
m_lastname text,
birthdate date,
email text,
payroll_number text,
address text,
phone_home text,
phone_personal text,
password text,
status boolean,
date_register date,
time_register text,
PRIMARY KEY (email)
);

CREATE TABLE pia_hoteles.contrasenias (
id_user uuid,
last_pass text,
last_last_pass text,
PRIMARY KEY (id_user)
);
CREATE TABLE pia_hoteles.hotel (
id_hotel uuid,
name text,
country text,
city text,
state text,
floors_number int,
rooms_number int,
turistic_zone text,
services_add list<text>,
beach boolean,
pool_number int,
events_room boolean,
register_date date,
operations_date text,
status boolean,
date_register date,
hour_register text,
user_register text,
PRIMARY KEY (id_hotel, name)
);
CREATE TABLE pia_hoteles.habitacion (
id_room uuid,
type text,
beds_number int,
beds_type text,
price decimal,
people_number int,
room_level text,
frontof text,
details text,
amenities text,
hotel_parent uuid,
status boolean,
date_register date,
hour_register text,
user_register text,
PRIMARY KEY (id_room, type)
);
CREATE TABLE pia_hoteles.cliente (
id_clients uuid,
name text,
p_lastname text,
m_lastname text,
birthdate date,
email text,
address text,
phone_home int,
phone_personal int,
rfc text,
marital_status text,
references text,
status boolean,
change_date timestamp,
last_updater UUID,
PRIMARY KEY (id_clients, p_lastname)
);
CREATE TABLE pia_hoteles.reserva(
id_reserva uuid,
client_own uuid,
hotel uuid,
room set<uuid>,
city text,
people_number int,
init_date date,
end_date date,
price decimal,
status boolean,
payment_method map<text, decimal>,
date_register date,
hour_register text,
user_register text,
PRIMARY KEY (id_reserva, init_date)
);
CREATE TABLE pia_hoteles.reportehotel(
name text,
city text,
country text,
rooms_number int,
date_ date,
type_room text,
ocupattion float,
guests text,
PRIMARY KEY ((name), city, country, date_)
);
CREATE TABLE pia_hoteles.reporteventas(
name text,
city text,
country text,
date_ date,
lodging float,
services float,
total float,
PRIMARY KEY ((name), city, country, date_)
);
CREATE TABLE pia_hoteles.historialcliente(
id_customer uuid,
name_customer text,
lastp_customer text,
lastm_customer text,
city text,
hotel text,
type_room text,
people_number int,
code_reservation int,
date_reservation date,
date_checkin date,
date_checkout date,
status_reservation text,
advance float,
lodging float,
services float,
total float,
PRIMARY KEY (date_reservation, lastp_customer)
);
CREATE TABLE pia_hoteles.activarusuario (
id_user uuid,
name text,
p_lastname text,
m_lastname text,
email text,
status text,
PRIMARY KEY (status, id_user)
);
CREATE TABLE pia_hoteles.cancelaciones (
id_cancellations uuid,
id_reservation uuid,
refund float,
date date,
hour text,
user_cancellation text,
PRIMARY KEY (id_cancellations, user_cancellation)
);
CREATE TABLE pia_hoteles.buscarcliente (
id_user uuid,
name text,
p_lastname text,
m_lastname text,
email text,
rfc text,
PRIMARY KEY (p_lastname, m_lastname)
);
CREATE TABLE pia_hoteles.buscarcliente2 (
id_user uuid,
name text,
p_lastname text,
m_lastname text,
email text,
rfc text,
PRIMARY KEY (email, p_lastname)
);
CREATE TABLE pia_hoteles.buscarcliente3 (
id_user uuid,
name text,
p_lastname text,
m_lastname text,
email text,
rfc text,
PRIMARY KEY (rfc, p_lastname)
);
CREATE TABLE pia_hoteles.buscarciudad (
id_hotel uuid,
name text,
country text,
state text,
city text,
floors_number int,
rooms_number int,
turistic_zone text,
services_add list<text>,
beach boolean,
pool_number int,
events_room boolean,
PRIMARY KEY (city, name)
);

select * from usuario;
use pia_hoteles;

INSERT INTO usuario (email,password,address,birthdate,date_register,m_lastname,name,p_lastname,payroll_number,phone_home,phone_personal,status,time_register) VALUES ('isaac@gmail.com','contrasena','Escomiedo','2002-03-02','2023-04-28','Morales','Isaac','Espinoza','1231321','1111','12222',true,'14:23:48');

