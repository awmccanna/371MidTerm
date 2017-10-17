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
			ConnectToDatabase();

		}

		
		/*
		 * Connects to the SQLite database
		 * Attempts to create the appropriate table if the table doesn't already exist
		 */
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
			
		}

		private void DisconnectFromDatabase()
		{
			dbConn.Close();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			testQuery();
		}

		//function for testing database
		private void testQuery()
		{
			dbCmd.CommandText = "SELECT * FROM Test";
			dbDataReader = dbCmd.ExecuteReader();

			while (dbDataReader.Read())
			{
				string[] newRow = { dbDataReader["FileName"].ToString(), dbDataReader["Path"].ToString(), dbDataReader["Event"].ToString(), dbDataReader["Extension"].ToString(), dbDataReader["Date"].ToString() };
				dataGridView1.Rows.Add(newRow);
			}
		}

		/*
		 * When the form is closing, there will be a prompt to save everything to the database,
		 *Followed by closing the database before exiting.
		 */
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			// TODO add check on exit.
			DisconnectFromDatabase();
			Console.WriteLine("database closed");
		}
	}
}
