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
    public class MPP_OrdenCompra
    {
        Acceso oDatos;
        Acceso oDatos2;
        public bool Guardar(BE_OrdenCompra POrdenCompra)
        {
            string Consulta_SQL;
            if (POrdenCompra.Codigo != 0) //Si tengo codigo es un updata
            {
                Consulta_SQL = "Update TbOrdenCompra SET Fecha = '" + POrdenCompra.Fecha + "', Proveedor= '" + POrdenCompra.Proveedor  + "', Personal = " + POrdenCompra.Proveedor  + " where NroOrdenCompre=" + POrdenCompra.Codigo + "";
                // string COnsulta_SQL2= string.Format("update Alumno set Nombre = '{0}', Apellido = '{1}', DNI = {2} , FechaNac = '{3}', CodLocalidad = {4} where Codigo = {5}", oAlu.Nombre, oAlu.Apellido,oAlu.DNI,(oAlu.FechaNac).ToString("MM/dd/yyyy"),oAlu.oLocalidad.Codigo, oAlu.Codigo);
            }
            else //Sino es un insert.
            {
                Consulta_SQL = "Insert INTO TbOrdenCompra (Fecha,Proveedor,Personal) VALUES ('" + POrdenCompra.Fecha  + "', '" + POrdenCompra.Proveedor.RazonSocial  + "','" + POrdenCompra.Personal.Apellido  + " " +POrdenCompra.Personal.Nombre + "')";
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

        private BE_Personal CargarDatos(BE_Personal oBEPersonal, DataRow fila)
        {
            //  oBEPersonal.Codigo  =int.Parse (fila["NroPersonal"].ToString());
            oBEPersonal.Nombre = fila["Nombre"].ToString();
            oBEPersonal.Apellido = fila["Apellido"].ToString();
            oBEPersonal.Documento = Convert.ToInt32(fila["Documento"]);

            return oBEPersonal;
        }
        public List<BE_Personal> ListarTodoPersonal()
        {
            List<BE_Personal> ListaPersonal = new List<BE_Personal>();
            //Declaro el objeto DataSet para guardar los datos y luego pasarlos a lista
            DataSet Ds;
            string Consulta = "Select * from TbPersonal";
            oDatos = new Acceso();
            Ds = oDatos.Leer2(Consulta);

             //rcorro la tabla dentro del Dataset y la paso a lista
            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in Ds.Tables[0].Rows)
                {
                    string tipoPersonal = fila["Tipo_Personal"].ToString();
                    BE_Personal oPersonal;
                    if (tipoPersonal == "Mostrador")
                    {
                        oPersonal = new BE_PersonalMostrador();
                        ListaPersonal.Add(CargarDatos(oPersonal, fila));
                    }
                    else if (tipoPersonal == "Fabrica")
                    {
                        oPersonal = new BE_PersonalFabrica();
                        ListaPersonal.Add(CargarDatos(oPersonal, fila));
                    }
                    else if (tipoPersonal == "Administrador")
                    {
                        oPersonal = new BE_PersonalAdministrador();
                        ListaPersonal.Add(CargarDatos(oPersonal, fila));
                    }
                    else
                    {
                        oPersonal = null;
                    }
                }
            }
            else
            {
                ListaPersonal = null;
            }
            return ListaPersonal;
        }
        public List<BE_OrdenCompra> ListarTodoOrdenCompra()
        {
            List<BE_OrdenCompra> Lista = new List<BE_OrdenCompra>();
            //Declaro el objeto DataSet para guardar los datos y luego pasarlos a lista
            DataSet Ds;
            string Consulta = "Select * from TbOrdenCompra";
            oDatos = new Acceso();
            Ds = oDatos.Leer2(Consulta);
            //rcorro la tabla dentro del Dataset y la paso a lista
            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in Ds.Tables[0].Rows)
                {
                    BE_OrdenCompra oBEOrdenCompra;
                    oBEOrdenCompra = new BE_OrdenCompra();

                    oBEOrdenCompra.Codigo = int.Parse(fila["NroOrdenCompra"].ToString());
                    oBEOrdenCompra.Fecha = DateTime.Parse(fila["Fecha"].ToString());
                    oBEOrdenCompra.NombrePersonal    = (fila["Personal"].ToString());
                    oBEOrdenCompra.NombreProveedor   = (fila["Proveedor"].ToString());
                   
              
                    DataSet Ds2;
                    string Consulta2 = "Select * from TbDetalleCompra where NroOrden= "+ oBEOrdenCompra.Codigo +"";
                    oDatos2 = new Acceso();
                    Ds2 = oDatos2.Leer2(Consulta2);

                    List<BE_DetalleCompra> listaDetalle = new List<BE_DetalleCompra>();

                    if (Ds2.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow item in Ds2.Tables[0].Rows)
                        {
                            BE_DetalleCompra oBEDetalleCompra = new BE_DetalleCompra();

                            oBEDetalleCompra.Codigo = int.Parse(item["IdDetalle"].ToString());
                            oBEDetalleCompra.NroOrden = int.Parse(item["NroOrden"].ToString());
                            oBEDetalleCompra.NroItem = int.Parse(item["NroItem"].ToString());
                            oBEDetalleCompra.Descripcion = (item["Descripcion"].ToString());
                            oBEDetalleCompra.Cantidad = int.Parse(item["Cantidad"].ToString());

                            listaDetalle.Add(oBEDetalleCompra);
                        }
                        oBEOrdenCompra.LstItems = listaDetalle;
                    }
                    //LLeno la lista de items del detalle
                    Lista.Add(oBEOrdenCompra);
                }                
            }
            else
            {
                Lista = null;
            }
            return Lista;
        }
        public List<BE_Proveedor> ListarTodoProveedor()
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
                    oBEProveedor.Apellido= (fila["Apellido"].ToString());
                    oBEProveedor.RazonSocial = (fila["RazonSocial"].ToString());
                    oBEProveedor.CUIT = (fila["CUIT"].ToString());
                    oBEProveedor.CUIL = (fila["CUIL"].ToString());
                    oBEProveedor.Localidad = (fila["Localidad"].ToString());
                    oBEProveedor.Direccion = (fila["Direccion"].ToString());
                    oBEProveedor.EMail = (fila["EMail"].ToString());
                    oBEProveedor.Telefono= (fila["Telefono"].ToString());

                    Lista.Add(oBEProveedor);
                }
            }
            else
            {
                Lista = null;
            }
            return Lista;
        }
        public List<BE_Materiales> ListarTodoMaterial()
        {
            List<BE_Materiales> Lista = new List<BE_Materiales>();
            //Declaro el objeto DataSet para guardar los datos y luego pasarlos a lista
            DataSet Ds;
            string Consulta = "Select TbMaterial.Codigo,TbMaterial.Descripcion_Articulo,TbMaterial.Material, TbMaterial.Descripcion_Articulo +'-'+ TbMaterial.Material as MatDesc FROM TbMaterial";
            oDatos = new Acceso();
            Ds = oDatos.Leer2(Consulta);
            //rcorro la tabla dentro del Dataset y la paso a lista
            if (Ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in Ds.Tables[0].Rows)
                {
                    BE_Materiales oBEMaterial;
                    oBEMaterial = new BE_Materiales();

                    oBEMaterial.Codigo = int.Parse(fila["Codigo"].ToString());
                    oBEMaterial.Descripcion_material = (fila["MatDesc"].ToString());
                    oBEMaterial.Material  = (fila["Material"].ToString());
             
                    Lista.Add(oBEMaterial);
                }
            }
            else
            {
                Lista = null;
            }
            return Lista;
        }

    }
}
