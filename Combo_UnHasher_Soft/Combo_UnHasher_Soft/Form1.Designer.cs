namespace Combo_UnHasher_Soft
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Combo_BTN = new RelyUI.Controls.RelyButton();
            this.START_BTN = new RelyUI.Controls.RelyButton();
            this.STOP_BTN = new RelyUI.Controls.RelyButton();
            this.USER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relyGroupBox1 = new RelyUI.Controls.RelyGroupBox();
            this.relyLabel1 = new RelyUI.Controls.RelyLabel();
            this.Error_lBL = new RelyUI.Controls.RelyLabel();
            this.Check_lBL = new RelyUI.Controls.RelyLabel();
            this.relyLabel4 = new RelyUI.Controls.RelyLabel();
            this.Bad_lBL = new RelyUI.Controls.RelyLabel();
            this.relyLabel2 = new RelyUI.Controls.RelyLabel();
            this.Good_lBL = new RelyUI.Controls.RelyLabel();
            this.relyLabel3 = new RelyUI.Controls.RelyLabel();
            this.Hits_List = new ns1.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relyGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hits_List)).BeginInit();
            this.SuspendLayout();
            // 
            // Combo_BTN
            // 
            this.Combo_BTN.BackColor = System.Drawing.Color.Transparent;
            this.Combo_BTN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.Combo_BTN.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Combo_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Combo_BTN.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Combo_BTN.Location = new System.Drawing.Point(13, 57);
            this.Combo_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.Combo_BTN.Name = "Combo_BTN";
            this.Combo_BTN.Rounded = true;
            this.Combo_BTN.RoundRadius = 3;
            this.Combo_BTN.Size = new System.Drawing.Size(723, 59);
            this.Combo_BTN.TabIndex = 1;
            this.Combo_BTN.Text = "Load Combo";
            this.Combo_BTN.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Combo_BTN.Click += new System.EventHandler(this.Combo_BTN_Click);
            // 
            // START_BTN
            // 
            this.START_BTN.BackColor = System.Drawing.Color.Transparent;
            this.START_BTN.BaseColor = System.Drawing.Color.Teal;
            this.START_BTN.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.START_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.START_BTN.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.START_BTN.Location = new System.Drawing.Point(13, 130);
            this.START_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.START_BTN.Name = "START_BTN";
            this.START_BTN.Rounded = true;
            this.START_BTN.RoundRadius = 3;
            this.START_BTN.Size = new System.Drawing.Size(213, 59);
            this.START_BTN.TabIndex = 2;
            this.START_BTN.Text = "START";
            this.START_BTN.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.START_BTN.Click += new System.EventHandler(this.START_BTN_Click);
            // 
            // STOP_BTN
            // 
            this.STOP_BTN.BackColor = System.Drawing.Color.Transparent;
            this.STOP_BTN.BaseColor = System.Drawing.Color.Teal;
            this.STOP_BTN.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.STOP_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.STOP_BTN.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.STOP_BTN.Location = new System.Drawing.Point(13, 197);
            this.STOP_BTN.Margin = new System.Windows.Forms.Padding(4);
            this.STOP_BTN.Name = "STOP_BTN";
            this.STOP_BTN.Rounded = true;
            this.STOP_BTN.RoundRadius = 3;
            this.STOP_BTN.Size = new System.Drawing.Size(213, 59);
            this.STOP_BTN.TabIndex = 3;
            this.STOP_BTN.Text = "STOP";
            this.STOP_BTN.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.STOP_BTN.Click += new System.EventHandler(this.STOP_BTN_Click);
            // 
            // USER
            // 
            this.USER.HeaderText = "Email/UserName";
            this.USER.MinimumWidth = 6;
            this.USER.Name = "USER";
            this.USER.Width = 125;
            // 
            // PASS
            // 
            this.PASS.HeaderText = "Password";
            this.PASS.MinimumWidth = 6;
            this.PASS.Name = "PASS";
            this.PASS.Width = 125;
            // 
            // relyGroupBox1
            // 
            this.relyGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.relyGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.relyGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.relyGroupBox1.Controls.Add(this.relyLabel1);
            this.relyGroupBox1.Controls.Add(this.Error_lBL);
            this.relyGroupBox1.Controls.Add(this.Check_lBL);
            this.relyGroupBox1.Controls.Add(this.relyLabel4);
            this.relyGroupBox1.Controls.Add(this.Bad_lBL);
            this.relyGroupBox1.Controls.Add(this.relyLabel2);
            this.relyGroupBox1.Controls.Add(this.Good_lBL);
            this.relyGroupBox1.Controls.Add(this.relyLabel3);
            this.relyGroupBox1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.relyGroupBox1.Location = new System.Drawing.Point(19, 266);
            this.relyGroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.relyGroupBox1.Name = "relyGroupBox1";
            this.relyGroupBox1.ShowText = true;
            this.relyGroupBox1.Size = new System.Drawing.Size(203, 175);
            this.relyGroupBox1.TabIndex = 28;
            this.relyGroupBox1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // relyLabel1
            // 
            this.relyLabel1.AutoSize = true;
            this.relyLabel1.BackColor = System.Drawing.Color.Transparent;
            this.relyLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.relyLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.relyLabel1.Location = new System.Drawing.Point(35, 18);
            this.relyLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.relyLabel1.Name = "relyLabel1";
            this.relyLabel1.Size = new System.Drawing.Size(67, 25);
            this.relyLabel1.TabIndex = 19;
            this.relyLabel1.Text = "Check:";
            // 
            // Error_lBL
            // 
            this.Error_lBL.AutoSize = true;
            this.Error_lBL.BackColor = System.Drawing.Color.Transparent;
            this.Error_lBL.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Error_lBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Error_lBL.Location = new System.Drawing.Point(111, 132);
            this.Error_lBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Error_lBL.Name = "Error_lBL";
            this.Error_lBL.Size = new System.Drawing.Size(22, 25);
            this.Error_lBL.TabIndex = 26;
            this.Error_lBL.Text = "0";
            // 
            // Check_lBL
            // 
            this.Check_lBL.AutoSize = true;
            this.Check_lBL.BackColor = System.Drawing.Color.Transparent;
            this.Check_lBL.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Check_lBL.ForeColor = System.Drawing.Color.Teal;
            this.Check_lBL.Location = new System.Drawing.Point(111, 18);
            this.Check_lBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Check_lBL.Name = "Check_lBL";
            this.Check_lBL.Size = new System.Drawing.Size(22, 25);
            this.Check_lBL.TabIndex = 23;
            this.Check_lBL.Text = "0";
            // 
            // relyLabel4
            // 
            this.relyLabel4.AutoSize = true;
            this.relyLabel4.BackColor = System.Drawing.Color.Transparent;
            this.relyLabel4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.relyLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.relyLabel4.Location = new System.Drawing.Point(35, 132);
            this.relyLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.relyLabel4.Name = "relyLabel4";
            this.relyLabel4.Size = new System.Drawing.Size(58, 25);
            this.relyLabel4.TabIndex = 22;
            this.relyLabel4.Text = "Error:";
            // 
            // Bad_lBL
            // 
            this.Bad_lBL.AutoSize = true;
            this.Bad_lBL.BackColor = System.Drawing.Color.Transparent;
            this.Bad_lBL.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Bad_lBL.ForeColor = System.Drawing.Color.Yellow;
            this.Bad_lBL.Location = new System.Drawing.Point(111, 96);
            this.Bad_lBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Bad_lBL.Name = "Bad_lBL";
            this.Bad_lBL.Size = new System.Drawing.Size(22, 25);
            this.Bad_lBL.TabIndex = 25;
            this.Bad_lBL.Text = "0";
            // 
            // relyLabel2
            // 
            this.relyLabel2.AutoSize = true;
            this.relyLabel2.BackColor = System.Drawing.Color.Transparent;
            this.relyLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.relyLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.relyLabel2.Location = new System.Drawing.Point(37, 57);
            this.relyLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.relyLabel2.Name = "relyLabel2";
            this.relyLabel2.Size = new System.Drawing.Size(62, 25);
            this.relyLabel2.TabIndex = 20;
            this.relyLabel2.Text = "Good:";
            // 
            // Good_lBL
            // 
            this.Good_lBL.AutoSize = true;
            this.Good_lBL.BackColor = System.Drawing.Color.Transparent;
            this.Good_lBL.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Good_lBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Good_lBL.Location = new System.Drawing.Point(111, 57);
            this.Good_lBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Good_lBL.Name = "Good_lBL";
            this.Good_lBL.Size = new System.Drawing.Size(22, 25);
            this.Good_lBL.TabIndex = 24;
            this.Good_lBL.Text = "0";
            // 
            // relyLabel3
            // 
            this.relyLabel3.AutoSize = true;
            this.relyLabel3.BackColor = System.Drawing.Color.Transparent;
            this.relyLabel3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.relyLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.relyLabel3.Location = new System.Drawing.Point(37, 96);
            this.relyLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.relyLabel3.Name = "relyLabel3";
            this.relyLabel3.Size = new System.Drawing.Size(48, 25);
            this.relyLabel3.TabIndex = 21;
            this.relyLabel3.Text = "Bad:";
            // 
            // Hits_List
            // 
            this.Hits_List.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Hits_List.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Hits_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Hits_List.BackgroundColor = System.Drawing.Color.DimGray;
            this.Hits_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Hits_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Hits_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Hits_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Hits_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.Hits_List.DoubleBuffered = true;
            this.Hits_List.EnableHeadersVisualStyles = false;
            this.Hits_List.HeaderBgColor = System.Drawing.Color.Black;
            this.Hits_List.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.Hits_List.Location = new System.Drawing.Point(235, 129);
            this.Hits_List.Margin = new System.Windows.Forms.Padding(4);
            this.Hits_List.Name = "Hits_List";
            this.Hits_List.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Hits_List.RowHeadersWidth = 51;
            this.Hits_List.Size = new System.Drawing.Size(501, 302);
            this.Hits_List.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Email/UserName";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Password";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Form1
            // 
            this.AccentColor = System.Drawing.Color.Black;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(752, 446);
            this.Controls.Add(this.Hits_List);
            this.Controls.Add(this.relyGroupBox1);
            this.Controls.Add(this.STOP_BTN);
            this.Controls.Add(this.START_BTN);
            this.Controls.Add(this.Combo_BTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Combo UnHasher By [-Rexinous(AGC007-v2)-]";
            this.TitleText = "Combo UnHasher By [-Rexinous(AGC007-v2)-]";
            this.Controls.SetChildIndex(this.Combo_BTN, 0);
            this.Controls.SetChildIndex(this.START_BTN, 0);
            this.Controls.SetChildIndex(this.STOP_BTN, 0);
            this.Controls.SetChildIndex(this.relyGroupBox1, 0);
            this.Controls.SetChildIndex(this.Hits_List, 0);
            this.relyGroupBox1.ResumeLayout(false);
            this.relyGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hits_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RelyUI.Controls.RelyButton Combo_BTN;
        private RelyUI.Controls.RelyButton START_BTN;
        private RelyUI.Controls.RelyButton STOP_BTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn USER;
        private System.Windows.Forms.DataGridViewTextBoxColumn PASS;
        private RelyUI.Controls.RelyGroupBox relyGroupBox1;
        private RelyUI.Controls.RelyLabel relyLabel1;
        private RelyUI.Controls.RelyLabel Error_lBL;
        private RelyUI.Controls.RelyLabel Check_lBL;
        private RelyUI.Controls.RelyLabel relyLabel4;
        private RelyUI.Controls.RelyLabel Bad_lBL;
        private RelyUI.Controls.RelyLabel relyLabel2;
        private RelyUI.Controls.RelyLabel Good_lBL;
        private RelyUI.Controls.RelyLabel relyLabel3;
        private ns1.BunifuCustomDataGrid Hits_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

