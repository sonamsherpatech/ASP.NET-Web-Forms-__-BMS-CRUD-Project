using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD_Application
{
	public partial class InsertBook : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
			string title = txtTitle.Text;
			string author = txtAuthor.Text;
			string genre = txtGenre.Text;
			double price = double.Parse(txtPrice.Text);

			MySqlConnection con = new MySqlConnection("server=localhost;database=library;uid=root;password='';");
			con.Open();

			string sql = $"INSERT INTO books (`title`,`author`,`genre`,`price`) VALUES ('{title}','{author}','{genre}',{price})";
			MySqlCommand cmd = new MySqlCommand(sql, con);

			int row = cmd.ExecuteNonQuery();
			if(row> 0)
			{
				Response.Redirect("ReadBook.aspx");
			}
        }
    }
}