using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    public class Acceso
    {
        private SqlConnection oConn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=DBDematazo;Integrated Security=True");
        SqlCommand cmd;

        // creo una funcion para saber el estado de la conexion
        public string TestConnection()
        {
            oConn.Open();
            //si no uso el metodo Abrir puedo hacer el open 
            //conexion.Open();
            //Cerrar();
            if (oConn.State == ConnectionState.Open)
            {
                return "Conexion a la BD OK";
            }
            else
            {
                return "No se pudo conectar a la BD, que pacho???";
            }
        }
        public bool Escribir(string Consulta_SQL)
        {
            oConn.Open(); //Abro conexion
 
            cmd = new SqlCommand(); //creo un objeto sqlcommand
            cmd.CommandType = CommandType.Text; //Le digo que es de tipo texto.
            cmd.Connection = oConn; // Asigo connexion al cmd.

            SqlTransaction oTrasaccion; //Creo objeto transaccion
            oTrasaccion = oConn.BeginTransaction(); //Comienzo la tranzaccion en la conexion

            try
            {
                cmd.Transaction = oTrasaccion;   //Asigno la transaccion al cmd.          
                cmd.CommandText = Consulta_SQL; //Asigno la consulta que viene como parametro
                int respuesta = cmd.ExecuteNonQuery(); //Ejecuto la consulta.
                oTrasaccion.Commit(); //Si fue ok realizo el commint de la trasaccion.

                return true;
            }
            catch (SqlException ex)
            {
                oTrasaccion.Rollback(); //Si hay una excepcion vuelvo todo para atras ya que no ejecuto la transaccion correctamente.
                throw ex;
            }
            finally
            { oConn.Close(); }
        }
        public DataSet Leer2(string Consulta_SQL)
        {
            DataSet Ds = new DataSet();
            try
            {
                //creo el data adapter le paso la consulta y la conexion
                SqlDataAdapter Da = new SqlDataAdapter(Consulta_SQL, oConn);
                //lleno el DataSet con el metodo fill
                Da.Fill(Ds);
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
            finally
            { //cierro la Conexion
                oConn.Close();
            }
            return Ds;
        }
        public DataTable Leer(string consulta)
        {
            DataTable tabla = new DataTable();
            try
            {
                //creo el data adapter le paso la consulta y la conexion
                SqlDataAdapter Da = new SqlDataAdapter(consulta, oConn);
                //lleno la tabla con el metodo fill
                Da.Fill(tabla);
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
            finally
            { //cierro la Conexion
                oConn.Close();
            }
            return tabla;
        }

    }
}
