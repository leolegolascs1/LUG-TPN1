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
    public class MPP_Material : IGestor<BE_Materiales>
    {
        Acceso oDatos;
        public bool Baja(BE_Materiales Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BE_Materiales Objeto)
        {
            string Consulta_SQL;
            if (Objeto.Codigo != 0) //Si tengo codigo es un updata
            {
                Consulta_SQL = "Update TbMaterial SET Descripcion_Articulo = '" + Objeto.Descripcion_material + "', Material = '" + Objeto.Material  + "' where Codigo=" + Objeto.Codigo + "";
                // string COnsulta_SQL2= string.Format("update Alumno set Nombre = '{0}', Apellido = '{1}', DNI = {2} , FechaNac = '{3}', CodLocalidad = {4} where Codigo = {5}", oAlu.Nombre, oAlu.Apellido,oAlu.DNI,(oAlu.FechaNac).ToString("MM/dd/yyyy"),oAlu.oLocalidad.Codigo, oAlu.Codigo);
            }
            else //Sino es un insert.
            {
                Consulta_SQL = "Insert INTO TbMaterial (Descripcion_Articulo, Material) values('" + Objeto.Descripcion_material + "', '" + Objeto.Material + "')";
                //opcion 2
                // string Consulta_SQL = string.Format("Insert into Alumno(Nombre, Apellido,DNI, FechaNac,CodLocalidad) values ('{0}','{1}',{2},'{3}',{4})", oAlu.Nombre,oAlu.Apellido, oAlu.DNI,(oAlu.FechaNac).ToString("MM/dd/yyyy"),oAlu.oLocalidad.Codigo);
            }
            oDatos = new Acceso();
            return oDatos.Escribir(Consulta_SQL);
        }

        public BE_Materiales ListarObjeto(BE_Materiales Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BE_Materiales> ListarTodo()
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
                        oBEMaterial.Material = (fila["Material"].ToString());

                        Lista.Add(oBEMaterial);
                    }
                }
                else
                {
                    Lista = null;
                }
                return Lista;           
        }

        public DataTable ListarTodoTable()
        {
            DataTable dt = new DataTable();
            string consulta = "Select * from TbMaterial";
            oDatos = new Acceso();
            dt = oDatos.Leer(consulta);

            return dt;
        }
    }
}
