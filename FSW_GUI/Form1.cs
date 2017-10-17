using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace FSW_GUI
{
	public partial class Form1 : Form
	{
		SQLiteConnection dbConn;
		SQLiteCommand dbCmd;
		SQLiteDataReader dbDataReader;

		public Form1()
		{
			
			InitializeComponent();

		}

		private void ConnectToDatabase()
		{
			dbConn = new SQLiteConnection("Data Source=database.db;Version = 3;New=True;Compress=True;");
			dbConn.Open();
			dbCmd = dbConn.CreateCommand();
			dbCmd.CommandText = "CREATE TABLE IF NOT EXISTS [Test](" +
								"[FileName] VARCHAR(50) DEFAULT 'FakeFile'," +
								"[Path] VARCHAR(50) DEFAULT 'C:\\User'," +
								"[Event] VARCHAR(40) DEFAULT 'Created'," +
								"[Extension] VARCHAR(10) DEFAULT '.txt'," +
								"[Date] DATETIME DEFAULT CURRENT_TIMESTAMP" +
								")";

			dbCmd.ExecuteNonQuery();

			//dbCmd.CommandText = "INSERT INTO Test DEFAULT VALUES";
			//dbCmd.ExecuteNonQuery();
			dbCmd.CommandText = "SELECT * FROM Test";
			dbDataReader = dbCmd.ExecuteReader();

			while (dbDataReader.Read())
			{
				Console.WriteLine(dbDataReader["FileName"] + " " + dbDataReader["Path"] + " " + dbDataReader["Event"] + " " + dbDataReader["Extension"] + " " + dbDataReader["Date"]);
			}
			dbConn.Close();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ConnectToDatabase();
		}
	}
}
