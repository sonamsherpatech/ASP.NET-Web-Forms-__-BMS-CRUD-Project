using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD_Application
{
	public partial class ReadBook : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			int row = 1;
			MySqlConnection con = new MySqlConnection("server=localhost;database=library;uid=root;password='';");
			con.Open();

			string sql = "SELECT * FROM books";
			MySqlCommand cmd = new MySqlCommand(sql, con);
			MySqlDataReader dr = cmd.ExecuteReader();
			while(dr.Read())
			{
				int id = int.Parse(dr[0].ToString());
				TableRow tr = new TableRow();
				TableCell snCell = new TableCell();
				snCell.Text = row.ToString();
				tr.Cells.Add(snCell);

                TableCell titleCell = new TableCell();
                titleCell.Text = dr[1].ToString();
                tr.Cells.Add(titleCell);

                TableCell authorCell = new TableCell();
                authorCell.Text = dr[2].ToString();
                tr.Cells.Add(authorCell);

                TableCell genreCell = new TableCell();
                genreCell.Text = dr[3].ToString();
                tr.Cells.Add(genreCell);

                TableCell priceCell = new TableCell();
                priceCell.Text = dr[4].ToString();
                tr.Cells.Add(priceCell);

				TableCell action = new TableCell();
				action.Text = $"<a href='UpdateBook.aspx?id={id}'>Update</a> | " +
							$"<a href='DeleteBook.aspx?id={id}' onclick='return confirm(\"Are you sure?\")'>Delete</a>";
                tr.Cells.Add(action);

                tblBook.Rows.Add(tr);
                row++;
            }
			con.Close();

		}
	}
}