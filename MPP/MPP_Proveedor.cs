using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstraccion;
using BE;
using DAL;
using System.Data;
namespace MPP
{
    public class MPP_Proveedor : IGestor<BE_Proveedor>
    {
        Acceso oDatos;
        public bool Baja(BE_Proveedor Objeto)
        {
            string Consulta_SQL;
            Consulta_SQL = "DELETE From TbProveedores WHERE NroProveedor= " + Objeto.Codigo + "";
            return oDatos.Escribir(Consulta_SQL);
        }
        public bool Guardar(BE_Proveedor pOproveedor)
        {
            string Consulta_SQL;
            if (pOproveedor.Codigo != 0) //Si tengo codigo es un updata
            {
                Consulta_SQL = "Update TbProveedores SET Nombre = '" + pOproveedor.Nombre + "', Apellido = '" + pOproveedor.Apellido + "', RazonSocial = '" + pOproveedor.RazonSocial  + "', CUIT ='" + pOproveedor.CUIT  + "', Email ='" + pOproveedor.EMail + "', Telefono ='" + pOproveedor.Telefono + "', Localidad ='" + pOproveedor.Localidad  + "' , Direccion ='" + pOproveedor.Direccion + "' where NroProveedor=" + pOproveedor.Codigo + "";
            }
            else //Sino es un insert.
            {
                Consulta_SQL = "Insert INTO TbProveedores(Nombre,Apellido,RazonSocial,CUIT,CUIL,Email,Telefono,Localidad,Direccion ) values('" + pOproveedor.Nombre + "', '" + pOproveedor.Apellido + "', '" + pOproveedor.RazonSocial + "','" + pOproveedor.CUIT + "','" + pOproveedor.EMail  + "','" + pOproveedor.Telefono + "','" + pOproveedor.Localidad  + "','" + pOproveedor.Direccion + "')";
            }
            oDatos = new Acceso();
            return oDatos.Escribir(Consulta_SQL);
        }
        public BE_Proveedor ListarObjeto(BE_Proveedor Objeto)
        {
            throw new NotImplementedException();
        }
        public List<BE_Proveedor> ListarTodo()
        {
            List<BE_Proveedor> Lista = new List<BE_Proveedor>();
            //Declaro el objeto DataSet para guardar los datos y luego pasarlos a lista
            DataSet Ds;
            string Consulta = "Select * from TbProveedores";
            oDatos = new Acceso();
            Ds = oDatos.Leer2(Consulta);
            //rcorro la tabla dentro del Dataset y la paso a lista
            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in Ds.Tables[0].Rows)
                {
                    BE_Proveedor oBEProveedor;
                    oBEProveedor = new BE_Proveedor();

                    oBEProveedor.Codigo = int.Parse(fila["NroProveedor"].ToString());
                    oBEProveedor.Nombre = (fila["Nombre"].ToString());
                    oBEProveedor.Apellido = (fila["Apellido"].ToString());
                    oBEProveedor.RazonSocial = (fila["RazonSocial"].ToString());
                    oBEProveedor.CUIT = (fila["CUIT"].ToString());
                    oBEProveedor.Localidad = (fila["Localidad"].ToString());
                    oBEProveedor.Direccion = (fila["Direccion"].ToString());
                    oBEProveedor.EMail = (fila["EMail"].ToString());
                    oBEProveedor.Telefono = (fila["Telefono"].ToString());

                    Lista.Add(oBEProveedor);
                }
            }
            else
            {
                Lista = null;
            }
            return Lista;
        }
        public DataTable ListarTodoTable()
        //Metodo hace consulta y devuelve un datatable con la informacion.
        {
            DataTable dt = new DataTable();
            string consulta = "Select TbProveedores.NroProveedor as Codigo, TbProveedores.Nombre, TbProveedores.Apellido, TbProveedores.RazonSocial,TbProveedores.CUIT,TbProveedores.CUIL,TbProveedores.Email,TbProveedores.Telefono,TbProveedores.Localidad,TbProveedores.Direccion FROM TbProveedores";
            oDatos = new Acceso();
            dt = oDatos.Leer(consulta);

            return dt;
        }
    }
}
