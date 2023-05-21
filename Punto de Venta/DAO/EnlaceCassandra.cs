using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cassandra;
using Cassandra.Mapping;
using System.Configuration;
using System.Windows.Forms;
using Cassandra.Data;
using Punto_de_Venta.Clases;

namespace Punto_de_Venta
{
    public class EnlaceCassandra
    {
        //Soy un comentario y puedo dejar en claro que el webito con frijoles es lo maximo
        static private string _dbServer { set; get; }
        static private string _dbKeySpace { set; get; }
        static private Cluster _cluster;
        static private ISession _session;
        
        private static void conectar()
        {
            _dbServer = ConfigurationManager.AppSettings["Cluster"].ToString();
            _dbKeySpace = ConfigurationManager.AppSettings["KeySpace"].ToString();

            _cluster = Cluster.Builder()
                .AddContactPoint(_dbServer)
                .Build();

            _session = _cluster.Connect(_dbKeySpace);
        }


        private static void conectar2()
        {
            _cluster = Cluster.Builder()
                .AddContactPoint("127.0.0.1")
                .Build();

            _session = _cluster.Connect("keyspace3");
        }

        private static void desconectar()
        {
            _cluster.Dispose();
        }
        public List<Usuario> Obtener_usuarios()
        {
            string query = "select name, password, email, p_lastname, m_lastname, birthdate, payroll_number, address, phone_home, phone_personal, status from usuario;";
            List<Usuario> lista= new List<Usuario>();
            conectar();
            var ResultSet = _session.Execute(query);
            foreach(var row in ResultSet)
            {
                Usuario usuarios = new Usuario();
                usuarios.nombre = row.GetValue<string>("name");
                usuarios.contrasena = row.GetValue<string>("password");
                usuarios.correo = row.GetValue<string>("email");
                usuarios.apellidoP = row.GetValue<string>("p_lastname");
                usuarios.apellidoM = row.GetValue<string>("m_lastname");
                usuarios.FechaNacimiento = row.GetValue<object>("birthdate")==null?"": row.GetValue<object>("birthdate").ToString();
                usuarios.nomina = row.GetValue<string>("payroll_number");
                usuarios.direccion = row.GetValue<string>("address");
                usuarios.telefonoCasa = row.GetValue<string>("phone_home");
                usuarios.telefono = row.GetValue<string>("phone_personal");
                usuarios.status=row.GetValue<Nullable<bool>>("status") == null ? false : row.GetValue<bool>("status");
                //usuarios.FechaIngreso = row.GetValue<object>("date_register") == null ? "" : row.GetValue<object>("date_register").ToString();
                //usuarios.horaderegistro = row.GetValue<string>("time_register");
                lista.Add(usuarios);
            }
            
            desconectar();
            return lista;

        }
        public bool Modif_Usuarios(Usuario param, string email)
        {
            var Err = true; // SI no hay error
            try
            {
                conectar();
                var query1 = "update usuario  set " +
                    "name='{0}', password='{1}', p_lastname='{2}', m_lastname='{3}'," +
                    "birthdate='{4}', payroll_number='{5}', address='{6}', phone_home='{7}'," +
                    "phone_personal='{8}', date_register='{9}', time_register='{10}' where email='{11}' if exists";
                query1 = string.Format(query1, param.nombre, param.contrasena, param.apellidoP, param.apellidoM,
                    param.FechaNacimiento, param.nomina, param.direccion, param.telefonoCasa, param.telefono, param.FechaIngreso, param.horaderegistro, email);
                _session.Execute(query1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Err = false;
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }
        public bool Delete_Usuarios(string email)
        {
            var Err = true; // SI no hay error
            try
            {
                conectar();
                var query1 = "delete from usuario where email='{0}' if exists";
                query1 = string.Format(query1, email);
                _session.Execute(query1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Err = false;
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }
        public bool login(string email, string pass)
        {
            List<Usuario> lista = Obtener_usuarios();
            foreach (Usuario row in lista)
            {
                if (email == row.correo && pass == row.contrasena)
                {
                    return true;
                }
            }
            return false;
        }
        public bool login2(string email, string pass)
        {
            string query = "select email, password from usuario where email='{0}' AND password='{1}';";
            query = string.Format(query, email, pass);
            int contador = 0;
            conectar();
            var ResultSet = _session.Execute(query);
            foreach (var row in ResultSet)
            {
                contador++;
            }
            desconectar();
            if (contador == 0)
            {
                return false;
            }
            return true;

        }
        public bool ObtenerUsuarios()
        {
            try
            {
                conectar();

                string query = "SELECT name, email FROM usuario;";

                // Execute a query on a connection synchronously 
                var rs = _session.Execute(query);

                // Iterate through the RowSet 
                foreach (var row in rs)
                {
                    var value = row.GetValue<string>("name");
                    // Do something with the value 
                    var texto = row.GetValue<string>("email");
                    // Do something with the value 

                    MessageBox.Show(texto, value.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                    RowSet rsUsers = _session.Execute(query);

                    ////////////////////////////////////////////////
                    //var users = new List<UserModel>();
                    //foreach (var userRow in rsUsers)
                    //{
                    //    //users.Add(ReflectionTools.GetSingleEntryDynamicFromReader<UserModel>(userRow));
                    //}

                    //foreach (UserModel user in users)
                    //{
                    //    Console.WriteLine("{0} {1} {2} {3} {4}", user.Id, user.FirstName, user.LastName, user.Country, user.IsActive);
                    //}

                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            return false;
        }

        public bool InsertarOperativos(Usuario param)
        {
            var Err = true; // SI no hay error
            try
            {
                conectar();
                //Cambie algo en las tablas
                var query1 = "insert into usuario(name, password, email, p_lastname, m_lastname, birthdate, " +
                    "payroll_number, address, phone_home, phone_personal, status, date_register, time_register) " +
                    "values ('{0}' ,'{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', {10}, '{11}', '{12}') if not exists; ";
                query1 = string.Format(query1, param.nombre, param.contrasena, param.correo, param.apellidoP, param.apellidoM, 
                    param.FechaNacimiento, param.nomina, param.direccion, param.telefonoCasa, param.telefono, param.status, param.FechaIngreso, param.horaderegistro);
                int i = -1;
                _session.Execute(query1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Err = false;
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }

        public bool insert_Clientes(Clientes clients)
        {
            var Err = true;
            try
            {
                conectar();
                var query = "insert into cliente(name,p_lastname,m_lastname, birthdate,email,address,phone_home,phone_personal,rfc,marital_status,references,status,payroll_number, register_date, register_hour)"
                    + "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}', '{13}', '{14}') if not exists; ";
                query = string.Format(query, clients.nombre, clients.apellidoP, clients.apellidoM, clients.fechaNacimiento, clients.correo, clients.direccion,
                    clients.telefonoCasa, clients.telefonoPersonal, clients.rfc, clients.situacionCivil, clients.referencias, "Activo", clients.nomina, clients.FechaIngreso, clients.horaderegistro);
                int i = 1;
                i = 2;
                _session.Execute(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Err = false;
                throw e;
            
            }
            finally
            {
                desconectar();
            }
            return Err;
        }

        public bool UpdateClientes(Clientes param)
        {
            var err = true;
            try
            {
                conectar();
                //Checar si se permite cambair correo
                var query = "update cliente set " +
                    "p_lastname='{0}', m_lastname='{1}', birthdate='{2}'," +
                    "address='{3}', phone_home='{4}', phone_personal='{5}'," +
                    "marital_status='{6}', references='{7}', payroll_number='{8}' where email='{9}' AND name='{10}' AND rfc='{11}' if exists";
                query = string.Format(query, param.apellidoP, param.apellidoM, param.fechaNacimiento, param.direccion
                    , param.telefonoCasa, param.telefonoPersonal, param.situacionCivil, param.referencias, param.nomina, param.correo, param.nombre, param.rfc);
                _session.Execute(query);
            }
            catch (Exception E)
            {
                err = false;
                MessageBox.Show(E.ToString());
                return err;
                throw;
            }
            finally
            {
                desconectar();
            }
            return err;
        }

        public List<Clientes> Obtener_clientes()
        {
            string query = "select name, p_lastname, m_lastname, email, address, birthdate, phone_home, phone_personal, phone_home, rfc, references, marital_status, payroll_number, status from cliente;";
            List<Clientes> lista = new List<Clientes>();
            conectar();
            var ResultSet = _session.Execute(query);
            foreach (var row in ResultSet)
            {
                Clientes clientes = new Clientes();
                clientes.nombre = row.GetValue<string>("name");
                clientes.apellidoP = row.GetValue<string>("p_lastname");
                clientes.apellidoM = row.GetValue<string>("m_lastname");
                clientes.correo = row.GetValue<string>("email");
                clientes.direccion = row.GetValue<string>("address");
                clientes.fechaNacimiento = row.GetValue<object>("birthdate") == null ? "" : row.GetValue<object>("birthdate").ToString();
                clientes.telefonoCasa = row.GetValue<string>("phone_home");
                clientes.telefonoPersonal = row.GetValue<string>("phone_personal");
                clientes.rfc = row.GetValue<string>("rfc");
                clientes.referencias = row.GetValue<string>("references");
                clientes.situacionCivil = row.GetValue<string>("marital_status");
                clientes.nomina = row.GetValue<string>("payroll_number");
                clientes.estado = row.GetValue<string>("status");
                lista.Add(clientes);
            }

            desconectar();
            return lista;

        }

        public List<Clientes> obtClientesNombre(string name)
        {
            string query = "select name, p_lastname, m_lastname, email, address, birthdate, phone_home, phone_personal, phone_home, rfc, references, marital_status, payroll_number, status from cliente where name='{0}' ALLOW FILTERING;";
            query = string.Format(query, name);
            List<Clientes> lista = new List<Clientes>();
            conectar();
            var ResultSet = _session.Execute(query);
            foreach (var row in ResultSet)
            {
                Clientes clientes = new Clientes();
                clientes.nombre = row.GetValue<string>("name");
                clientes.apellidoP = row.GetValue<string>("p_lastname");
                clientes.apellidoM = row.GetValue<string>("m_lastname");
                clientes.correo = row.GetValue<string>("email");
                clientes.direccion = row.GetValue<string>("address");
                clientes.fechaNacimiento = row.GetValue<object>("birthdate") == null ? "" : row.GetValue<object>("birthdate").ToString();
                clientes.telefonoCasa = row.GetValue<string>("phone_home");
                clientes.telefonoPersonal = row.GetValue<string>("phone_personal");
                clientes.rfc = row.GetValue<string>("rfc");
                clientes.referencias = row.GetValue<string>("references");
                clientes.situacionCivil = row.GetValue<string>("marital_status");
                clientes.nomina = row.GetValue<string>("payroll_number");
                clientes.estado = row.GetValue<string>("status");
                lista.Add(clientes);
            }

            desconectar();
            return lista;

        }

        public List<Clientes> obtClientesEmail(string email)
        {
            string query = "select name, p_lastname, m_lastname, email, address, birthdate, phone_home, phone_personal, phone_home, rfc, references, marital_status, payroll_number, status from cliente where email='{0}' ALLOW FILTERING;";
            query = string.Format(query, email);
            List<Clientes> lista = new List<Clientes>();
            conectar();
            var ResultSet = _session.Execute(query);
            foreach (var row in ResultSet)
            {
                Clientes clientes = new Clientes();
                clientes.nombre = row.GetValue<string>("name");
                clientes.apellidoP = row.GetValue<string>("p_lastname");
                clientes.apellidoM = row.GetValue<string>("m_lastname");
                clientes.correo = row.GetValue<string>("email");
                clientes.direccion = row.GetValue<string>("address");
                clientes.fechaNacimiento = row.GetValue<object>("birthdate") == null ? "" : row.GetValue<object>("birthdate").ToString();
                clientes.telefonoCasa = row.GetValue<string>("phone_home");
                clientes.telefonoPersonal = row.GetValue<string>("phone_personal");
                clientes.rfc = row.GetValue<string>("rfc");
                clientes.referencias = row.GetValue<string>("references");
                clientes.situacionCivil = row.GetValue<string>("marital_status");
                clientes.nomina = row.GetValue<string>("payroll_number");
                clientes.estado = row.GetValue<string>("status");
                lista.Add(clientes);
            }

            desconectar();
            return lista;

        }

        public List<Clientes> obtClientesRFC(string rfc)
        {
            string query = "select name, p_lastname, m_lastname, email, address, birthdate, phone_home, phone_personal, phone_home, rfc, references, marital_status, payroll_number, status from cliente where rfc='{0}' ALLOW FILTERING;";
            query = string.Format(query, rfc);
            List<Clientes> lista = new List<Clientes>();
            conectar();
            var ResultSet = _session.Execute(query);
            foreach (var row in ResultSet)
            {
                Clientes clientes = new Clientes();
                clientes.nombre = row.GetValue<string>("name");
                clientes.apellidoP = row.GetValue<string>("p_lastname");
                clientes.apellidoM = row.GetValue<string>("m_lastname");
                clientes.correo = row.GetValue<string>("email");
                clientes.direccion = row.GetValue<string>("address");
                clientes.fechaNacimiento = row.GetValue<object>("birthdate") == null ? "" : row.GetValue<object>("birthdate").ToString();
                clientes.telefonoCasa = row.GetValue<string>("phone_home");
                clientes.telefonoPersonal = row.GetValue<string>("phone_personal");
                clientes.rfc = row.GetValue<string>("rfc");
                clientes.referencias = row.GetValue<string>("references");
                clientes.situacionCivil = row.GetValue<string>("marital_status");
                clientes.nomina = row.GetValue<string>("payroll_number");
                clientes.estado = row.GetValue<string>("status");
                lista.Add(clientes);
            }

            desconectar();
            return lista;

        }

        public bool DeleteClientes(string email, string name, string rfc)
        {
            var Err = true; // SI no hay error
            try
            {
                conectar();
                var query1 = "delete from cliente where email='{0}' AND name='{1}' AND rfc='{2}' if exists";
                query1 = string.Format(query1, email, name, rfc);
                _session.Execute(query1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Err = false;
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }

        public List<Hoteles> Obtener_hoteles()
        {
            string query = "select name, country, city, state, floors_number, rooms_number, turistic_zone, services_add, beach, pool_number, events_room, operations_date, status from hotel;";
            List<Hoteles> lista = new List<Hoteles>();
            conectar();
            var ResultSet = _session.Execute(query);
            foreach (var row in ResultSet)
            {
                Hoteles hotel = new Hoteles();
                hotel.hotel = row.GetValue<string>("name");
                hotel.pais = row.GetValue<string>("country");
                hotel.ciudad = row.GetValue<string>("city");
                hotel.estado = row.GetValue<string>("state");
                hotel.numeroPisos = row.GetValue<string>("floors_number");
                hotel.cantidadHabitaciones = row.GetValue<string>("rooms_number");
                hotel.zonaTuristica = row.GetValue<string>("turistic_zone");
                hotel.serviciosAdicionales = row.GetValue<string>("services_add");
                hotel.frentePlaya = row.GetValue<string>("beach");
                hotel.cantidadPiscinas = row.GetValue<string>("pool_number");
                hotel.salonesEventos = row.GetValue<string>("events_room");
                hotel.inicioOperaciones = row.GetValue<object>("operations_date") == null ? "" : row.GetValue<object>("operations_date").ToString();
                hotel.status = row.GetValue<Nullable<bool>>("status") == null ? false : row.GetValue<bool>("status");
                lista.Add(hotel);
            }

            desconectar();
            return lista;

        }

        public List<Hoteles> obtener_hotel_cb()
        {
            string query = "select name from hotel;";
            List<Hoteles> lista2 = new List<Hoteles>();
            conectar();
            var ResultSet = _session.Execute(query);
            foreach (var row in ResultSet)
            {
                Hoteles hotel = new Hoteles();
                hotel.hotel = row.GetValue<string>("name");
                lista2.Add(hotel);
            }

            desconectar();
            return lista2;

        }

        public bool InsertarHoteles(Hoteles param)
        {
            var Err = true; // SI no hay error
            try
            {
                conectar();
                //Cambie algo en las tablas
                var query1 = "insert into hotel(name, country, city, state, floors_number, rooms_number, " +
                    "turistic_zone, beach, pool_number, events_room, operations_date, services_add, date_register, hour_register, status) " +
                    "values ('{0}' ,'{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}',true) if not exists; ";
                query1 = string.Format(query1, param.hotel, param.pais, param.ciudad, param.estado, param.numeroPisos,
                    param.cantidadHabitaciones, param.zonaTuristica, param.frentePlaya, param.cantidadPiscinas, param.salonesEventos, param.inicioOperaciones, param.serviciosAdicionales,
                    param.FechaRegistro, param.horaderegistro);

                int i = -1;
                _session.Execute(query1);

                var query2 = "insert into buscarciudad (city) values ('{0}') if not exists;";
                query2 = string.Format(query2, param.ciudad);

                _session.Execute(query2);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Err = false;
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }
        public bool UpdateHotel(Hoteles param)
        {
            var err = true;
            try
            {
                conectar();
                var query = "update hotel set " +
                    "country='{0}'," +
                    "state='{1}', floors_number='{2}', rooms_number='{3}'," +
                    "turistic_zone='{4}', beach='{5}', pool_number='{6}', events_room='{7}', operations_date='{8}',services_add='{9}' where name='{10}' AND city='{11}' if exists";
                query = string.Format(query, param.pais, param.estado, param.numeroPisos,
                     param.cantidadHabitaciones, param.zonaTuristica, param.frentePlaya, param.cantidadPiscinas, param.salonesEventos, param.inicioOperaciones, param.serviciosAdicionales, param.hotel, param.ciudad);

                _session.Execute(query);
            }
            catch (Exception E)
            {
                err = false;
                MessageBox.Show(E.ToString());
                return err;
                throw;
            }
            finally
            {
                desconectar();
            }
            return err;
        }

        public bool DeleteHotel(string nombre, string ciudad)
        {
            var err = true;
            try
            {
                conectar();
                var query = "update hotel set " +
                    "status=false where name='{0}' AND city='{1}' if exists";
                query = string.Format(query, nombre, ciudad);

                _session.Execute(query);
            }
            catch (Exception E)
            {
                err = false;
                MessageBox.Show(E.ToString());
                return err;
                throw;
            }
            finally
            {
                desconectar();
            }
            return err;
        }

        public bool InsertarHabitaciones(Habitaciones param)
        {
            var Err = true; // SI no hay error
            try
            {
                conectar();
                var query1 = "insert into habitacion(hotel, type, beds_number, beds_type, price, people_number, " +
                    "room_level, frontof, details, amenities, date_register, hour_register ,status) " +
                    "values ('{0}' ,'{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', true) if not exists; ";
                query1 = string.Format(query1, param.hotel, param.tipoHabitacion, param.numeroCamas, param.tiposCama, param.precioPorNoche,
                                        param.cantidadPersonas, param.nivelHabitacion, param.frenteA, param.caracteristicas, param.amenidades, param.FechaRegistro, param.horaderegistro);
                int i = -1;
                _session.Execute(query1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Err = false;
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }

        public bool UpdateHabitaciones(Habitaciones param)
        {
            var err = true;
            try
            {
                conectar();
                var query = "update habitacion set " +
                    "beds_number='{0}'," +
                    "beds_type='{1}', price='{2}', people_number='{3}'," +
                    "room_level='{4}', frontof='{5}', details='{6}', amenities='{7}' where type='{8}' AND hotel='{9}' if exists";
                query = string.Format(query, param.numeroCamas, param.tiposCama, param.precioPorNoche,
                     param.cantidadPersonas, param.nivelHabitacion, param.frenteA, param.caracteristicas, param.amenidades, param.tipoHabitacion, param.hotel);

                _session.Execute(query);
            }
            catch (Exception E)
            {
                err = false;
                MessageBox.Show(E.ToString());
                return err;
                throw;
            }
            finally
            {
                desconectar();
            }
            return err;
        }

        public bool DeleteHabitaciones(string tipo, string hotel)
        {
            var Err = true; // SI no hay error
            try
            {
                conectar();
                var query1 = "delete from habitacion where type='{0}' AND hotel='{1}' if exists";
                query1 = string.Format(query1, tipo, hotel);
                _session.Execute(query1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Err = false;
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }

        public List<Habitaciones> Obtener_habitaciones()
        {
            string query = "select hotel, type, beds_number, beds_type, price, people_number, room_level, frontof, details, amenities, status from habitacion;";
            List<Habitaciones> lista = new List<Habitaciones>();
            conectar();
            var ResultSet = _session.Execute(query);
            foreach (var row in ResultSet)
            {
                Habitaciones habitacion = new Habitaciones();
                habitacion.hotel = row.GetValue<string>("hotel");
                habitacion.tipoHabitacion = row.GetValue<string>("type");
                habitacion.numeroCamas = row.GetValue<string>("beds_number");
                habitacion.tiposCama = row.GetValue<string>("beds_type");
                habitacion.precioPorNoche = row.GetValue<string>("price");
                habitacion.cantidadPersonas = row.GetValue<string>("people_number");
                habitacion.nivelHabitacion = row.GetValue<string>("room_level");
                habitacion.frenteA = row.GetValue<string>("frontof");
                habitacion.caracteristicas = row.GetValue<string>("details");
                habitacion.amenidades = row.GetValue<string>("amenities");
                habitacion.estatus = row.GetValue<Nullable<bool>>("status") == null ? false : row.GetValue<bool>("status");
                lista.Add(habitacion);
            }

            desconectar();
            return lista;

        }

        public List<Hoteles> obtener_ciudad_cb()
        {
            string query = "select city from buscarciudad;";
            List<Hoteles> lista2 = new List<Hoteles>();
            conectar();
            var ResultSet = _session.Execute(query);
            foreach (var row in ResultSet)
            {
                Hoteles hotel = new Hoteles();
                hotel.ciudad = row.GetValue<string>("city");
                lista2.Add(hotel);
            }

            desconectar();
            return lista2;

        }

        public List<Hoteles> obtHotelesCiudad(string ciudad)
        {
            string query = "select name, country, city, state, floors_number, rooms_number, turistic_zone, services_add, beach, pool_number, events_room, operations_date, status from hotel where city='{0}' ALLOW FILTERING;";
            query = string.Format(query, ciudad);
            List<Hoteles> lista = new List<Hoteles>();
            conectar();
            var ResultSet = _session.Execute(query);
            foreach (var row in ResultSet)
            {
                Hoteles hotel = new Hoteles();
                hotel.hotel = row.GetValue<string>("name");
                hotel.pais = row.GetValue<string>("country");
                hotel.ciudad = row.GetValue<string>("city");
                hotel.estado = row.GetValue<string>("state");
                hotel.numeroPisos = row.GetValue<string>("floors_number");
                hotel.cantidadHabitaciones = row.GetValue<string>("rooms_number");
                hotel.zonaTuristica = row.GetValue<string>("turistic_zone");
                hotel.serviciosAdicionales = row.GetValue<string>("services_add");
                hotel.frentePlaya = row.GetValue<string>("beach");
                hotel.cantidadPiscinas = row.GetValue<string>("pool_number");
                hotel.salonesEventos = row.GetValue<string>("events_room");
                hotel.inicioOperaciones = row.GetValue<object>("operations_date") == null ? "" : row.GetValue<object>("operations_date").ToString();
                hotel.status = row.GetValue<Nullable<bool>>("status") == null ? false : row.GetValue<bool>("status");
                lista.Add(hotel);
            }

            desconectar();
            return lista;

        }

        public List<Habitaciones> obtHabitacionesHotel(string hotel)
        {
            string query = "select hotel, type, beds_number, beds_type, price, people_number, room_level, frontof, details, amenities, status from habitacion where hotel='{0}' ALLOW FILTERING;";
            query = string.Format(query, hotel);
            List<Habitaciones> lista = new List<Habitaciones>();
            conectar();
            var ResultSet = _session.Execute(query);
            foreach (var row in ResultSet)
            {
                Habitaciones habitacion = new Habitaciones();
                habitacion.hotel = row.GetValue<string>("hotel");
                habitacion.tipoHabitacion = row.GetValue<string>("type");
                habitacion.numeroCamas = row.GetValue<string>("beds_number");
                habitacion.tiposCama = row.GetValue<string>("beds_type");
                habitacion.precioPorNoche = row.GetValue<string>("price");
                habitacion.cantidadPersonas = row.GetValue<string>("people_number");
                habitacion.nivelHabitacion = row.GetValue<string>("room_level");
                habitacion.frenteA = row.GetValue<string>("frontof");
                habitacion.caracteristicas = row.GetValue<string>("details");
                habitacion.amenidades = row.GetValue<string>("amenities");
                habitacion.estatus = row.GetValue<Nullable<bool>>("status") == null ? false : row.GetValue<bool>("status");
                lista.Add(habitacion);
            }

            desconectar();
            return lista;

        }

        public bool InsertarHabitacionesTemporales(HabitacionesTemporales param)
        {
            var Err = true; // SI no hay error
            try
            {
                conectar();
                var query1 = "insert into habitacionTemporal(hotel, type, beds_number, beds_type, price, people_number, " +
                    "room_level, frontof, details, amenities, cant_pers_soli, date_in, date_out, status) " +
                    "values ('{0}' ,'{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', true) if not exists; ";
                query1 = string.Format(query1, param.hotel, param.tipoHabitacion, param.numeroCamas, param.tiposCama, param.precioPorNoche,
                                        param.cantidadPersonas, param.nivelHabitacion, param.frenteA, param.caracteristicas, param.amenidades, param.cantidadPersonasSolicitada, 
                                        param.fechaEntrada, param.fechaSalida);
                int i = -1;
                _session.Execute(query1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Err = false;
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }

        public List<HabitacionesTemporales> Obtener_habitacionesTemporales()
        {
            string query = "select hotel, type, beds_number, beds_type, price, people_number, room_level, frontof, details, amenities, status, date_in, date_out, cant_pers_soli from habitacionTemporal;";
            List<HabitacionesTemporales> lista = new List<HabitacionesTemporales>();
            conectar();
            var ResultSet = _session.Execute(query);
            foreach (var row in ResultSet)
            {
                HabitacionesTemporales habitacion = new HabitacionesTemporales();
                habitacion.hotel = row.GetValue<string>("hotel");
                habitacion.tipoHabitacion = row.GetValue<string>("type");
                habitacion.numeroCamas = row.GetValue<string>("beds_number");
                habitacion.tiposCama = row.GetValue<string>("beds_type");
                habitacion.precioPorNoche = row.GetValue<string>("price");
                habitacion.cantidadPersonas = row.GetValue<string>("people_number");
                habitacion.nivelHabitacion = row.GetValue<string>("room_level");
                habitacion.frenteA = row.GetValue<string>("frontof");
                habitacion.caracteristicas = row.GetValue<string>("details");
                habitacion.amenidades = row.GetValue<string>("amenities");
                habitacion.estatus = row.GetValue<Nullable<bool>>("status") == null ? false : row.GetValue<bool>("status");
                habitacion.fechaEntrada = row.GetValue<object>("date_in") == null ? "" : row.GetValue<object>("date_in").ToString();
                habitacion.fechaSalida = row.GetValue<object>("date_out") == null ? "" : row.GetValue<object>("date_out").ToString();
                habitacion.cantidadPersonasSolicitada = row.GetValue<string>("cant_pers_soli");
                lista.Add(habitacion);
            }

            desconectar();
            return lista;

        }

        public bool limpiarHabitacionTemporal()
        {
            var Err = true; // SI no hay error
            try
            {
                conectar();
                var query1 = "truncate habitacionTemporal;";
                int i = -1;
                _session.Execute(query1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Err = false;
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }

        public bool InsertarReservaciones(Reservaciones param)
        {
            var Err = true; // SI no hay error
            try
            {
                conectar();
                var query1 = "insert into reserva(id_reserva, client_name, p_lastname, m_lastname, hotel, city, " +
                    "init_date, end_date, check_in, check_out, payment_method_a, advance_payment , date_register, hour_register, user_register, email_client, status_reserva) " +
                    "values ('{0}' ,'{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', {8}, {9}, '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', {16}) if not exists; ";
                query1 = string.Format(query1, param.codigo, param.nombreCliente, param.apellidoPCliente, param.apellidoMCliente, param.hotel, param.ciudad,
                                        param.fechaInicial, param.fechaFinal, param.checkIn, param.checkOut, param.metodoDePago, param.anticipo, param.fechaDeRegistro, param.horaDeRegistro,
                                        param.usuarioRegistro, param.correoCliente, param.EstatusReservacion);
                int i = -1;
                _session.Execute(query1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Err = false;
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }

        public bool InsertarReservacionesDetalle(Reservaciones param)
        {
            var Err = true; // SI no hay error
            try
            {
                conectar();
                var query1 = "insert into reserva_detalle(room2, people_number2, price2, " +
                    " id_reserva2) " +
                    "values ('{0}' ,'{1}', '{2}', '{3}') if not exists; ";
                query1 = string.Format(query1, param.habitacion, param.cantidadPersonas, param.precio, param.codigo);
                int i = -1;
                _session.Execute(query1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Err = false;
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }

        public List<Reservaciones> Obtener_reservaciones(string code)
        {
            string query = "select id_reserva, client_name, p_lastname, m_lastname, hotel, city, init_date, end_date, check_in, check_out, payment_method_a, advance_payment, date_register, hour_register, user_register from reserva where id_reserva='{0}' ALLOW FILTERING;";
            query = string.Format(query, code);
            List<Reservaciones> lista = new List<Reservaciones>();
            conectar();
            var ResultSet = _session.Execute(query);
            foreach (var row in ResultSet)
            {
                Reservaciones reservacion = new Reservaciones();
                reservacion.codigo = row.GetValue<string>("id_reserva");
                reservacion.nombreCliente = row.GetValue<string>("client_name");
                reservacion.apellidoPCliente = row.GetValue<string>("p_lastname");
                reservacion.apellidoMCliente = row.GetValue<string>("m_lastname");
                reservacion.hotel = row.GetValue<string>("hotel");
                reservacion.ciudad = row.GetValue<string>("city");
                reservacion.fechaInicial = row.GetValue<object>("init_date") == null ? "" : row.GetValue<object>("init_date").ToString();
                reservacion.fechaFinal = row.GetValue<object>("end_date") == null ? "" : row.GetValue<object>("end_date").ToString();
                reservacion.checkIn = row.GetValue<Nullable<bool>>("check_in") == null ? false : row.GetValue<bool>("check_in");
                reservacion.checkOut = row.GetValue<Nullable<bool>>("check_out") == null ? false : row.GetValue<bool>("check_out");
                reservacion.metodoDePago = row.GetValue<string>("payment_method_a");
                reservacion.anticipo = row.GetValue<string>("advance_payment");
                reservacion.fechaDeRegistro = row.GetValue<object>("date_register") == null ? "" : row.GetValue<object>("date_register").ToString();
                reservacion.horaDeRegistro = row.GetValue<string>("hour_register");
                reservacion.usuarioRegistro = row.GetValue<string>("user_register");
                lista.Add(reservacion);
            }

            desconectar();
            return lista;

        }

        public bool incrementarContadorCancelacion()
        {
            var Err = true; // SI no hay error
            try
            {
                conectar();
                var query1 = "update contadorcancel set cont = cont + 1 WHERE nombre = 'mi_contador'";
                query1 = string.Format(query1);
                int i = -1;
                _session.Execute(query1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Err = false;
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }

        public string obtenerContadorCancelacion()
        {
            string nuevoValor;
            var Err = true; // SI no hay error
            try
            {
                conectar();
                var query1 = "select cont from contadorcancel where nombre = 'mi_contador'";
                query1 = string.Format(query1);
                int i = -1;
                var result = _session.Execute(query1);
                nuevoValor = result.First().GetValue<long>("cont").ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Err = false;
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return nuevoValor;
        }

        public bool InsertarCancelacion(Cancelaciones param)
        {
            var Err = true; // SI no hay error
            try
            {
                conectar();
                var query1 = "insert into cancelaciones(id_cancellations, codigo_reservation, date_cancellation, " +
                    " hour_cancellation, user_cancellation) " +
                    "values ('{0}' ,'{1}', '{2}', '{3}', '{4}') if not exists; ";
                query1 = string.Format(query1, param.idCancelaciones, param.codigoRe, param.fechaCancelacion, param.horaCancelacion, param.usuarioCancelacion);
                int i = -1;
                _session.Execute(query1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Err = false;
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }

        public bool Delete_Reservacion(string codigo)
        {
            var Err = true; // SI no hay error
            try
            {
                conectar();
                var query1 = "delete from reserva where id_reserva='{0}' if exists";
                query1 = string.Format(query1, codigo);
                _session.Execute(query1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Err = false;
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }

        public bool Delete_ReservacionDetalle(string codigo, string habitacion)
        {
            var Err = true; // SI no hay error
            try
            {
                conectar();
                var query1 = "delete from reserva_detalle where id_reserva2='{0}' AND room2='{1}' if exists";
                query1 = string.Format(query1, codigo, habitacion);
                _session.Execute(query1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Err = false;
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }

        public List<ReservacionesDetalle> Obtener_reservacionesDetalle(string code)
        {
            string query = "select room2, people_number2, price2, id_reserva2 from reserva_detalle where id_reserva2='{0}' ALLOW FILTERING;";
            query = string.Format(query, code);
            List<ReservacionesDetalle> lista = new List<ReservacionesDetalle>();
            conectar();
            var ResultSet = _session.Execute(query);
            foreach (var row in ResultSet)
            {
                ReservacionesDetalle reservacion = new ReservacionesDetalle();
                reservacion.Cuarto = row.GetValue<string>("room2");
                reservacion.Personas = row.GetValue<string>("people_number2");
                reservacion.Costo = row.GetValue<string>("price2");
                reservacion.Id = row.GetValue<string>("id_reserva2");
                lista.Add(reservacion);
            }

            desconectar();
            return lista;

        }

        public bool reservacionCheckIn(Reservaciones param)
        {
            var err = true;
            try
            {
                conectar();
                var query = "update reserva set check_in={0}, date_checkin='{1}' where id_reserva='{2}' if exists";
                query = string.Format(query, param.checkIn, param.fechaCheckIn, param.codigo);

                _session.Execute(query);
            }
            catch (Exception E)
            {
                err = false;
                MessageBox.Show(E.ToString());
                return err;
                throw;
            }
            finally
            {
                desconectar();
            }
            return err;
        }

        public List<Servicios> Obtener_servicios()
        {
            string query = "select service, price_service from servicios_adicionales;";
            List<Servicios> lista = new List<Servicios>();
            conectar();
            var ResultSet = _session.Execute(query);
            foreach (var row in ResultSet)
            {
                Servicios serviciosA = new Servicios();
                serviciosA.Servicio = row.GetValue<string>("service");
                serviciosA.PrecioDeServicio = row.GetValue<string>("price_service");
                lista.Add(serviciosA);
            }

            desconectar();
            return lista;

        }

        public List<Servicios> Obtener_serviciosTemp()
        {
            string query = "select service, price_service from servicios_temporales;";
            List<Servicios> lista = new List<Servicios>();
            conectar();
            var ResultSet = _session.Execute(query);
            foreach (var row in ResultSet)
            {
                Servicios serviciosA = new Servicios();
                serviciosA.Servicio = row.GetValue<string>("service");
                serviciosA.PrecioDeServicio = row.GetValue<string>("price_service");
                lista.Add(serviciosA);
            }

            desconectar();
            return lista;

        }

        public bool InsertarServiciosTemporales(Servicios param)
        {
            var Err = true; // SI no hay error
            try
            {
                conectar();
                var query1 = "insert into servicios_temporales(service, price_service) " +
                    "values ('{0}' ,'{1}') if not exists; ";
                query1 = string.Format(query1, param.Servicio, param.PrecioDeServicio);
                int i = -1;
                _session.Execute(query1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Err = false;
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }

        public bool limpiarServiciosTemporal()
        {
            var Err = true; // SI no hay error
            try
            {
                conectar();
                var query1 = "truncate servicios_temporales;";
                int i = -1;
                _session.Execute(query1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Err = false;
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }

        public bool InsertarVentas(Ventas param)
        {
            var Err = true; // SI no hay error
            try
            {
                conectar();
                var query1 = "insert into reporteventas(id_venta, name, city, " +
                    " country, date_, lodging, services, total) " +
                    "values ('{0}' ,'{1}', '{2}', '{3}', '{4}', {5}, {6}, {7}) if not exists; ";
                query1 = string.Format(query1, param.idVentas, param.nombreHotel, param.ciudad, param.pais, param.fecha, param.IngresosPorHospedaje, param.IngresosPorServicios,
                                        param.IngresosTotales);
                int i = -1;
                _session.Execute(query1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Err = false;
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }

        public List<Hoteles> Obtener_hotelesPais(string nombre)
        {
            string query = "select name, country, city, state, floors_number, rooms_number, turistic_zone, services_add, beach, pool_number, events_room, operations_date, status from hotel where name='{0}' ALLOW FILTERING;";
            query = string.Format(query, nombre);
            List<Hoteles> lista = new List<Hoteles>();
            conectar();
            var ResultSet = _session.Execute(query);
            foreach (var row in ResultSet)
            {
                Hoteles hotel = new Hoteles();
                hotel.hotel = row.GetValue<string>("name");
                hotel.pais = row.GetValue<string>("country");
                hotel.ciudad = row.GetValue<string>("city");
                hotel.estado = row.GetValue<string>("state");
                hotel.numeroPisos = row.GetValue<string>("floors_number");
                hotel.cantidadHabitaciones = row.GetValue<string>("rooms_number");
                hotel.zonaTuristica = row.GetValue<string>("turistic_zone");
                hotel.serviciosAdicionales = row.GetValue<string>("services_add");
                hotel.frentePlaya = row.GetValue<string>("beach");
                hotel.cantidadPiscinas = row.GetValue<string>("pool_number");
                hotel.salonesEventos = row.GetValue<string>("events_room");
                hotel.inicioOperaciones = row.GetValue<object>("operations_date") == null ? "" : row.GetValue<object>("operations_date").ToString();
                hotel.status = row.GetValue<Nullable<bool>>("status") == null ? false : row.GetValue<bool>("status");
                lista.Add(hotel);
            }

            desconectar();
            return lista;

        }

        public List<Ventas> obtReporteVentasNombre(string nombre)
        {
            string query = "select name, city, country, date_, SUM(lodging), SUM(services), SUM(total) from reporteventas where name='{0}' ALLOW FILTERING;";
            query = string.Format(query, nombre);
            List<Ventas> lista = new List<Ventas>();
            conectar();
            var ResultSet = _session.Execute(query);
            foreach (var row in ResultSet)
            {
                Ventas venta = new Ventas();
                venta.nombreHotel = row.GetValue<string>("name");
                venta.ciudad = row.GetValue<string>("city");
                venta.pais = row.GetValue<string>("country");
                venta.fecha = row.GetValue<object>("date_") == null ? "" : row.GetValue<object>("date_").ToString();
                venta.IngresosPorHospedaje = (float)row.GetValue<float>(4);
                venta.IngresosPorServicios = (float)row.GetValue<float>(5);
                venta.IngresosTotales = (float)row.GetValue<float>(6);
                lista.Add(venta);
            }

            desconectar();
            return lista;

        }

        public List<Ventas> obtReporteVentasCiudad(string ciudad)
        {
            string query = "select name, city, country, date_, SUM(lodging), SUM(services), SUM(total) from reporteventas where city='{0}' ALLOW FILTERING;";
            query = string.Format(query, ciudad);
            List<Ventas> lista = new List<Ventas>();
            conectar();
            var ResultSet = _session.Execute(query);
            foreach (var row in ResultSet)
            {
                Ventas venta = new Ventas();
                venta.nombreHotel = row.GetValue<string>("name");
                venta.ciudad = row.GetValue<string>("city");
                venta.pais = row.GetValue<string>("country");
                venta.fecha = row.GetValue<object>("date_") == null ? "" : row.GetValue<object>("date_").ToString();
                venta.IngresosPorHospedaje = (float)row.GetValue<float>(4);
                venta.IngresosPorServicios = (float)row.GetValue<float>(5);
                venta.IngresosTotales = (float)row.GetValue<float>(6);
                lista.Add(venta);
            }

            desconectar();
            return lista;

        }

        public List<Ventas> obtReporteVentasPais(string pais)
        {
            string query = "select name, city, country, date_, SUM(lodging), SUM(services), SUM(total) from reporteventas where country='{0}' ALLOW FILTERING;";
            query = string.Format(query, pais);
            List<Ventas> lista = new List<Ventas>();
            conectar();
            var ResultSet = _session.Execute(query);
            foreach (var row in ResultSet)
            {
                Ventas venta = new Ventas();
                venta.nombreHotel = row.GetValue<string>("name");
                venta.ciudad = row.GetValue<string>("city");
                venta.pais = row.GetValue<string>("country");
                venta.fecha = row.GetValue<object>("date_") == null ? "" : row.GetValue<object>("date_").ToString();
                venta.IngresosPorHospedaje = (float)row.GetValue<float>(4);
                venta.IngresosPorServicios = (float)row.GetValue<float>(5);
                venta.IngresosTotales = (float)row.GetValue<float>(6);
                lista.Add(venta);
            }

            desconectar();
            return lista;

        }

        public List<Ventas> obtReporteVentasAnio(string anio)
        {
            string query = "select name, city, country, date_, SUM(lodging), SUM(services), SUM(total) from reporteventas where date_='{0}' ALLOW FILTERING;";
            query = string.Format(query, anio);
            List<Ventas> lista = new List<Ventas>();
            conectar();
            var ResultSet = _session.Execute(query);
            foreach (var row in ResultSet)
            {
                Ventas venta = new Ventas();
                venta.nombreHotel = row.GetValue<string>("name");
                venta.ciudad = row.GetValue<string>("city");
                venta.pais = row.GetValue<string>("country");
                venta.fecha = row.GetValue<object>("date_") == null ? "" : row.GetValue<object>("date_").ToString();
                venta.IngresosPorHospedaje = (float)row.GetValue<float>(4);
                venta.IngresosPorServicios = (float)row.GetValue<float>(5);
                venta.IngresosTotales = (float)row.GetValue<float>(6);
                lista.Add(venta);
            }

            desconectar();
            return lista;

        }

        public bool InsertarHistorial(Historial param)
        {
            var Err = true; // SI no hay error
            try
            {
                conectar();
                var query1 = "insert into historialcliente(id_historial, name_customer, lastp_customer, " +
                    " lastm_customer, city, hotel, type_room, people_number, code_reservation, date_reservation, date_checkin, date_checkout, status_reservation, advance_pay, lodging, services, total) " +
                    "values ('{0}' ,'{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', {12}, {13}, {14}, {15}, {16}) if not exists; ";
                query1 = string.Format(query1, param.idHistorial, param.nombreCliente, param.apellidoPCliente, param.apellidoMCliente, param.ciudad, param.hotel, param.tipoHabitacion,
                                        param.cantidadPersonas, param.codigoReservacion, param.fechaReservacion, param.fechaCheckIn, param.fechaCheckOut, param.estatusReservacion,
                                        param.anticipo, param.hospedaje, param.servicios, param.total);
                int i = -1;
                _session.Execute(query1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                Err = false;
                throw e;
            }
            finally
            {
                // desconectar o cerrar la conexión
                desconectar();

            }
            return Err;
        }
    }
}
