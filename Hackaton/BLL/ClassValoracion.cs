using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetValoracionTableAdapters;


namespace BLL
{
    public class ClassValoracion
    {
        private ValoracionTableAdapter _valoracion;

        private ValoracionTableAdapter VALORACION
        {
            get
            {
                if (_valoracion == null)
                    _valoracion = new ValoracionTableAdapter();
                return _valoracion;
            }

        }
        public string InsertarValoracion(string valoracion,string incidente,string usuario)
        {
            string mensaje = "";
            try
            {
                VALORACION.sp_InsertarValoracion(Convert.ToInt32(valoracion), Convert.ToInt32(incidente), Convert.ToInt32(usuario), ref mensaje);
            }
            catch (Exception error)
            {
                mensaje = error.Message;
            }
           
            return mensaje;
        }
    }
}
