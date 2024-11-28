namespace SQL_Compiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.query_txtbox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sqlqueries_bttn = new System.Windows.Forms.Button();
            this.execute_bttn = new System.Windows.Forms.Button();
            this.exit_bttn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clear_bttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.database_comboBox = new System.Windows.Forms.ComboBox();
            this.table_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // query_txtbox
            // 
            this.query_txtbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.query_txtbox.Location = new System.Drawing.Point(4, 26);
            this.query_txtbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.query_txtbox.Name = "query_txtbox";
            this.query_txtbox.Size = new System.Drawing.Size(644, 201);
            this.query_txtbox.TabIndex = 0;
            this.query_txtbox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.query_txtbox);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(15, 118);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(652, 230);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Query";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(968, 268);
            this.dataGridView1.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(15, 354);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(976, 297);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data";
            // 
            // sqlqueries_bttn
            // 
            this.sqlqueries_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqlqueries_bttn.Location = new System.Drawing.Point(6, 145);
            this.sqlqueries_bttn.Name = "sqlqueries_bttn";
            this.sqlqueries_bttn.Size = new System.Drawing.Size(305, 38);
            this.sqlqueries_bttn.TabIndex = 4;
            this.sqlqueries_bttn.Text = "About SQL";
            this.sqlqueries_bttn.UseVisualStyleBackColor = true;
            this.sqlqueries_bttn.Click += new System.EventHandler(this.sqlqueries_bttn_Click);
            this.sqlqueries_bttn.MouseEnter += new System.EventHandler(this.sqlqueries_bttn_MouseEnter);
            this.sqlqueries_bttn.MouseLeave += new System.EventHandler(this.sqlqueries_bttn_MouseLeave);
            // 
            // execute_bttn
            // 
            this.execute_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.execute_bttn.Location = new System.Drawing.Point(6, 57);
            this.execute_bttn.Name = "execute_bttn";
            this.execute_bttn.Size = new System.Drawing.Size(305, 38);
            this.execute_bttn.TabIndex = 1;
            this.execute_bttn.Text = "Execute Query";
            this.execute_bttn.UseVisualStyleBackColor = true;
            this.execute_bttn.Click += new System.EventHandler(this.execute_bttn_Click);
            this.execute_bttn.MouseEnter += new System.EventHandler(this.execute_bttn_MouseEnter);
            this.execute_bttn.MouseLeave += new System.EventHandler(this.execute_bttn_MouseLeave);
            // 
            // exit_bttn
            // 
            this.exit_bttn.BackColor = System.Drawing.Color.Transparent;
            this.exit_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_bttn.BackgroundImage")));
            this.exit_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_bttn.Location = new System.Drawing.Point(973, -1);
            this.exit_bttn.Name = "exit_bttn";
            this.exit_bttn.Size = new System.Drawing.Size(30, 30);
            this.exit_bttn.TabIndex = 5;
            this.exit_bttn.UseVisualStyleBackColor = false;
            this.exit_bttn.Click += new System.EventHandler(this.exit_bttn_Click);
            this.exit_bttn.MouseEnter += new System.EventHandler(this.exit_bttn_MouseEnter);
            this.exit_bttn.MouseLeave += new System.EventHandler(this.exit_bttn_MouseLeave);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.clear_bttn);
            this.groupBox3.Controls.Add(this.sqlqueries_bttn);
            this.groupBox3.Controls.Add(this.execute_bttn);
            this.groupBox3.Location = new System.Drawing.Point(674, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 230);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // clear_bttn
            // 
            this.clear_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_bttn.Location = new System.Drawing.Point(6, 101);
            this.clear_bttn.Name = "clear_bttn";
            this.clear_bttn.Size = new System.Drawing.Size(305, 38);
            this.clear_bttn.TabIndex = 3;
            this.clear_bttn.Text = "Clear Query";
            this.clear_bttn.UseVisualStyleBackColor = true;
            this.clear_bttn.Click += new System.EventHandler(this.clear_bttn_Click);
            this.clear_bttn.MouseEnter += new System.EventHandler(this.clear_bttn_MouseEnter);
            this.clear_bttn.MouseLeave += new System.EventHandler(this.clear_bttn_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "SQL COMPILER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(181, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Database: ";
            // 
            // database_comboBox
            // 
            this.database_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.database_comboBox.FormattingEnabled = true;
            this.database_comboBox.Location = new System.Drawing.Point(271, 88);
            this.database_comboBox.Name = "database_comboBox";
            this.database_comboBox.Size = new System.Drawing.Size(219, 30);
            this.database_comboBox.TabIndex = 9;
            this.database_comboBox.SelectedIndexChanged += new System.EventHandler(this.database_comboBox_SelectedIndexChanged);
            // 
            // table_comboBox
            // 
            this.table_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.table_comboBox.FormattingEnabled = true;
            this.table_comboBox.Location = new System.Drawing.Point(614, 88);
            this.table_comboBox.Name = "table_comboBox";
            this.table_comboBox.Size = new System.Drawing.Size(219, 30);
            this.table_comboBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(552, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Table: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(339, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 668);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.table_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.database_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.exit_bttn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox query_txtbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button sqlqueries_bttn;
        private System.Windows.Forms.Button execute_bttn;
        private System.Windows.Forms.Button exit_bttn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button clear_bttn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox database_comboBox;
        private System.Windows.Forms.ComboBox table_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

