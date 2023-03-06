using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;

namespace Punto_de_Venta
{
    class Procedures
    {
        private ConexionSqlServer conexion = new ConexionSqlServer();
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader leerFilas;
        public DataTable GetUsers()
        {
            DataTable tablita = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SelectUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            tablita.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return tablita;
        }

        public bool BorrarEmpleados(int id)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();

                SqlCommand cmd = new SqlCommand("BorrarEmpleados", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
            return true;
        }
        public bool ActualizarUsuarios(int id, string Nombre, string ApellidoP, string ApellidoM, string ClaveU, string Contra, string CURP, string Correo,
            DateTime FechaNac, DateTime FechaIngreso, int nomina)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();

                SqlCommand cmd = new SqlCommand("ActualizarEmpleados", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id",id);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@ApellidoP", ApellidoP);
                cmd.Parameters.AddWithValue("@ApellidoM", ApellidoM);
                cmd.Parameters.AddWithValue("@ClaveU", ClaveU);
                cmd.Parameters.AddWithValue("@Contra", Contra);
                cmd.Parameters.AddWithValue("@FechaNac", FechaNac);
                cmd.Parameters.AddWithValue("@FechaIng", FechaIngreso);
                cmd.Parameters.AddWithValue("@Curp", CURP);
                cmd.Parameters.AddWithValue("@Correo", Correo);
                cmd.Parameters.AddWithValue("@Nomina", nomina);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return false;
            }
            return true;
        }

        public bool Login(string user, string password, string puesto)
        {

            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();

                SqlCommand cmd = new SqlCommand("SelectUsuarios", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClaveU", user);
                cmd.Parameters.AddWithValue("@Contraseña", password);
                cmd.Parameters.AddWithValue("@TipoU", puesto);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }

        public DataTable ListarCajero()
        {
            DataTable grid = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarEmpleados";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            grid.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return grid;
        }

        public bool InsertarEmpleados(string Nombre, string ApellidoPaterno, string ApellidoM, string claveU, string Contra,
            DateTime fechaNac, DateTime FechaIngreso, string curp, string email, int Nomina)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();
                SqlCommand cmd = new SqlCommand("sp_InsertarEmpleado", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@ApellidoP", ApellidoPaterno);
                cmd.Parameters.AddWithValue("@ApellidoM", ApellidoM);
                cmd.Parameters.AddWithValue("@FechaNac", fechaNac);
                cmd.Parameters.AddWithValue("@NumeroNomina", Nomina);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@CURP", curp.ToCharArray());
                cmd.Parameters.AddWithValue("@FechaIngreso", FechaIngreso);
                cmd.Parameters.AddWithValue("@ClaveUsuario", claveU);
                cmd.Parameters.AddWithValue("@Contraseña", Contra);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception ye)
            {
                MessageBox.Show("No puede haber claves repetidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool AltaDepartamentos(string NombreDepartamento, int claveDepartamento, string Devolucion)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
             try
            {
                int idAdmin = 1;
                conectado = conn.AbrirConexion();
                SqlCommand cmd = new SqlCommand("InsertarDepartamentos", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreDepa",NombreDepartamento);
                cmd.Parameters.AddWithValue("@IdDepa", claveDepartamento);
                cmd.Parameters.AddWithValue("@Devolucion", Devolucion);
                cmd.Parameters.AddWithValue("@IdAdmin", idAdmin);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception err)
            {
                MessageBox.Show("No puede haber claves repetidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool LoginAdministrador(string user, string password, string tipo)
        {
            
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();
                
                SqlCommand cmd = new SqlCommand("ObtenerAdministradores", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ClaveU", user);
                cmd.Parameters.AddWithValue("@Contra", password);
                //Cambiar el tipo de U a int, si jalaba solo era yo de pendejo 
                cmd.Parameters.AddWithValue("@TipoU", tipo);

                SqlDataReader readerAdmin = cmd.ExecuteReader();

                if (readerAdmin.HasRows)
                {
                    return true;
                }
                else
                    return false;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                return false;
            }
            finally
            {
                conexion.CerrarConexion();
            }
            //return true;
        }


        //public DataTable ListarProductos() 
        //{
        //      DataTable Datagrid = new DataTable();
        //      comando.Connection = conexion.AbrirConexion();
        //      comando.CommandText = ""; 
        //      conexion.CerrarConexion();
        //      return Datagrid;
             
        //}

        public DataTable ListarDepartamentos()
        {
            DataTable grid = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "LeerDepartamentos";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            grid.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return grid;
        }

        public DataTable ListarCarrito()
        {
            DataTable grid = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarCarrito";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            grid.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return grid;
        }

        public DataTable ListarCarritoCompraPagar()
        {
            DataTable grid = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarParaPagar";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            grid.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return grid;
        }

        public bool ActualizarDepartamentos(string Nombre, string Devolucion, int idDepa)
        { 
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();

                SqlCommand cmd = new SqlCommand("ActualizarDepartamentos", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@Devolucion", Devolucion);
                cmd.Parameters.AddWithValue("@IdDepa", idDepa);
               
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception error)
            {

                MessageBox.Show("No puede haber claves repetidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool BorrarDepartamentos(int idDepa)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();

                SqlCommand cmd = new SqlCommand("BorrarDepartamentos", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdCaja", idDepa);
            
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return false;
            }
            return true;
        }

        public bool ActualizarProductos(int ID, string NombreProd, string descripcion, int uMedida, DateTime fechaCambio,
            int existencia, int ptReOrden, string Activo, float costo, float precioUnitario, int ClaveDepa)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();

                SqlCommand cmd = new SqlCommand("ActualizarProductos", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idP", ID);
                cmd.Parameters.AddWithValue("@NombreProducto", NombreProd);
                cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                cmd.Parameters.AddWithValue("@UnidadMedida", uMedida);
                cmd.Parameters.AddWithValue("@FechaCambio", fechaCambio);
                cmd.Parameters.AddWithValue("@existencia", existencia);
                cmd.Parameters.AddWithValue("@ptReorden", ptReOrden);
                cmd.Parameters.AddWithValue("@Activo", Activo);
                cmd.Parameters.AddWithValue("@costo", costo);
                cmd.Parameters.AddWithValue("@PrecioUnitario", precioUnitario);
                cmd.Parameters.AddWithValue("@ClaveDeparmento", ClaveDepa);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception error)
            {

                MessageBox.Show("No puede haber claves repetidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool InsertarProductos(int CodigoProducto, string Nombre, string Descripcion, int UnidadMedida, DateTime fechaAlta, int existencia, int ptReorden, string activo,
        float costo, float preciounitario,int claveDepartamento)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                int idAdmin = 1;
                conectado = conn.AbrirConexion();
                SqlCommand cmd = new SqlCommand("InsertarProductos", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodigoProducto", CodigoProducto);
                cmd.Parameters.AddWithValue("@NombreProducto", Nombre);
                cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                cmd.Parameters.AddWithValue("@UniMedida", UnidadMedida);
                cmd.Parameters.AddWithValue("@fechaAlta", fechaAlta);
                cmd.Parameters.AddWithValue("@existencia", existencia);
                cmd.Parameters.AddWithValue("@ptReorden", ptReorden);
                cmd.Parameters.AddWithValue("@activo", activo);
                cmd.Parameters.AddWithValue("@Costo", costo);
                cmd.Parameters.AddWithValue("@PrecioUnitario", preciounitario);
                
                cmd.Parameters.AddWithValue("@ClaveDepartamento", claveDepartamento);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception err)
            {
                //MessageBox.Show("El ID del producto no se puede repetir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // <-- Usar una vez acabado todo
                MessageBox.Show("No puede haber claves repetidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        
        public DataTable ListarDepartamentosCb()
        {
            DataTable tabla = new DataTable();
            // Form3 access = new Form3();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarDepartamentos"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure; //Esto si es que lo hago por medio de transcat-sql
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListarUnidadesMedidaCb()
        {
            DataTable tabla = new DataTable();
            // Form3 access = new Form3();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarUnidadesMedida"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure; //Esto si es que lo hago por medio de transcat-sql
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListarCajasCb()
        {
            DataTable tabla = new DataTable();
            // Form3 access = new Form3();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarCaja"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure; //Esto si es que lo hago por medio de transcat-sql
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListarProductos()
        {
            DataTable tabla = new DataTable();
            // Form3 access = new Form3();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarProductos"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure; //Esto si es que lo hago por medio de transcat-sql
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListarProductosCb()
        {
            DataTable tabla = new DataTable();
            // Form3 access = new Form3();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "listarProdDescCB"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure; //Esto si es que lo hago por medio de transcat-sql
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public bool BajaProductos(int CodigoProducto)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
               
                conectado = conn.AbrirConexion();
                SqlCommand cmd = new SqlCommand("BajaProductos", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodigProduc", CodigoProducto);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
            return true;
        }

        public DataTable ListarInventario()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarInventario"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure; //Esto si es que lo hago por medio de transcat-sql
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return tabla;
        }


        public DataTable filtroExist(int filtro)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "filtro_existenciaI"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtroI", filtro);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable filtroDepaIn(string filtro)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "filtro_DepartamentoI"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtroI", filtro);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable filtroAgotado(int filtro)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "filtro_agotadoI"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtroI", filtro);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable filtroMerma(int filtro)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "filtro_mermaI"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtroI", filtro);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public bool AltaCaja(int numCaja, string disponibilidad)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();
                SqlCommand cmd = new SqlCommand("CrearCajas", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", numCaja);
                cmd.Parameters.AddWithValue("@Disponibilidad", disponibilidad);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception err)
            {
                MessageBox.Show("No puede haber cajas repetidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool InsertarDescuentos(int Porcentaje, DateTime fecha1, DateTime fecha2, int codigo)
        {
            ConexionSqlServer conn =  new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();
                SqlCommand cmd = new SqlCommand("RealizarDescuento", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Porcentaje", Porcentaje);
                cmd.Parameters.AddWithValue("@Fecha1", fecha1);
                cmd.Parameters.AddWithValue("@Fecha2", fecha2);
                cmd.Parameters.AddWithValue("@ClaveProd", codigo);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("No puede haber claves repetidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public bool EditarCaja(int numCaja, string disponibilidad)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();
                SqlCommand cmd = new SqlCommand("EditarCajas", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", numCaja);
                cmd.Parameters.AddWithValue("@Disponibilidad", disponibilidad);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception err)
            {
                MessageBox.Show("No puede haber cajas repetidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public DataTable ListarDescuentos()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarDescuentosFecha"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure; //Esto si es que lo hago por medio de transcat-sql
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListarCaja()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarCaja"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure; //Esto si es que lo hago por medio de transcat-sql
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListarCajaCombo()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarCajaCombo"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure; //Esto si es que lo hago por medio de transcat-sql
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public bool BajaCaja(int numCaja)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();
                SqlCommand cmd = new SqlCommand("bajaCajas", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idC", numCaja);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
            return true;
        }


        public bool InsertarDescuentos(int porcentaje, DateTime FechaInicial, DateTime FechaFinal)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conected = new SqlConnection();
            try
            {
                conected = conn.AbrirConexion();
                SqlCommand cmd = new SqlCommand("RealizarDescuento", conected);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Porcentaje",porcentaje);
                cmd.Parameters.AddWithValue("@Fecha1", FechaInicial);
                cmd.Parameters.AddWithValue("@Fecha2", FechaFinal);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception Barabas)
            {
                MessageBox.Show("No puede haber claves repetidas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public DataTable consultaRapida()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ConsultaRapida"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure; //Esto si es que lo hago por medio de transcat-sql
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable filtroConsultaRapida(int filtro, string nombre)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "filtroConsultaRapida"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filID", filtro);
            comando.Parameters.AddWithValue("@filName", nombre);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable filtroConsultaRapida(int filtro)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "filtroConsultaRapida"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filID", filtro);
            comando.Parameters.AddWithValue("@filName", "");
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable filtroConsultaRapida(string nombre)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "filtroConsultaRapida"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filID", "");
            comando.Parameters.AddWithValue("@filName", nombre);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable productoSales()
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "productosVenta"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure; //Esto si es que lo hago por medio de transcat-sql
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable filtroSelectProduct(int filtro, string nombre)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "filtroSelectProduct"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filID", filtro);
            comando.Parameters.AddWithValue("@filName", nombre);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable filtroSelectProduct(int filtro)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "filtroSelectProduct"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filID", filtro);
            comando.Parameters.AddWithValue("@filName", "");
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }
        public DataTable filtroSelectProduct(string nombre)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "filtroSelectProduct"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filID", "");
            comando.Parameters.AddWithValue("@filName", nombre);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public bool BorrarDescuento(int idDesc)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();

                SqlCommand cmd = new SqlCommand("BorrarDescuento", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDes", idDesc);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return false;
            }
            return true;
        }
        public bool AgregarCarrito(int codigo, string NombreProd, 
            int Caja, DateTime Fecha, int Cantidad)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SeleccionarProductoInsertarProducto"; //Para el procedure
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodigoProd", codigo);
                comando.Parameters.AddWithValue("@NombreProd", NombreProd);
                comando.Parameters.AddWithValue("@Caja", Caja);
                comando.Parameters.AddWithValue("@Fecha", Fecha);
                comando.Parameters.AddWithValue("@CantidadAllevar", Cantidad);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
                return true;
            
            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return false;
            }
            return true;

        }

        public bool ActualizarCarrito(string NombreCod, int cant)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ActualizarCantidad"; //Para el procedure
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NombreProd", NombreCod);
                comando.Parameters.AddWithValue("@Cantidad", cant);
                

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
                return true;

            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return false;
            }
            return true;

        }

        public DataTable ObtenerTicket(int NumTicket)
        {
           
                DataTable tabla = new DataTable();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "obtenerTicket"; //Para el procedure
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@filtroNum", NumTicket);
                
                leerFilas = comando.ExecuteReader();
                tabla.Load(leerFilas);
                leerFilas.Close();
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
                return tabla;
           

        }

        public DataTable ObtenerNota(int NumTicket)
        {

            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "obtenerNota"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtroNum", NumTicket);

            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;


        }


        public DataTable TablaDevTemporal()
        {

            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "TablaDevolucionTemp"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
                

            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
            

        }

        public bool InsertarDevTemporalMerma(int codProd, int NumRecibo, DateTime fecha, int cantDevuelta, float subTotal, int merma, string NombreProd)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "InsertarDevTemporalMerma"; //Para el procedure
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodigoProd", codProd);
                comando.Parameters.AddWithValue("@NumRecibo", NumRecibo);
                comando.Parameters.AddWithValue("@Fecha", fecha);
                comando.Parameters.AddWithValue("@cantDevuelta", cantDevuelta);
                comando.Parameters.AddWithValue("@subtotal", subTotal);
                comando.Parameters.AddWithValue("@Merma", merma);
                comando.Parameters.AddWithValue("@NombreProd", NombreProd);



                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
                return true;

            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return false;
            }
            return true;

        }

        public bool InsertarDevTemporalSinMerma(int codProd, int NumRecibo, DateTime fecha, int cantDevuelta, float subTotal, string NombreProd)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "InsertarDevTemporalSinMerma"; //Para el procedure
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodigoProd", codProd);
                comando.Parameters.AddWithValue("@NumRecibo", NumRecibo);
                comando.Parameters.AddWithValue("@Fecha", fecha);
                comando.Parameters.AddWithValue("@cantDevuelta", cantDevuelta);
                comando.Parameters.AddWithValue("@subtotal", subTotal);
                comando.Parameters.AddWithValue("@NombreProd", NombreProd);
                
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
                return true;

            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return false;
            }
            return true;

        }


        public bool EliminarProductoCarrito(string NombreCod, int Cant)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EliminarProductoCarrito"; //Para el procedure
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NombreProd", NombreCod);
                comando.Parameters.AddWithValue("@Cant", Cant);
            


                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
                return true;

            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return false;
            }
            return true;

        }

        public bool GenerarNotaCredito(int NumRecibo, float Total, DateTime fechita)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "GenerarNotaCred"; //Para el procedure
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NumeroRecibo", NumRecibo);
                comando.Parameters.AddWithValue("@Total", Total);
                comando.Parameters.AddWithValue("@FechaNota", fechita);



                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
                return true;

            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return false;
            }
           

        }

        public bool GenerarDevolucion(int CodProd, int CantDev, float subTotal, string motivo, string NombreProd)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "GeneraDevolucion"; //Para el procedure
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@CodigoProd", CodProd);
                comando.Parameters.AddWithValue("@CantDevuelta", CantDev);
                comando.Parameters.AddWithValue("@SubtotalDevoulucion", subTotal);
                comando.Parameters.AddWithValue("@Motivo", motivo);
                comando.Parameters.AddWithValue("@NombreProd", NombreProd);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
                return true;

            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return false;
            }
            

        }

        public bool ActualizarProdSinMerma(int cant, int codProduc)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ActualizarProdDevolucionSinMerma"; //Para el procedure
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@cant", cant);
                comando.Parameters.AddWithValue("@CodProducto", codProduc);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
                return true;

            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return false;
            }


        }

        public bool ActualizarProdMerma(int cant, int codProduc)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ActualizarProdDevolucionMerma"; //Para el procedure
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@cant", cant);
                comando.Parameters.AddWithValue("@CodProducto", codProduc);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
                return true;

            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return false;
            }
        }



            public bool EliminarCantidadProductoCarrito(string NombreCod, int CantidadEliminar)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EliminarCantidad"; //Para el procedure
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NombreProd", NombreCod);
                comando.Parameters.AddWithValue("@Cantidad", CantidadEliminar);



                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
                return true;

            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return false;
            }
            return true;

        }
        //FALTA IMPLEMENTAR
        public bool EliminarProductoDevolucion(int codProd, int CantidadEliminar)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EliminarProductoDevolucion"; //Para el procedure
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Codigo", codProd);
                comando.Parameters.AddWithValue("@Cant", CantidadEliminar);



                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
                return true;

            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return false;
            }
            return true;

        }

        public bool RestarStockVenta(string name, int CantidadEliminar)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "RestarStockVenta"; //Para el procedure
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@cant", CantidadEliminar);
                comando.Parameters.AddWithValue("@NombreProd", name);



                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
                return true;

            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return false;
            }
            return true;

        }

        public bool aumentarCantVendida(string nombre, int suma)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "AumentarCantidadesVendidas"; //Para el procedure
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@NombreProd", nombre);
                comando.Parameters.AddWithValue("@CantVendida", suma);



                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
                return true;

            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return false;
            }
            return true;

        }


        public DataTable filtroScreenDepa(string filtro)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "filtro_DepartamentoScreen"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtroI", filtro);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable filtroScreenProduct(string filtro)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "filtro_ProductoScreen"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtroI", filtro);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable filtroScreenEmpleados(string filtro)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "filtro_EmpleadosScreen"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtroI", filtro);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public bool ActualizarDescuento(int idDesc, DateTime fecha1, DateTime fecha2, int porcentaje)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();

                SqlCommand cmd = new SqlCommand("editDescuento", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDesc", idDesc);
                cmd.Parameters.AddWithValue("@Fecha1", fecha1);
                cmd.Parameters.AddWithValue("@Fecha2", fecha2);
                cmd.Parameters.AddWithValue("@porcentaje", porcentaje);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return false;
            }
            return true;
        }

        public bool GenerarVenta(DateTime fecha1, int NumCaja, float MontoPago, float Total,
            string NombreCajero, int CajeroId)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();

                SqlCommand cmd = new SqlCommand("GenerarVenta", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@CajeroId", CajeroId);
                cmd.Parameters.AddWithValue("@NumCaja", NumCaja);
                cmd.Parameters.AddWithValue("@Fecha", fecha1);
                cmd.Parameters.AddWithValue("@MontoPago", MontoPago);
                cmd.Parameters.AddWithValue("@Total", Total);
                
                cmd.Parameters.AddWithValue("@NombreCajero", NombreCajero);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return false;
            }
            return true;
        }

        public bool GenerarVentaDetalle(int idVentaHeader, string NombreProducto, int UnidadesVendidas,
            float subtotal, float PrecioU, float totalVenta, float Utilidad)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();

                SqlCommand cmd = new SqlCommand("GenerarVentaDetalle", conectado);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idVentaHeader", idVentaHeader);
                cmd.Parameters.AddWithValue("@nombreProducto", NombreProducto);
                cmd.Parameters.AddWithValue("@UnidaesVendidas", UnidadesVendidas);
                cmd.Parameters.AddWithValue("@Subtotal", subtotal);
                cmd.Parameters.AddWithValue("@PrecioUnitario", PrecioU);
                cmd.Parameters.AddWithValue("@Venta", totalVenta);
                cmd.Parameters.AddWithValue("@Utilidad", Utilidad);

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return false;
            }
            return true;
        }

       
        public bool GenerarTicketDB(int ventaId, float MontoPagado, int CLAVEdEPAGO)
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();

                SqlCommand cmd = new SqlCommand("GenerarTicket", conectado);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdVentaHeader", ventaId);
                cmd.Parameters.AddWithValue("@MontoPagado", MontoPagado);
                cmd.Parameters.AddWithValue("@ClavePago", CLAVEdEPAGO);
          

                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return false;
            }
            return true;
        }

        public bool EliminarCarrito()
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();

                SqlCommand cmd = new SqlCommand("BorrarCarrito", conectado);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return false;
            }
            return true;
        }


        public DataTable obtenerCajeroCobra(string claveUser)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "obtenerCajeroCobra"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@filtroI", claveUser);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public bool limpiarVentaTemporal()
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();
                SqlCommand cmd = new SqlCommand("vaciarVentaTemporal", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
            return true;
        }

        public bool limpiarGridDevolucion()
        {
            ConexionSqlServer conn = new ConexionSqlServer();
            SqlConnection conectado = new SqlConnection();
            try
            {
                conectado = conn.AbrirConexion();
                SqlCommand cmd = new SqlCommand("BorrarGridDevolucion", conectado);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
                conn.CerrarConexion();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
                return false;
            }
            return true;
        }

        public int obtenerIdVenta()
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "obtenerIdVenta"; //Para el procedure
                comando.CommandType = CommandType.StoredProcedure;
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                int idVentaActual = 0;
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    idVentaActual = reader.GetInt32(0);
                }
                conexion.CerrarConexion();
                return idVentaActual;

            }
            catch (Exception error)
            {

                MessageBox.Show(error.ToString());
                return 0;
            }

        }

        public DataTable listarRVenta()
        {
            DataTable grid = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "reporteVentas";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            grid.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return grid;
        }

        public DataTable listarRCajero()
        {
            DataTable grid = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "reporteCajero";
            comando.CommandType = CommandType.StoredProcedure;
            leerFilas = comando.ExecuteReader();
            grid.Load(leerFilas);
            leerFilas.Close();
            conexion.CerrarConexion();
            return grid;
        }

        public DataTable listarRCajeroCajero(string filtro)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "reporteCajeroCajeroFiltro"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Cajero", filtro);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable listarRCajeroDepa(string filtro)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "reporteCajeroDepa"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Depa", filtro);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable listarRCajeroFecha(DateTime fecha1, DateTime fecha2)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "reporteCajeroFechas"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fecha1", fecha1);
            comando.Parameters.AddWithValue("@fecha2", fecha2);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable listarVentaCaja(string filtro)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "reporteVentaCajaFiltro"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Caja", filtro);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable listarVentaDepa(string filtro)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "reporteVentaDepa"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Depa", filtro);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable listarVentaFecha(DateTime fecha1, DateTime fecha2)
        {
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "reporteVentaFechas"; //Para el procedure
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@fecha1", fecha1);
            comando.Parameters.AddWithValue("@fecha2", fecha2);
            leerFilas = comando.ExecuteReader();
            tabla.Load(leerFilas);
            leerFilas.Close();
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

    }
}
