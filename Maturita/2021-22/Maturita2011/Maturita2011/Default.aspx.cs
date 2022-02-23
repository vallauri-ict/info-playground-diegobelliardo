using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Maturita2011
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DbTools db = new DbTools();

                string sql = "SELECT nome FROM parchi";
                NomeParco.Text = db.GetDataList(sql)[0];

                sql = "SELECT * FROM specie";
                rptTable.DataSource = db.GetDataTable(sql);
                rptTable.DataBind();

            }
        }
    }
}