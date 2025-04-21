using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AIS_Infekcii_Web
{
    public partial class EditOtchet : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    int id = int.Parse(Request.QueryString["id"]);
                    LoadOtchet(id);
                }
                else
                {
                    lblMessage.Text = "ID не передан в адресной строке.";
                }
            }
        }

        private void LoadOtchet(int id)
        {
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            string query = "SELECT * FROM Otchet WHERE OtchetId = @id";

            using (SqlConnection conn = new SqlConnection(connStr))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtBolezn.Text = reader["NazvanieBolezni"].ToString();
                    txtKolvo.Text = reader["KolichestvoZabolevshih"].ToString();
                    txtData.Text = Convert.ToDateTime(reader["DataOtcheta"]).ToString("yyyy-MM-dd");
                    txtRajonId.Text = reader["RajonId"].ToString();
                }
                else
                {
                    lblMessage.Text = "Запись не найдена.";
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                int id = int.Parse(Request.QueryString["id"]);
                string bolezn = txtBolezn.Text;
                int kolvo = int.Parse(txtKolvo.Text);
                DateTime data = DateTime.Parse(txtData.Text);
                int rajonId = int.Parse(txtRajonId.Text);

                string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
                string query = "UPDATE Otchet SET NazvanieBolezni=@Bolezn, KolichestvoZabolevshih=@Kolvo, DataOtcheta=@Data, RajonId=@RajonId WHERE OtchetId=@Id";

                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Bolezn", bolezn);
                    cmd.Parameters.AddWithValue("@Kolvo", kolvo);
                    cmd.Parameters.AddWithValue("@Data", data);
                    cmd.Parameters.AddWithValue("@RajonId", rajonId);
                    cmd.Parameters.AddWithValue("@Id", id);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                Response.Redirect("OtchetyClassic.aspx");
            }
        }
    }
}