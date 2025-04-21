using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AIS_Infekcii_Web
{
    public partial class OtchetyClassic : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadOtchety();
            }
        }

        private void LoadOtchety()
        {
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            string query = "SELECT OtchetId, NazvanieBolezni, KolichestvoZabolevshih, DataOtcheta, RajonId FROM Otchet";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void GridView1_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            // (не используется, оставлено на случай будущих функций)
        }
    }
}