namespace WindowsFormsApp1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LabelError = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerInput = new System.Windows.Forms.DateTimePicker();
            this.textBoxDesignationInput = new System.Windows.Forms.TextBox();
            this.textBoxWeightInput = new System.Windows.Forms.TextBox();
            this.textBoxScaleIdInput = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonChooseByDate = new System.Windows.Forms.Button();
            this.buttonChooseByDesignation = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerChoose = new System.Windows.Forms.DateTimePicker();
            this.textBoxChooseByDesignation = new System.Windows.Forms.TextBox();
            this.textBoxScaleIDChoose = new System.Windows.Forms.TextBox();
            this.buttonTotalChoice = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renewToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // renewToolStripMenuItem
            // 
            this.renewToolStripMenuItem.Name = "renewToolStripMenuItem";
            this.renewToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.renewToolStripMenuItem.Text = "Renew";
            this.renewToolStripMenuItem.Click += new System.EventHandler(this.RenewToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 410);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.CausesValidation = false;
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage1.Size = new System.Drawing.Size(780, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Select";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(774, 378);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.LabelError);
            this.tabPage2.Controls.Add(this.buttonAdd);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dateTimePickerInput);
            this.tabPage2.Controls.Add(this.textBoxDesignationInput);
            this.tabPage2.Controls.Add(this.textBoxWeightInput);
            this.tabPage2.Controls.Add(this.textBoxScaleIdInput);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // LabelError
            // 
            this.LabelError.AutoSize = true;
            this.LabelError.Font = new System.Drawing.Font("Tahoma", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelError.ForeColor = System.Drawing.Color.Red;
            this.LabelError.Location = new System.Drawing.Point(365, 34);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(39, 17);
            this.LabelError.TabIndex = 9;
            this.LabelError.Text = "Error";
            this.LabelError.Visible = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonAdd.Location = new System.Drawing.Point(81, 251);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add ";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label4.Location = new System.Drawing.Point(38, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label3.Location = new System.Drawing.Point(22, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Designation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label2.Location = new System.Drawing.Point(38, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Weight";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Scale ID";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // dateTimePickerInput
            // 
            this.dateTimePickerInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInput.Location = new System.Drawing.Point(129, 168);
            this.dateTimePickerInput.Name = "dateTimePickerInput";
            this.dateTimePickerInput.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerInput.TabIndex = 3;
            this.dateTimePickerInput.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // textBoxDesignationInput
            // 
            this.textBoxDesignationInput.Location = new System.Drawing.Point(129, 117);
            this.textBoxDesignationInput.Name = "textBoxDesignationInput";
            this.textBoxDesignationInput.Size = new System.Drawing.Size(100, 21);
            this.textBoxDesignationInput.TabIndex = 2;
            // 
            // textBoxWeightInput
            // 
            this.textBoxWeightInput.Location = new System.Drawing.Point(129, 67);
            this.textBoxWeightInput.Name = "textBoxWeightInput";
            this.textBoxWeightInput.Size = new System.Drawing.Size(100, 21);
            this.textBoxWeightInput.TabIndex = 1;
            // 
            // textBoxScaleIdInput
            // 
            this.textBoxScaleIdInput.Location = new System.Drawing.Point(129, 16);
            this.textBoxScaleIdInput.Name = "textBoxScaleIdInput";
            this.textBoxScaleIdInput.Size = new System.Drawing.Size(100, 21);
            this.textBoxScaleIdInput.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonTotalChoice);
            this.tabPage3.Controls.Add(this.buttonChooseByDate);
            this.tabPage3.Controls.Add(this.buttonChooseByDesignation);
            this.tabPage3.Controls.Add(this.listBox2);
            this.tabPage3.Controls.Add(this.buttonChoose);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.dateTimePickerChoose);
            this.tabPage3.Controls.Add(this.textBoxChooseByDesignation);
            this.tabPage3.Controls.Add(this.textBoxScaleIDChoose);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(780, 384);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Choose";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonChooseByDate
            // 
            this.buttonChooseByDate.Location = new System.Drawing.Point(295, 81);
            this.buttonChooseByDate.Name = "buttonChooseByDate";
            this.buttonChooseByDate.Size = new System.Drawing.Size(112, 23);
            this.buttonChooseByDate.TabIndex = 20;
            this.buttonChooseByDate.Text = "Choose by date";
            this.buttonChooseByDate.UseVisualStyleBackColor = true;
            this.buttonChooseByDate.Click += new System.EventHandler(this.ButtonChooseByDate_Click);
            // 
            // buttonChooseByDesignation
            // 
            this.buttonChooseByDesignation.Location = new System.Drawing.Point(616, 25);
            this.buttonChooseByDesignation.Name = "buttonChooseByDesignation";
            this.buttonChooseByDesignation.Size = new System.Drawing.Size(124, 23);
            this.buttonChooseByDesignation.TabIndex = 19;
            this.buttonChooseByDesignation.Text = "Choose by designation";
            this.buttonChooseByDesignation.UseVisualStyleBackColor = true;
            this.buttonChooseByDesignation.Click += new System.EventHandler(this.ButtonChooseByDesignation_Click);
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(8, 116);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(756, 262);
            this.listBox2.TabIndex = 18;
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(235, 25);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(103, 23);
            this.buttonChoose.TabIndex = 17;
            this.buttonChoose.Text = "Choose by ID";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.ButtonChoose_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label5.Location = new System.Drawing.Point(22, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label6.Location = new System.Drawing.Point(414, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Designation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label8.Location = new System.Drawing.Point(34, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Scale ID";
            // 
            // dateTimePickerChoose
            // 
            this.dateTimePickerChoose.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerChoose.Location = new System.Drawing.Point(74, 83);
            this.dateTimePickerChoose.Name = "dateTimePickerChoose";
            this.dateTimePickerChoose.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerChoose.TabIndex = 12;
            this.dateTimePickerChoose.Value = new System.DateTime(2020, 1, 22, 0, 0, 0, 0);
            // 
            // textBoxChooseByDesignation
            // 
            this.textBoxChooseByDesignation.Location = new System.Drawing.Point(510, 27);
            this.textBoxChooseByDesignation.Name = "textBoxChooseByDesignation";
            this.textBoxChooseByDesignation.Size = new System.Drawing.Size(100, 21);
            this.textBoxChooseByDesignation.TabIndex = 11;
            // 
            // textBoxScaleIDChoose
            // 
            this.textBoxScaleIDChoose.Location = new System.Drawing.Point(118, 27);
            this.textBoxScaleIDChoose.Name = "textBoxScaleIDChoose";
            this.textBoxScaleIDChoose.Size = new System.Drawing.Size(100, 21);
            this.textBoxScaleIDChoose.TabIndex = 9;
            // 
            // buttonTotalChoice
            // 
            this.buttonTotalChoice.Location = new System.Drawing.Point(478, 70);
            this.buttonTotalChoice.Name = "buttonTotalChoice";
            this.buttonTotalChoice.Size = new System.Drawing.Size(262, 36);
            this.buttonTotalChoice.TabIndex = 21;
            this.buttonTotalChoice.Text = "Choose by ID, Designation and date";
            this.buttonTotalChoice.UseVisualStyleBackColor = true;
            this.buttonTotalChoice.Click += new System.EventHandler(this.ButtonTotalChoice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Scales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerInput;
        private System.Windows.Forms.TextBox textBoxDesignationInput;
        private System.Windows.Forms.TextBox textBoxWeightInput;
        private System.Windows.Forms.TextBox textBoxScaleIdInput;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxChooseByDesignation;
        private System.Windows.Forms.TextBox textBoxScaleIDChoose;
        private System.Windows.Forms.Button buttonChooseByDate;
        private System.Windows.Forms.Button buttonChooseByDesignation;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label LabelError;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePickerChoose;
        private System.Windows.Forms.Button buttonTotalChoice;
    }
}

