﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetLoginTableAdapters;
using System.Data;

namespace BLL
{
    public class ClasslLog
    {
        private UsuarioTableAdapter  _log;
        private UsuarioTableAdapter LOG
        {
            get
            {
                if (_log == null)
                    _log = new UsuarioTableAdapter();
                return _log;
            }
        }
             public DataTable Inicio(string _user, string _pass)
        {
            DataTable resultado = new DataTable();
            try
            {
                resultado = LOG.GetDataSpLogin(_user, _pass);
            }
            catch (Exception)
            {
                resultado = null;
            }

            return resultado;
        }


        public string Ingresar(string nombre, string correo, string password,string imagen)
        {
            string mensaje = "";
            try
            {
                LOG.sp_IngresoUsuario(nombre, correo, password, imagen, ref mensaje);
            }
            catch (Exception )
            {

                mensaje = "Error al ingresar";
            }
            return mensaje;
        }
    
    }
}
