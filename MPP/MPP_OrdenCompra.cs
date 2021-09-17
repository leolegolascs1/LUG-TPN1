using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using Abstraccion;
using System.Data;

namespace MPP
{
    public class MPP_OrdenCompra : IGestor<BE_OrdenCompra>
    {
        Acceso oDatos;
        Acceso oDatos1;
        Acceso oDatos3;
        public bool Guardar(BE_OrdenCompra POrdenCompra)
        {
            string Consulta_SQL;
            if (POrdenCompra.Codigo != 0) //Si tengo codigo es un updata
            {
                Consulta_SQL = "Update TbOrdenCompra SET Fecha = '" + POrdenCompra.Fecha.ToString ("MM/dd/yyyy") + "', Proveedor= '" + POrdenCompra.Proveedor  + "', Personal = " + POrdenCompra.Proveedor  + " where NroOrdenCompre=" + POrdenCompra.Codigo + "";
                // string COnsulta_SQL2= string.Format("update Alumno set Nombre = '{0}', Apellido = '{1}', DNI = {2} , FechaNac = '{3}', CodLocalidad = {4} where Codigo = {5}", oAlu.Nombre, oAlu.Apellido,oAlu.DNI,(oAlu.FechaNac).ToString("MM/dd/yyyy"),oAlu.oLocalidad.Codigo, oAlu.Codigo);
            }
            else //Sino es un insert.
            {
                Consulta_SQL = "Insert INTO TbOrdenCompra (Fecha,Proveedor,Personal) VALUES ('" + POrdenCompra.Fecha.ToString("MM/dd/yyyy") + "', '" + POrdenCompra.Proveedor.RazonSocial  + "','" + POrdenCompra.Personal.Apellido  + " " +POrdenCompra.Personal.Nombre + "')";
                //opcion 2
                // string Consulta_SQL = string.Format("Insert into Alumno(Nombre, Apellido,DNI, FechaNac,CodLocalidad) values ('{0}','{1}',{2},'{3}',{4})", oAlu.Nombre,oAlu.Apellido, oAlu.DNI,(oAlu.FechaNac).ToString("MM/dd/yyyy"),oAlu.oLocalidad.Codigo);
            }
            oDatos = new Acceso();
            return oDatos.Escribir(Consulta_SQL);
        }
        public bool Guardar(BE_DetalleCompra pDetalle)
        {
            string Consulta_SQL;
      
            Consulta_SQL = "Insert INTO TbDetalleCompra(NroOrden,NroItem,Descripcion,Cantidad) VALUES (" + pDetalle.NroOrden  + ", " + pDetalle.NroItem + ",'" + pDetalle.Descripcion  + "',"+ pDetalle.Cantidad +")";
  
            oDatos = new Acceso();
            return oDatos.Escribir(Consulta_SQL);
        }
        public DataTable ListarTodoTable()
        //Metodo hace consulta y devuelve un datatable con la informacion.
        {
            DataTable dt = new DataTable();
            string consulta = "Select * FROM TbOrdenCompra";

            oDatos = new Acceso();
            dt = oDatos.Leer(consulta);

            return dt;
        }
        public bool Baja(BE_OrdenCompra Objeto)
        {
            throw new NotImplementedException();
        }
        public List<BE_OrdenCompra> ListarTodo()
        {
            List<BE_OrdenCompra> Lista = new List<BE_OrdenCompra>();
            //Declaro el objeto DataSet para guardar los datos y luego pasarlos a lista
            DataSet Ds0;
            string Consulta = "Select * from TbOrdenCompra";
            oDatos = new Acceso();
            Ds0 = oDatos.Leer2(Consulta);
            //rcorro la tabla dentro del Dataset y la paso a lista
            if (Ds0.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in Ds0.Tables[0].Rows)
                {
                    BE_OrdenCompra oBEOrdenCompra;            
                    oBEOrdenCompra = new BE_OrdenCompra(); //Creo el objeto orden de comprar

                    List<BE_Personal> _lst = new List<BE_Personal>(); //Creo lista de Personal

                    //Cargo los datos al objeto
                    oBEOrdenCompra.Codigo = int.Parse(fila["NroOrdenCompra"].ToString());
                    oBEOrdenCompra.Fecha = DateTime.Parse(fila["Fecha"].ToString());
                    oBEOrdenCompra.NroPersonal = int.Parse(fila["NroPersonal"].ToString());
                    oBEOrdenCompra.NroProveedor = int.Parse(fila["NroProveedor"].ToString()); 

                    //Creo un nuevo data set para cargar el objeto personal con la nueva consulta.
                    DataSet Ds1;
                    string Consulta1 = "Select * from TbPersonal where NroPersonal= " + oBEOrdenCompra.NroPersonal + "";
                    oDatos1 = new Acceso();
                    Ds1 = oDatos1.Leer2(Consulta1); //Leo la consulta y cargo el ds

                    foreach (DataRow row in Ds1.Tables[0].Rows) //Recorro ds
                    {
                        BE_PersonalFabrica oPersonalF = new BE_PersonalFabrica(); //Creo objeto personal fabrica y cargo datos.
                        oPersonalF.Codigo = int.Parse(row["NroPersonal"].ToString());
                        oPersonalF.Apellido = (row["Apellido"].ToString());
                        oPersonalF.Nombre  = (row["Nombre"].ToString());
                        oPersonalF.Documento= int.Parse(row["Documento"].ToString());
                
                        oBEOrdenCompra.Personal = oPersonalF; //Asigno el personal a la orden de compra.
                    }

                    //Realizo una nueva consulta para cargar el objeto proveedor.
                    DataSet Ds2;
                    string Consulta2 = "Select * from TbProveedores where NroProveedor= " + oBEOrdenCompra.NroProveedor  + "";
                    oDatos1 = new Acceso();
                    Ds2 = oDatos1.Leer2(Consulta2);

                    foreach (DataRow row in Ds2.Tables[0].Rows)
                    {
                        BE_Proveedor oProveedor = new BE_Proveedor();
                        oProveedor.Codigo = int.Parse(row["NroProveedor"].ToString());
                        oProveedor.Apellido = (row["Apellido"].ToString());
                        oProveedor.Nombre = (row["Nombre"].ToString());
                        oProveedor.RazonSocial =(row["RazonSocial"].ToString());
                        oProveedor.CUIT = (row["CUIT"].ToString());
                        oProveedor.CUIL  = (row["CUIL"].ToString());
                        oProveedor.EMail = (row["Email"].ToString());
                        oProveedor.Telefono = (row["Telefono"].ToString());
                        oProveedor.Localidad  = (row["Localidad"].ToString());
                        oProveedor.Direccion = (row["Direccion"].ToString());

                        oBEOrdenCompra.Proveedor  = oProveedor; //Asigno proveedor.
                    }

                    //Creo una nueva consulta para obtener el detalle de la orden de compra especifica.
                    DataSet Ds3;
                    string Consulta3 = "Select * from TbDetalleCompra where NroOrden= " + oBEOrdenCompra.Codigo + "";
                    oDatos3 = new Acceso();
                    Ds3 = oDatos3.Leer2(Consulta3);

                    List<BE_DetalleCompra> listaDetalle = new List<BE_DetalleCompra>(); //Creo Lista detalles

                    if (Ds3.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow item in Ds3.Tables[0].Rows) //Recorro
                        { 
                            BE_DetalleCompra oBEDetalleCompra = new BE_DetalleCompra(); //Creo objeto y cargo datos.

                            oBEDetalleCompra.Codigo = int.Parse(item["IdDetalle"].ToString());
                            oBEDetalleCompra.NroOrden = int.Parse(item["NroOrden"].ToString());
                            oBEDetalleCompra.NroItem = int.Parse(item["NroItem"].ToString());
                            oBEDetalleCompra.Descripcion = (item["Descripcion"].ToString());
                            oBEDetalleCompra.Cantidad = int.Parse(item["Cantidad"].ToString());

                            listaDetalle.Add(oBEDetalleCompra); //Agrego a la lista detalles
                        }
                        oBEOrdenCompra.LstItems = listaDetalle; //Asigno la lista a la orden de compra.
                    }
                    //LLeno la lista de items del detalle
                    Lista.Add(oBEOrdenCompra);
                }
            }
            else
            {
                Lista = null;
            }
            return Lista; //Retorno la lista con las ordenes de compras cargadas.
        }
        public BE_OrdenCompra ListarObjeto(BE_OrdenCompra Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
