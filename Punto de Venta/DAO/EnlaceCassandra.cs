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
            string query = "select name, password, email, p_lastname, m_lastname, birthdate, payroll_number, address, phone_home, phone_personal, status, date_register, time_register from usuario;";
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
                usuarios.FechaIngreso = row.GetValue<object>("date_register") == null ? "" : row.GetValue<object>("date_register").ToString();
                usuarios.horaderegistro = row.GetValue<string>("time_register");
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

                var query1 = "insert into usuario(name, password, email, p_lastname, m_lastname, birthdate, payroll_number, address, phone_home, phone_personal, status, date_register, time_register) values ('{0}' ,'{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', {10}, '{11}', '{12}') if not exists; ";
                query1 = string.Format(query1, param.nombre, param.contrasena, param.correo, param.apellidoP, param.apellidoM, param.FechaNacimiento, param.nomina, param.direccion, param.telefonoCasa, param.telefono, param.status, param.FechaIngreso, param.horaderegistro);
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
                var query = "insert into cliente(name,p_lastname,m_lastname, birthdate,email,address,phone_home,phone_personal,rfc,marital_status,references,status)"
                    + "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}'); ";
                query = string.Format(query, clients.nombre, clients.apellidoP, clients.apellidoM, clients.fechaNacimiento, clients.correo, clients.direccion, clients.telefonoCasa, clients.telefonoPersonal, clients.rfc, clients.situacionCivil, clients.referencias, "Activo");
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


        //public bool InsertUsers(users param)
        //{
        //    var Err = false; // SI no hay error
        //    try
        //    {
        //        conectar();
        //        var fecha = param.f_nac.ToString("yyyy-MM-dd");
        //        var id = new Guid();
        //        id = Guid.NewGuid();

        //        var query = "BEGIN BATCH ";
        //        var query1 = "insert into users(id, name, email, f_nac) values({0}, '{1}', '{2}', '{3}'); ";
        //        query1 = string.Format(query1, id, param.name, param.email, fecha);
        //        var query2 = "insert into users2(id, name, email) values({0}, '{1}', '{2}'); ";
        //        query2 = string.Format(query2, id, param.name, param.email);
        //        query = query + query1 + query2 + " APPLY BATCH;";

        //        _session.Execute(query);
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //        Err = true;
        //        throw e;
        //    }
        //    finally
        //    {
        //        // desconectar o cerrar la conexión
        //        desconectar();

        //    }
        //    return Err;
        //}

        //public bool InsertClientes(clientes param)
        //{
        //    var Err = false; // SI no hay error
        //    try
        //    {
        //        conectar();

        //        var query1 = "insert into clientes(user_id, first_name, last_name) values('{0}', '{1}', '{2}'); ";
        //        query1 = string.Format(query1, param.user_id, param.first_name, param.last_name);

        //        _session.Execute(query1);
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //        Err = true;
        //        throw e;
        //    }
        //    finally
        //    {
        //        // desconectar o cerrar la conexión
        //        desconectar();

        //    }
        //    return Err;
        //}

        //public bool UpdateClientes(clientes param, int accion)
        //{
        //    var Err = false; // SI no hay error
        //    var oper = "+";
        //    if(accion == 0) { oper = "-"; }
        //    try
        //    {
        //        conectar();

        //        var query1 = "update clientes ";
        //        query1 += "set ";
        //        if (accion == 1)
        //        {
        //            query1 += "    first_name = '{1}', ";
        //            query1 += "    last_name = '{2}', ";
        //        }
        //        query1 += "    emails = emails " + oper +" ['{3}'] ";
        //        query1 += " where user_id =  '{0}' ";
        //        query1 += " IF EXISTS; ";
        //        query1 = string.Format(query1, param.user_id, param.first_name, param.last_name, param.emails);

        //        _session.Execute(query1);
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //        Err = true;
        //        throw e;
        //    }
        //    finally
        //    {
        //        // desconectar o cerrar la conexión
        //        desconectar();

        //    }
        //    return Err;
        //}

        //public List<clientes1> Get_Clientes(string user_id)
        //{
        //    string query = "select user_id, first_name, last_name, emails ";
        //    query += "from clientes ";
        //    query += "where user_id = '{0}'; ";
        //    query = string.Format(query, user_id);
        //    conectar();

        //    IMapper mapper = new Mapper(_session);
        //    IEnumerable<clientes1> ctes = mapper.Fetch<clientes1>(query);

        //    desconectar();
        //    return ctes.ToList();

        //}

        //public void InsertaDatos(int id, string dato)
        //{
        //    try
        //    {
        //        conectar();

        //        string qry = "insert into ejemplo(campo1, campo2) values(";
        //        qry = qry + id.ToString();
        //        qry = qry + ",'";
        //        qry = qry + dato;
        //        qry = qry + "');";


        //        string query = "insert into ejemplo(campo1, campo2) values({0}, '{1}');";
        //        qry = string.Format(query, id, dato);

        //        _session.Execute(qry);
        //    }
        //    catch(Exception e)
        //    {
        //        throw e;   
        //    }
        //    finally
        //    {
        //        // desconectar o cerrar la conexión
        //        desconectar();
        //    }
        //}

        //public IEnumerable<Ejemplo> Get_One(int dato)
        //{
        //    string query = "SELECT campo1, campo2 FROM ejemplo WHERE campo1 = ?;";
        //    conectar();
        //    IMapper mapper = new Mapper(_session);
        //    IEnumerable<Ejemplo> users = mapper.Fetch<Ejemplo>(query, dato);

        //    desconectar();
        //    return users.ToList();
        //}

        //public List<Ejemplo> Get_All()
        //{
        //    string query = "SELECT campo1, campo2 FROM ejemplo;";
        //    conectar();

        //    IMapper mapper = new Mapper(_session);
        //    IEnumerable<Ejemplo> users = mapper.Fetch<Ejemplo>(query);

        //    desconectar();
        //    return users.ToList();

        //}

        //// Ejemplo de leer row x row
        //public void GetOne()
        //{
        //    conectar();

        //    string query = "SELECT name, email FROM users;";

        //    // Execute a query on a connection synchronously 
        //    var rs = _session.Execute(query);

        //    // Iterate through the RowSet 
        //    foreach (var row in rs)
        //    {
        //        var value = row.GetValue<string>("name");
        //        // Do something with the value 
        //        var texto = row.GetValue<string>("email");
        //        // Do something with the value 

        //        MessageBox.Show(texto, value.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        //        /*
        //        RowSet rsUsers = session.Execute(qry);

        //        ////////////////////////////////////////////////
        //        var users = new List<UserModel>();
        //        foreach (var userRow in rsUsers)
        //        {
        //            //users.Add(ReflectionTools.GetSingleEntryDynamicFromReader<UserModel>(userRow));
        //        }

        //        foreach (UserModel user in users)
        //        {
        //            Console.WriteLine("{0} {1} {2} {3} {4}", user.Id, user.FirstName, user.LastName, user.Country, user.IsActive);
        //        }
        //        */

        //    }
        //}

    }
}
