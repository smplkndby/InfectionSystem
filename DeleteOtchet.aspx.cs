using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AIS_Infekcii_Web
{
    public partial class DeleteOtchet : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Request.QueryString["id"] != null)
            {
                int id = int.Parse(Request.QueryString["id"]);
                LoadOtchet(id);
            }
        }

        private void LoadOtchet(int id)
        {
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            string query = "SELECT NazvanieBolezni, DataOtcheta FROM Otchet WHERE OtchetId = @id";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblBolezn.Text = reader["NazvanieBolezni"].ToString();
                    lblData.Text = Convert.ToDateTime(reader["DataOtcheta"]).ToShortDateString();
                }
                else
                {
                    lblMessage.Text = "Запись не найдена.";
                    btnDelete.Enabled = false;
                }
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                int id = int.Parse(Request.QueryString["id"]);

                string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
                string query = "DELETE FROM Otchet WHERE OtchetId = @id";

                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                Response.Redirect("OtchetyClassic.aspx");
            }
        }
    }
}