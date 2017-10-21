using System.Windows.Forms;

namespace FSW_GUI
{
	internal class Form2 : Form
	{
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem exitToolStripMenuItem;
		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn FileName;
		private DataGridViewTextBoxColumn Path;
		private DataGridViewTextBoxColumn Event;
		private DataGridViewTextBoxColumn Extension;
		private DataGridViewTextBoxColumn Date;
		private Button queryBtn;
		private Label label2;
		private TextBox extensionBox;
		private ComboBox extensionDropDown;
		private Button closeBtn;
		private MenuStrip menuStrip1;

		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.queryBtn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.extensionBox = new System.Windows.Forms.TextBox();
			this.extensionDropDown = new System.Windows.Forms.ComboBox();
			this.closeBtn = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(647, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.Path,
            this.Event,
            this.Extension,
            this.Date});
			this.dataGridView1.Location = new System.Drawing.Point(12, 96);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(623, 270);
			this.dataGridView1.TabIndex = 8;
			// 
			// FileName
			// 
			this.FileName.HeaderText = "File Name";
			this.FileName.Name = "FileName";
			// 
			// Path
			// 
			this.Path.HeaderText = "Path";
			this.Path.Name = "Path";
			// 
			// Event
			// 
			this.Event.HeaderText = "Event";
			this.Event.Name = "Event";
			// 
			// Extension
			// 
			this.Extension.HeaderText = "Extension";
			this.Extension.Name = "Extension";
			// 
			// Date
			// 
			this.Date.HeaderText = "Date";
			this.Date.Name = "Date";
			// 
			// queryBtn
			// 
			this.queryBtn.Location = new System.Drawing.Point(121, 43);
			this.queryBtn.Name = "queryBtn";
			this.queryBtn.Size = new System.Drawing.Size(98, 23);
			this.queryBtn.TabIndex = 9;
			this.queryBtn.Text = "Query Database";
			this.queryBtn.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(181, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Extension to search for: (EMTPY- All)";
			// 
			// extensionBox
			// 
			this.extensionBox.Location = new System.Drawing.Point(25, 43);
			this.extensionBox.Name = "extensionBox";
			this.extensionBox.Size = new System.Drawing.Size(68, 20);
			this.extensionBox.TabIndex = 12;
			// 
			// extensionDropDown
			// 
			this.extensionDropDown.FormattingEnabled = true;
			this.extensionDropDown.Items.AddRange(new object[] {
            "txt",
            "doc",
            "exe",
            "pdf",
            "jpg"});
			this.extensionDropDown.Location = new System.Drawing.Point(25, 69);
			this.extensionDropDown.Name = "extensionDropDown";
			this.extensionDropDown.Size = new System.Drawing.Size(68, 21);
			this.extensionDropDown.TabIndex = 11;
			this.extensionDropDown.SelectedIndexChanged += new System.EventHandler(this.extensionDropDown_SelectedIndexChanged);
			// 
			// closeBtn
			// 
			this.closeBtn.Location = new System.Drawing.Point(560, 374);
			this.closeBtn.Name = "closeBtn";
			this.closeBtn.Size = new System.Drawing.Size(75, 23);
			this.closeBtn.TabIndex = 14;
			this.closeBtn.Text = "Close";
			this.closeBtn.UseVisualStyleBackColor = true;
			this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
			// 
			// Form2
			// 
			this.ClientSize = new System.Drawing.Size(647, 409);
			this.Controls.Add(this.closeBtn);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.extensionBox);
			this.Controls.Add(this.extensionDropDown);
			this.Controls.Add(this.queryBtn);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form2";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		public Form2()
		{
			InitializeComponent();
		}
		private void extensionDropDown_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			extensionBox.Text = extensionDropDown.Text;
		}

		private void closeBtn_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}