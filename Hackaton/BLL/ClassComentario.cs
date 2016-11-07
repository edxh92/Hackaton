using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSet1ComentarioxsdTableAdapters;
using System.Data;
namespace BLL
{
    class ClassComentario
    {
        private ComentarioTableAdapter coment;
        private ComentarioTableAdapter COMENTARIO
        {
            get
            {
                if (coment == null)
                    coment = new ComentarioTableAdapter();
                return coment;
            }
        }
        public DataTable Comentarios(string _user, string _pass)
        {
            DataTable resultado = new DataTable();
            try
            {
                resultado = COMENTARIO.GetDataComentario();
            }
            catch (Exception)
            {
                resultado = null;

            }

            return resultado;
        }
        public bool Comentar(string comentario, int incidente, int usuario)
        {
            bool? exito = false;
            COMENTARIO.sp_InsertarComentario(comentario, incidente, usuario, exito ref );
            return (bool)exito;
        }
    }
}
