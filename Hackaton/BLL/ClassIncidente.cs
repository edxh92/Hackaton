using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetIncidenteTableAdapters;
using System.Data;

namespace BLL
{
    public   class ClassIncidente
    {
        #region Atributos 
        IncidenteTableAdapter incidente = new IncidenteTableAdapter();

        #endregion
        #region Propiedades
        IncidenteTableAdapter INCIDENTE
        {
            get { return incidente; }
        }
        #endregion

        #region Metodos
        public string InsertarIncidente(string nivel, string direccion ,string aspecto,string foto,string latitud, string longitud,string idtipo  )
        {
            string respuesta = "";
            try
            {
                INCIDENTE.sp_InsertarIncidente(Convert.ToSingle(nivel), direccion, aspecto,foto, Convert.ToSingle(latitud), Convert.ToSingle(longitud), Convert.ToInt32(idtipo), ref respuesta);
            }
            catch (Exception error)
            {

                respuesta = error.Message;
            }
            return respuesta;
        }
        #endregion


        public DataTable ListarPorFechas()
        {
            return INCIDENTE.GetDataPorFechas();
        }
        public DataTable ListarPorNiveImportancia()
        {
            return INCIDENTE.GetDataNivelDeImportancia();
        }
        public DataTable ListarAspectos(string variable)
        {
            return INCIDENTE.GetDataBuscarPorAspectos(variable);
        }
        public DataTable ListarPorCategorias(string variable)
        {
            return INCIDENTE.GetDataBuscarPorCategorias(variable);
        }

        DataTable1TableAdapter fechas = new DataTable1TableAdapter();
        DataTable1TableAdapter FECHAS
        {
            get { return fechas; }
        }
        public DataTable ListaFecha()
        {
            return FECHAS.GetDataFechas();
        }
        public DataTable PorImportancia()
        {
            return FECHAS.GetDataPorImportancia();
        }
        public DataTable PorCategoria(string dato)
        {
            return FECHAS.GetDataBuscaCategorias(dato);
        }
        DataTable2TableAdapter dos = new DataTable2TableAdapter();
        DataTable2TableAdapter DOS
        {
            get { return dos; }
        }
        public DataTable porAspecto(string valor)
        {
            return DOS.GetDataPorAspectos(valor);
        }

       
    }
}
