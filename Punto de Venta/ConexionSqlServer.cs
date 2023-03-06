using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Punto_de_Venta
{
    class ConexionSqlServer
    {
        //* simbolo universal para ue me traiga todas las carreras y en general todo todito
        // daa source =
        //persist security info true; Integrated Security true esto es para poder entrar con el sistema de autentificaion de windows
        

        /*<add name="ConexionHistorial2"
            connectionString="Data Source=LAPTOP-VLDIQG6S\SQLEXPRESS;Initial Catalog=HistorialMedicoRJcodeAdvanced; persist security info true; Integrated Security true"
            providerName="System.Data.SqlClient" />*/
        //El primer parametro es el server, haz de cuenta que donde te conectas en el sql, ahi copias como se llama el server, que en este caso sera tu compu
        //el 2 sera la base de datos, pones la base de datos
        //el 3 es el tipo de seguridad, yo en este caso he probado y me jala con ambas, la de windows y de sql server
        /*
         <connectionStrings>
		<add name="ConexionSqlServer"
			 connectionString ="Data Source=LAPTOP-VLDIQG6S\SQLEXPRESS; Initial Catalog=ProyectoMAD; Integrated Security=True"
			 providerName ="System.Data.SqlClient"/>
		
	</connectionStrings> esto va en el appConfig
         */
        //DESKTOP-1145PHU\SQLEXPRESS <- El de Edson
        //LAPTOP-VLDIQG6S\SQLEXPRESS <- El de Isaac
        static private string CadenaConexion = @"Server=LAPTOP-VLDIQG6S\SQLEXPRESS; DataBase=ProyectoMAD; Integrated Security= true";
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);
        
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();

            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }
    }
}
