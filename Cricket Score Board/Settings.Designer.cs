namespace Cricket_Score_Board
{
    partial class Settings
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
            this.radioAddTeam = new System.Windows.Forms.RadioButton();
            this.radioEditTeam = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBoxAddTeam = new System.Windows.Forms.GroupBox();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.groupBoxEditTeam = new System.Windows.Forms.GroupBox();
            this.ComboBoxEdit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBox_EditTeam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditTeam = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxAddTeam.SuspendLayout();
            this.groupBoxEditTeam.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioAddTeam
            // 
            this.radioAddTeam.AutoSize = true;
            this.radioAddTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAddTeam.Location = new System.Drawing.Point(91, 32);
            this.radioAddTeam.Name = "radioAddTeam";
            this.radioAddTeam.Size = new System.Drawing.Size(100, 24);
            this.radioAddTeam.TabIndex = 2;
            this.radioAddTeam.Text = "Add Team";
            this.radioAddTeam.UseVisualStyleBackColor = true;
            this.radioAddTeam.CheckedChanged += new System.EventHandler(this.radioAddTeam_CheckedChanged);
            // 
            // radioEditTeam
            // 
            this.radioEditTeam.AutoSize = true;
            this.radioEditTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioEditTeam.Location = new System.Drawing.Point(280, 32);
            this.radioEditTeam.Name = "radioEditTeam";
            this.radioEditTeam.Size = new System.Drawing.Size(99, 24);
            this.radioEditTeam.TabIndex = 3;
            this.radioEditTeam.Text = "Edit Team";
            this.radioEditTeam.UseVisualStyleBackColor = true;
            this.radioEditTeam.CheckedChanged += new System.EventHandler(this.radioEditTeam_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(482, 444);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxEditTeam);
            this.tabPage1.Controls.Add(this.groupBoxAddTeam);
            this.tabPage1.Controls.Add(this.radioEditTeam);
            this.tabPage1.Controls.Add(this.radioAddTeam);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(474, 406);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TEAM";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lblName);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.radioButton5);
            this.tabPage2.Controls.Add(this.radioButton6);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(474, 406);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PLAYERS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(518, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 27);
            this.button2.TabIndex = 9;
            this.button2.Text = "Browse ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 62);
            this.button1.TabIndex = 8;
            this.button1.Text = "ADD PLAYER";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Profile Picture";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(44, 120);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 31);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(165, 120);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 31);
            this.textBox1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(484, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 185);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(78, 32);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(103, 24);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Add Player";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(281, 32);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(102, 24);
            this.radioButton6.TabIndex = 3;
            this.radioButton6.Text = "Edit Player";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // groupBoxAddTeam
            // 
            this.groupBoxAddTeam.Controls.Add(this.BtnSave);
            this.groupBoxAddTeam.Controls.Add(this.label2);
            this.groupBoxAddTeam.Controls.Add(this.txtTeamName);
            this.groupBoxAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxAddTeam.Location = new System.Drawing.Point(43, 73);
            this.groupBoxAddTeam.Name = "groupBoxAddTeam";
            this.groupBoxAddTeam.Size = new System.Drawing.Size(378, 290);
            this.groupBoxAddTeam.TabIndex = 4;
            this.groupBoxAddTeam.TabStop = false;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamName.Location = new System.Drawing.Point(67, 130);
            this.txtTeamName.Multiline = true;
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(256, 31);
            this.txtTeamName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ENTER TEAM NAME";
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(142, 191);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(111, 36);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "SAVE";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // groupBoxEditTeam
            // 
            this.groupBoxEditTeam.Controls.Add(this.btnEditTeam);
            this.groupBoxEditTeam.Controls.Add(this.label4);
            this.groupBoxEditTeam.Controls.Add(this.txtBox_EditTeam);
            this.groupBoxEditTeam.Controls.Add(this.label3);
            this.groupBoxEditTeam.Controls.Add(this.ComboBoxEdit);
            this.groupBoxEditTeam.Location = new System.Drawing.Point(43, 73);
            this.groupBoxEditTeam.Name = "groupBoxEditTeam";
            this.groupBoxEditTeam.Size = new System.Drawing.Size(378, 290);
            this.groupBoxEditTeam.TabIndex = 3;
            this.groupBoxEditTeam.TabStop = false;
            // 
            // ComboBoxEdit
            // 
            this.ComboBoxEdit.FormattingEnabled = true;
            this.ComboBoxEdit.Location = new System.Drawing.Point(46, 79);
            this.ComboBoxEdit.Name = "ComboBoxEdit";
            this.ComboBoxEdit.Size = new System.Drawing.Size(288, 33);
            this.ComboBoxEdit.TabIndex = 0;
            this.ComboBoxEdit.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEdit_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "SELECT TO EDIT";
            // 
            // txtBox_EditTeam
            // 
            this.txtBox_EditTeam.Location = new System.Drawing.Point(46, 175);
            this.txtBox_EditTeam.Multiline = true;
            this.txtBox_EditTeam.Name = "txtBox_EditTeam";
            this.txtBox_EditTeam.Size = new System.Drawing.Size(288, 32);
            this.txtBox_EditTeam.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "EDIT HERE";
            // 
            // btnEditTeam
            // 
            this.btnEditTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTeam.Location = new System.Drawing.Point(103, 228);
            this.btnEditTeam.Name = "btnEditTeam";
            this.btnEditTeam.Size = new System.Drawing.Size(174, 36);
            this.btnEditTeam.TabIndex = 5;
            this.btnEditTeam.Text = "UPDATE TEAM NAME";
            this.btnEditTeam.UseVisualStyleBackColor = true;
            this.btnEditTeam.Click += new System.EventHandler(this.btnEditTeam_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 444);
            this.Controls.Add(this.tabControl1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxAddTeam.ResumeLayout(false);
            this.groupBoxAddTeam.PerformLayout();
            this.groupBoxEditTeam.ResumeLayout(false);
            this.groupBoxEditTeam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radioAddTeam;
        private System.Windows.Forms.RadioButton radioEditTeam;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBoxAddTeam;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.GroupBox groupBoxEditTeam;
        private System.Windows.Forms.Button btnEditTeam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_EditTeam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxEdit;
    }
}