﻿using System;
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
    public class MPP_Personal : IGestor<BE_Personal>
    {
        Acceso oDatos;
        public bool Baja(BE_Personal Objeto)
        {
            string Consulta_SQL;
            Consulta_SQL = "DELETE From TbPersonal WHERE NroPersonal= " + Objeto.Codigo + "";
            return oDatos.Escribir(Consulta_SQL);       
        }
        public bool Guardar(BE_Personal pOPersonal)
        {
            string Consulta_SQL;
            if (pOPersonal.Codigo != 0) //Si tengo codigo es un updata
            {
                Consulta_SQL = "Update TbPersonal SET Nombre = '" + pOPersonal.Nombre + "', Apellido = '" + pOPersonal.Apellido + "', Documento = " + pOPersonal.Documento + ", Rol ='" + pOPersonal.Tipo_Personal + "' where NroPersonal=" + pOPersonal.Codigo + "";
            
            }
            else //Sino es un insert.
            {
                Consulta_SQL = "Insert INTO TbPersonal (Nombre, Apellido,Documento, Rol) values('" + pOPersonal.Nombre + "', '" + pOPersonal.Apellido + "', " + pOPersonal.Documento + ",'" + pOPersonal.Tipo_Personal + "')";               
            }
            oDatos = new Acceso();
            return oDatos.Escribir(Consulta_SQL);
        }
        public bool GuardarPassword(string pPassword, int pNroPersonal)
        {
            string Consulta_SQL;
        
                Consulta_SQL = "Update TbPersonal SET Password='" + pPassword  + "' where NroPersonal=" + pNroPersonal  + "";
  
            oDatos = new Acceso();
            return oDatos.Escribir(Consulta_SQL);
        }
        public BE_Personal ListarObjeto(BE_Personal Objeto)
        {
            throw new NotImplementedException();
        }
        private BE_Personal CargarDatos(BE_Personal  oBEPersonal, DataRow fila) 
        {
            oBEPersonal.Codigo  =int.Parse(fila["NroPersonal"].ToString());
            oBEPersonal.Nombre = fila["Nombre"].ToString();
            oBEPersonal.Apellido = fila["Apellido"].ToString();
            oBEPersonal.Documento = Convert.ToInt32(fila["Documento"]);
            oBEPersonal.Password = fila["Password"].ToString();

            return oBEPersonal;
        }
        public List <BE_Personal> ListarTodo()
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
                    string Rol = fila["Rol"].ToString();
                    BE_Personal oPersonal;
                    if (Rol == "Mostrador")
                    {
                        oPersonal = new BE_PersonalMostrador();
                        ListaPersonal.Add(CargarDatos(oPersonal,fila));
                    }
                    else if (Rol == "Fabrica")
                    {
                        oPersonal = new BE_PersonalFabrica();
                        ListaPersonal.Add(CargarDatos(oPersonal, fila));

                    }
                    else if (Rol == "Administrador")
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
        public DataTable ListarTodoTable()
        //Metodo hace consulta y devuelve un datatable con la informacion.
        {
            DataTable dt = new DataTable();
            string consulta = "Select TbPersonal.NroPersonal as Codigo, TbPersonal.Nombre, TbPersonal.Apellido, TbPersonal.Documento,TbPersonal.Tipo_Personal FROM TbPersonal";

            oDatos = new Acceso();
            dt = oDatos.Leer(consulta);

            return dt;

        }
 

    }
}
