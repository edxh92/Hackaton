using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace UI
{
    public partial class WFPorFechas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClassIncidente LgIncidente = new ClassIncidente();
            this.GridView1.DataSource = LgIncidente.ListaFecha();
            this.GridView1.DataBind();
        }
    }
}