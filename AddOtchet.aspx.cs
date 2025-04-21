using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AIS_Infekcii_Web
{
    public partial class AddOtchet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string nazvanie = txtBolezn.Text;
            int kolvo = int.Parse(txtKolvo.Text);
            DateTime data = DateTime.Parse(txtData.Text);
            int rajonId = int.Parse(txtRajonId.Text);

            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            string query = "INSERT INTO Otchet (NazvanieBolezni, KolichestvoZabolevshih, DataOtcheta, RajonId) VALUES (@nazvanie, @kolvo, @data, @rajonId)";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@nazvanie", nazvanie);
                cmd.Parameters.AddWithValue("@kolvo", kolvo);
                cmd.Parameters.AddWithValue("@data", data);
                cmd.Parameters.AddWithValue("@rajonId", rajonId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            Response.Redirect("OtchetyClassic.aspx");
        }
    }
}