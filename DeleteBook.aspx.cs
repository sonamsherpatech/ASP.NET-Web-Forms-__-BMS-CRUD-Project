using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD_Application
{
	public partial class DeleteBook : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			int id = int.Parse(Request.QueryString["id"].ToString());
			MySqlConnection con = new MySqlConnection("server=localhost;database=library;uid=root;password=''");
			con.Open();


			string sql = $"DELETE FROM books WHERE `book_id` = {id}";

			MySqlCommand cmd = new MySqlCommand(sql, con);
			int row = cmd.ExecuteNonQuery();
			if (row > 0)
				Response.Redirect("ReadBook.aspx");
		}
	}
}