
namespace PeakPracticeWinFormsApp
{
    partial class PeakCanForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CanConnectiongroupBox = new System.Windows.Forms.GroupBox();
            this.Initializebutton = new System.Windows.Forms.Button();
            this.disconnectbutton = new System.Windows.Forms.Button();
            this.BitratecomboBox = new System.Windows.Forms.ComboBox();
            this.Bitratelabel = new System.Windows.Forms.Label();
            this.PcanChannellabel = new System.Windows.Forms.Label();
            this.PcanChannelcomboBox = new System.Windows.Forms.ComboBox();
            this.BroadcastgroupBox = new System.Windows.Forms.GroupBox();
            this.removebutton = new System.Windows.Forms.Button();
            this.Stopbutton = new System.Windows.Forms.Button();
            this.BroadcastdataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Startbutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.datenlabel = new System.Windows.Forms.Label();
            this.datentextBox = new System.Windows.Forms.TextBox();
            this.längelabel = new System.Windows.Forms.Label();
            this.längetextBox = new System.Windows.Forms.TextBox();
            this.Idlabel = new System.Windows.Forms.Label();
            this.IdtextBox = new System.Windows.Forms.TextBox();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CanDatenlistBox = new System.Windows.Forms.ListBox();
            this.CanConnectiongroupBox.SuspendLayout();
            this.BroadcastgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BroadcastdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CanConnectiongroupBox
            // 
            this.CanConnectiongroupBox.Controls.Add(this.Initializebutton);
            this.CanConnectiongroupBox.Controls.Add(this.disconnectbutton);
            this.CanConnectiongroupBox.Controls.Add(this.BitratecomboBox);
            this.CanConnectiongroupBox.Controls.Add(this.Bitratelabel);
            this.CanConnectiongroupBox.Controls.Add(this.PcanChannellabel);
            this.CanConnectiongroupBox.Controls.Add(this.PcanChannelcomboBox);
            this.CanConnectiongroupBox.Location = new System.Drawing.Point(18, 12);
            this.CanConnectiongroupBox.Name = "CanConnectiongroupBox";
            this.CanConnectiongroupBox.Size = new System.Drawing.Size(511, 100);
            this.CanConnectiongroupBox.TabIndex = 0;
            this.CanConnectiongroupBox.TabStop = false;
            this.CanConnectiongroupBox.Text = "Can Connection";
            // 
            // Initializebutton
            // 
            this.Initializebutton.Location = new System.Drawing.Point(427, 22);
            this.Initializebutton.Name = "Initializebutton";
            this.Initializebutton.Size = new System.Drawing.Size(75, 32);
            this.Initializebutton.TabIndex = 1;
            this.Initializebutton.Text = "Initialize";
            this.Initializebutton.UseVisualStyleBackColor = true;
            this.Initializebutton.Click += new System.EventHandler(this.Initializebutton_Click);
            // 
            // disconnectbutton
            // 
            this.disconnectbutton.Location = new System.Drawing.Point(427, 62);
            this.disconnectbutton.Name = "disconnectbutton";
            this.disconnectbutton.Size = new System.Drawing.Size(75, 32);
            this.disconnectbutton.TabIndex = 2;
            this.disconnectbutton.Text = "Disconnect";
            this.disconnectbutton.UseVisualStyleBackColor = true;
            this.disconnectbutton.Click += new System.EventHandler(this.disconnectbutton_Click);
            // 
            // BitratecomboBox
            // 
            this.BitratecomboBox.FormattingEnabled = true;
            this.BitratecomboBox.Location = new System.Drawing.Point(278, 22);
            this.BitratecomboBox.Name = "BitratecomboBox";
            this.BitratecomboBox.Size = new System.Drawing.Size(121, 23);
            this.BitratecomboBox.TabIndex = 4;
            // 
            // Bitratelabel
            // 
            this.Bitratelabel.AutoSize = true;
            this.Bitratelabel.Location = new System.Drawing.Point(228, 25);
            this.Bitratelabel.Name = "Bitratelabel";
            this.Bitratelabel.Size = new System.Drawing.Size(44, 15);
            this.Bitratelabel.TabIndex = 3;
            this.Bitratelabel.Text = "Bitrate:";
            // 
            // PcanChannellabel
            // 
            this.PcanChannellabel.AutoSize = true;
            this.PcanChannellabel.Location = new System.Drawing.Point(6, 25);
            this.PcanChannellabel.Name = "PcanChannellabel";
            this.PcanChannellabel.Size = new System.Drawing.Size(80, 15);
            this.PcanChannellabel.TabIndex = 2;
            this.PcanChannellabel.Text = "PcanChannel:";
            // 
            // PcanChannelcomboBox
            // 
            this.PcanChannelcomboBox.FormattingEnabled = true;
            this.PcanChannelcomboBox.Location = new System.Drawing.Point(101, 22);
            this.PcanChannelcomboBox.Name = "PcanChannelcomboBox";
            this.PcanChannelcomboBox.Size = new System.Drawing.Size(121, 23);
            this.PcanChannelcomboBox.TabIndex = 1;
            // 
            // BroadcastgroupBox
            // 
            this.BroadcastgroupBox.Controls.Add(this.removebutton);
            this.BroadcastgroupBox.Controls.Add(this.Stopbutton);
            this.BroadcastgroupBox.Controls.Add(this.BroadcastdataGridView);
            this.BroadcastgroupBox.Controls.Add(this.Startbutton);
            this.BroadcastgroupBox.Controls.Add(this.addbutton);
            this.BroadcastgroupBox.Controls.Add(this.datenlabel);
            this.BroadcastgroupBox.Controls.Add(this.datentextBox);
            this.BroadcastgroupBox.Controls.Add(this.längelabel);
            this.BroadcastgroupBox.Controls.Add(this.längetextBox);
            this.BroadcastgroupBox.Controls.Add(this.Idlabel);
            this.BroadcastgroupBox.Controls.Add(this.IdtextBox);
            this.BroadcastgroupBox.Enabled = false;
            this.BroadcastgroupBox.Location = new System.Drawing.Point(18, 137);
            this.BroadcastgroupBox.Name = "BroadcastgroupBox";
            this.BroadcastgroupBox.Size = new System.Drawing.Size(511, 266);
            this.BroadcastgroupBox.TabIndex = 2;
            this.BroadcastgroupBox.TabStop = false;
            this.BroadcastgroupBox.Text = "Broadcast";
            // 
            // removebutton
            // 
            this.removebutton.Location = new System.Drawing.Point(445, 120);
            this.removebutton.Name = "removebutton";
            this.removebutton.Size = new System.Drawing.Size(60, 23);
            this.removebutton.TabIndex = 10;
            this.removebutton.Text = "Remove";
            this.removebutton.UseVisualStyleBackColor = true;
            this.removebutton.Click += new System.EventHandler(this.removebutton_Click);
            // 
            // Stopbutton
            // 
            this.Stopbutton.Location = new System.Drawing.Point(249, 206);
            this.Stopbutton.Name = "Stopbutton";
            this.Stopbutton.Size = new System.Drawing.Size(122, 54);
            this.Stopbutton.TabIndex = 9;
            this.Stopbutton.Text = "Stop";
            this.Stopbutton.UseVisualStyleBackColor = true;
            this.Stopbutton.Click += new System.EventHandler(this.Stopbutton_Click);
            // 
            // BroadcastdataGridView
            // 
            this.BroadcastdataGridView.AllowUserToAddRows = false;
            this.BroadcastdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BroadcastdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.BroadcastdataGridView.Location = new System.Drawing.Point(6, 81);
            this.BroadcastdataGridView.Name = "BroadcastdataGridView";
            this.BroadcastdataGridView.ReadOnly = true;
            this.BroadcastdataGridView.RowTemplate.Height = 25;
            this.BroadcastdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BroadcastdataGridView.Size = new System.Drawing.Size(433, 105);
            this.BroadcastdataGridView.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Index";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Message";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Interval";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Active";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Startbutton
            // 
            this.Startbutton.Enabled = false;
            this.Startbutton.Location = new System.Drawing.Point(121, 206);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(122, 54);
            this.Startbutton.TabIndex = 8;
            this.Startbutton.Text = "Start";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(451, 22);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(60, 23);
            this.addbutton.TabIndex = 7;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // datenlabel
            // 
            this.datenlabel.AutoSize = true;
            this.datenlabel.Location = new System.Drawing.Point(292, 25);
            this.datenlabel.Name = "datenlabel";
            this.datenlabel.Size = new System.Drawing.Size(41, 15);
            this.datenlabel.TabIndex = 5;
            this.datenlabel.Text = "Daten:";
            // 
            // datentextBox
            // 
            this.datentextBox.Location = new System.Drawing.Point(339, 22);
            this.datentextBox.Name = "datentextBox";
            this.datentextBox.Size = new System.Drawing.Size(100, 23);
            this.datentextBox.TabIndex = 4;
            // 
            // längelabel
            // 
            this.längelabel.AutoSize = true;
            this.längelabel.Location = new System.Drawing.Point(138, 25);
            this.längelabel.Name = "längelabel";
            this.längelabel.Size = new System.Drawing.Size(47, 15);
            this.längelabel.TabIndex = 3;
            this.längelabel.Text = "Length:";
            // 
            // längetextBox
            // 
            this.längetextBox.Location = new System.Drawing.Point(186, 22);
            this.längetextBox.Name = "längetextBox";
            this.längetextBox.Size = new System.Drawing.Size(100, 23);
            this.längetextBox.TabIndex = 2;
            // 
            // Idlabel
            // 
            this.Idlabel.AutoSize = true;
            this.Idlabel.Location = new System.Drawing.Point(6, 25);
            this.Idlabel.Name = "Idlabel";
            this.Idlabel.Size = new System.Drawing.Size(20, 15);
            this.Idlabel.TabIndex = 1;
            this.Idlabel.Text = "Id:";
            // 
            // IdtextBox
            // 
            this.IdtextBox.Location = new System.Drawing.Point(32, 22);
            this.IdtextBox.Name = "IdtextBox";
            this.IdtextBox.Size = new System.Drawing.Size(100, 23);
            this.IdtextBox.TabIndex = 0;
            // 
            // Index
            // 
            this.Index.HeaderText = "Index";
            this.Index.Name = "Index";
            // 
            // Interval
            // 
            this.Interval.HeaderText = "Interval";
            this.Interval.Name = "Interval";
            // 
            // CanDatenlistBox
            // 
            this.CanDatenlistBox.FormattingEnabled = true;
            this.CanDatenlistBox.ItemHeight = 15;
            this.CanDatenlistBox.Location = new System.Drawing.Point(18, 409);
            this.CanDatenlistBox.Name = "CanDatenlistBox";
            this.CanDatenlistBox.Size = new System.Drawing.Size(511, 139);
            this.CanDatenlistBox.TabIndex = 1;
            // 
            // PeakCanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 560);
            this.Controls.Add(this.BroadcastgroupBox);
            this.Controls.Add(this.CanDatenlistBox);
            this.Controls.Add(this.CanConnectiongroupBox);
            this.Name = "PeakCanForm";
            this.Text = "PCanPractice";
            this.CanConnectiongroupBox.ResumeLayout(false);
            this.CanConnectiongroupBox.PerformLayout();
            this.BroadcastgroupBox.ResumeLayout(false);
            this.BroadcastgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BroadcastdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CanConnectiongroupBox;
        private System.Windows.Forms.ComboBox PcanChannelcomboBox;
        private System.Windows.Forms.Button Initializebutton;
        private System.Windows.Forms.Button disconnectbutton;
        private System.Windows.Forms.ComboBox BitratecomboBox;
        private System.Windows.Forms.Label Bitratelabel;
        private System.Windows.Forms.Label PcanChannellabel;
        private System.Windows.Forms.GroupBox BroadcastgroupBox;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Label datenlabel;
        private System.Windows.Forms.TextBox datentextBox;
        private System.Windows.Forms.Label längelabel;
        private System.Windows.Forms.TextBox längetextBox;
        private System.Windows.Forms.Label Idlabel;
        private System.Windows.Forms.TextBox IdtextBox;
        private System.Windows.Forms.Button Stopbutton;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.DataGridView BroadcastdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interval;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column4;
        private System.Windows.Forms.Button removebutton;
        private System.Windows.Forms.ListBox CanDatenlistBox;
    }
}
