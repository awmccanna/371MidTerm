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
using System.IO;

namespace FSW_GUI
{
	
	public partial class Form1 : Form
	{
		private SQLiteConnection dbConn;
		private SQLiteCommand dbCmd;
		private SQLiteDataReader dbDataReader;
		private Form subForm;
		private FileSystemWatcher watcher;
		private delegate void SetTextCallback(String[] toPrint);
		public Form1()
		{
			subForm = new Form2();
			subForm.Owner = this;
			watcher = new FileSystemWatcher();

			//Setting up the watcher options. 
			watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
			watcher.Changed += new FileSystemEventHandler(OnChanged);
			watcher.Created += new FileSystemEventHandler(OnChanged);
			watcher.Deleted += new FileSystemEventHandler(OnChanged);
			watcher.Renamed += new RenamedEventHandler(OnRenamed);

			InitializeComponent();
			

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
			try
			{
				dbConn.Close();
			} catch(Exception e){
				//database was already closed, do nothing.
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		//Start button clicked
		private void button1_Click(object sender, EventArgs e)
		{
			
			String path = pathBox.Text;
			String ext = extensionBox.Text;

			if (ext != "")
			{
				watcher.Filter = ext;
			}

			//Begins the watcher if the path is valid. Otherwise, will prompt the user to enter a valid path
			//Also opens database connection
			try
			{

				watcher.Path = path;
				ConnectToDatabase();
				startBtn.Enabled = false;
				watcher.EnableRaisingEvents = true;

			}
			catch (ArgumentException ae){
				MessageBox.Show("Invalid path, please re-enter.");
				pathBox.Focus();
			}







		}
		private void OnChanged(object sender, FileSystemEventArgs e)
		{
			String[] extArray = e.Name.Split('.');
			String ext = extArray[extArray.Length - 1];
			String name = extArray[0];
			string[] newRow = { name, e.FullPath, e.ChangeType.ToString(), ext, DateTime.Now.ToString() };
			setText(newRow);
		}
		private void OnRenamed(object sender, RenamedEventArgs e)
		{
			String[] extArray = e.Name.Split('.');
			String ext = extArray[extArray.Length - 1];
			String name = extArray[0];
			String[] oldNameArray = e.OldName.Split('.');
			String oldName = oldNameArray[0];


			string[] newRow = { oldName + " -> " + name, e.FullPath, e.ChangeType.ToString(), ext, DateTime.Now.ToString() };
			setText(newRow);
		}


		private void setText(String[] toPrint)
		{
			if(this.dataOut.InvokeRequired)
			{
				SetTextCallback d = new SetTextCallback(setText);
				this.Invoke(d, new Object[] { toPrint });
			}
			else
			{
				this.dataOut.Rows.Add(toPrint);
			}
		}


		private void databaseInsert(String[] row)
		{
			dbCmd.CommandText = "INSERT INTO Test ('FileName', 'Path', 'Event', 'Extension', 'Date') VALUES(@fName, @path, @event, @ext, @date) ";
			dbCmd.Prepare();

			dbCmd.Parameters.AddWithValue("@fName", row[1]);
			dbCmd.Parameters.AddWithValue("@path", row[2]);
			dbCmd.Parameters.AddWithValue("@event", row[3]);
			dbCmd.Parameters.AddWithValue("@ext", row[4]);
			dbCmd.Parameters.AddWithValue("@date", row[5]);
			dbCmd.ExecuteNonQuery();

		}











		private void stopBtn_Click(object sender, EventArgs e)
		{
			watcher.EnableRaisingEvents = false;
			DisconnectFromDatabase();
			startBtn.Enabled = true;
		}

















		//function for testing database
		private void testQuery()
		{
			dbCmd.CommandText = "SELECT * FROM Test";
			dbDataReader = dbCmd.ExecuteReader();

			while (dbDataReader.Read())
			{
				
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

		private void queryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			subForm.Show();
		}

		
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			extensionBox.Text = extensionDropDown.Text;
		}
	}
}
