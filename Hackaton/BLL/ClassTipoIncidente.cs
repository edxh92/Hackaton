using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetTipoIncidenteTableAdapters;
using System.Data;

namespace BLL
{
  public   class ClassTipoIncidente
    {
        #region Atributos
        TipoIncidenteTableAdapter incidente = new TipoIncidenteTableAdapter();

        #endregion
        #region Propiedades
        TipoIncidenteTableAdapter INCIDENTE
        {
            get { return incidente; }
        }
        #endregion

        #region Metodos
        public DataTable Listar()
        {
            return INCIDENTE.GetDataTIpoIncidente();
        }

        public string InsertarIncidente(string nombre, string descripcion)
        {
            string respuesta = "";
            try
            {
                INCIDENTE.sp_InsertarTipoIncidente(nombre, descripcion, ref respuesta);
            }
            catch (Exception error)
            {

                respuesta = error.Message;
            }
            return respuesta;
        }

        public DataTable Buscar(string variable)
        {
            return INCIDENTE.GetDataBuscarIncidentes(variable);
        }
        #endregion
        public DataTable BuscarIncidenteCOnId(int id)
        {
            return INCIDENTE.BuscarIncidente(id);
        }



        #region vistasPorAspectos
        View_TotalPorAspectosTableAdapter vistaaspectos = new View_TotalPorAspectosTableAdapter();
        View_TotalPorAspectosTableAdapter VISTAASPECTOS
        {
            get { return vistaaspectos; }
        }

        public DataTable VistaPorAspectos()
        {
            return VISTAASPECTOS.GetDataVistaPorTotalDeAspectos();
        }



        #endregion

        #region VistasPorCategorias
        View_TotalPorCategoriasTableAdapter vistacategorias = new View_TotalPorCategoriasTableAdapter();
        View_TotalPorCategoriasTableAdapter VISTACATEGORIAS
        {
            get { return vistacategorias; }
        } 

        public DataTable VistaPorCategorias()
        {
            return VISTACATEGORIAS.GetDataListarPorCategorias();
        }
        #endregion


      
    }


}
