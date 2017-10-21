namespace FSW_GUI
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.startBtn = new System.Windows.Forms.Button();
			this.stopBtn = new System.Windows.Forms.Button();
			this.saveToDB = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.pathBox = new System.Windows.Forms.TextBox();
			this.dataOut = new System.Windows.Forms.DataGridView();
			this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Extension = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.extensionDropDown = new System.Windows.Forms.ComboBox();
			this.extensionBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
			this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataOut)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// startBtn
			// 
			this.startBtn.Location = new System.Drawing.Point(57, 111);
			this.startBtn.Name = "startBtn";
			this.startBtn.Size = new System.Drawing.Size(75, 23);
			this.startBtn.TabIndex = 0;
			this.startBtn.Text = "Start";
			this.startBtn.UseVisualStyleBackColor = true;
			this.startBtn.Click += new System.EventHandler(this.button1_Click);
			// 
			// stopBtn
			// 
			this.stopBtn.Location = new System.Drawing.Point(138, 111);
			this.stopBtn.Name = "stopBtn";
			this.stopBtn.Size = new System.Drawing.Size(75, 23);
			this.stopBtn.TabIndex = 1;
			this.stopBtn.Text = "Stop";
			this.stopBtn.UseVisualStyleBackColor = true;
			this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
			// 
			// saveToDB
			// 
			this.saveToDB.Location = new System.Drawing.Point(643, 408);
			this.saveToDB.Name = "saveToDB";
			this.saveToDB.Size = new System.Drawing.Size(115, 23);
			this.saveToDB.TabIndex = 2;
			this.saveToDB.Text = "Save to Database";
			this.saveToDB.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(770, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// queryToolStripMenuItem
			// 
			this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
			this.queryToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
			this.queryToolStripMenuItem.Text = "Q&uery";
			this.queryToolStripMenuItem.Click += new System.EventHandler(this.queryToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Path to Watch:";
			// 
			// pathBox
			// 
			this.pathBox.Location = new System.Drawing.Point(12, 85);
			this.pathBox.Name = "pathBox";
			this.pathBox.Size = new System.Drawing.Size(201, 20);
			this.pathBox.TabIndex = 5;
			// 
			// dataOut
			// 
			this.dataOut.AllowUserToAddRows = false;
			this.dataOut.AllowUserToDeleteRows = false;
			this.dataOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FileName,
            this.Path,
            this.Event,
            this.Extension,
            this.Date});
			this.dataOut.Location = new System.Drawing.Point(12, 158);
			this.dataOut.Name = "dataOut";
			this.dataOut.Size = new System.Drawing.Size(746, 244);
			this.dataOut.TabIndex = 7;
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
			// extensionDropDown
			// 
			this.extensionDropDown.FormattingEnabled = true;
			this.extensionDropDown.Items.AddRange(new object[] {
            "txt",
            "doc",
            "exe",
            "pdf",
            "jpg"});
			this.extensionDropDown.Location = new System.Drawing.Point(273, 111);
			this.extensionDropDown.Name = "extensionDropDown";
			this.extensionDropDown.Size = new System.Drawing.Size(68, 21);
			this.extensionDropDown.TabIndex = 8;
			this.extensionDropDown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// extensionBox
			// 
			this.extensionBox.Location = new System.Drawing.Point(273, 85);
			this.extensionBox.Name = "extensionBox";
			this.extensionBox.Size = new System.Drawing.Size(68, 20);
			this.extensionBox.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(270, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(197, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Extension to watch: (EMTPY- Watch all)";
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(770, 25);
			this.toolStrip1.TabIndex = 11;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "toolStripButton1";
			this.toolStripButton1.ToolTipText = "Review saved data";
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "toolStripButton2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(770, 454);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.extensionBox);
			this.Controls.Add(this.extensionDropDown);
			this.Controls.Add(this.dataOut);
			this.Controls.Add(this.pathBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.saveToDB);
			this.Controls.Add(this.stopBtn);
			this.Controls.Add(this.startBtn);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataOut)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button startBtn;
		private System.Windows.Forms.Button stopBtn;
		private System.Windows.Forms.Button saveToDB;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox pathBox;
		private System.Windows.Forms.DataGridView dataOut;
		private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Path;
		private System.Windows.Forms.DataGridViewTextBoxColumn Event;
		private System.Windows.Forms.DataGridViewTextBoxColumn Extension;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date;
		private System.Windows.Forms.ComboBox extensionDropDown;
		private System.Windows.Forms.TextBox extensionBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ToolTip toolTip2;
		private System.Windows.Forms.ToolTip toolTip3;
	}
}

