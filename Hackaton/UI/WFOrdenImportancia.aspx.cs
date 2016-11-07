using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace UI
{
    public partial class WFOrdenImportancia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClassIncidente LgIncidente = new ClassIncidente();
            this.GridView1.DataSource = LgIncidente.PorImportancia();
            this.GridView1.DataBind();
        }
    }
}