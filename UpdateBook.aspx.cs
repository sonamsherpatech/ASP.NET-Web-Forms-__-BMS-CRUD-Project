using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD_Application
{
	public partial class UpdateBook : System.Web.UI.Page
	{
		private const string ConStr = "server=localhost;database=library;uid=root;password=''";
		protected void Page_Load(object sender, EventArgs e)
		{
			if(!IsPostBack)
			{

			int id = int.Parse(Request.QueryString["id"]);
			MySqlConnection con = new MySqlConnection(ConStr);
			con.Open();

			string sql = $"SELECT * FROM books WHERE `book_id` = {id}";
			MySqlCommand cmd = new MySqlCommand(sql, con);

			MySqlDataReader dr = cmd.ExecuteReader();
			if (dr.Read())
			{
				txtTitle.Text = dr[1].ToString();
				txtAuthor.Text = dr[2].ToString();
				txtGenre.Text = dr[3].ToString();
				txtPrice.Text = dr[4].ToString();
			}
			con.Close();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request.QueryString["id"]);
            MySqlConnection con = new MySqlConnection(ConStr);
            con.Open();

			string title = txtTitle.Text;
			string author = txtAuthor.Text;
			string genre = txtGenre.Text;
			double price = double.Parse(txtPrice.Text);

			string sql = $"UPDATE books SET `title` = '{title}', `author` = '{author}', `genre` = '{genre}', `price` = {price} WHERE `book_id` = {id}";
			MySqlCommand cmd = new MySqlCommand(sql, con);

			int row = cmd.ExecuteNonQuery();
			if(row > 0)
			{
				Response.Redirect("ReadBook.aspx");
			}
            else
            {
                Response.Write("No rows were updated. Check your ID or input values.");
            }


        }
    }
}