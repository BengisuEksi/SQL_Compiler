namespace SQL_Compiler
{
    partial class SQLQueries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLQueries));
            this.label1 = new System.Windows.Forms.Label();
            this.exit_bttn = new System.Windows.Forms.Button();
            this.back_bttn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.address_lbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(330, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "SQL Queries";
            // 
            // exit_bttn
            // 
            this.exit_bttn.BackColor = System.Drawing.Color.Transparent;
            this.exit_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_bttn.BackgroundImage")));
            this.exit_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_bttn.Location = new System.Drawing.Point(829, -1);
            this.exit_bttn.Name = "exit_bttn";
            this.exit_bttn.Size = new System.Drawing.Size(30, 30);
            this.exit_bttn.TabIndex = 7;
            this.exit_bttn.UseVisualStyleBackColor = false;
            this.exit_bttn.Click += new System.EventHandler(this.exit_bttn_Click);
            this.exit_bttn.MouseEnter += new System.EventHandler(this.exit_bttn_MouseEnter);
            this.exit_bttn.MouseLeave += new System.EventHandler(this.exit_bttn_MouseLeave);
            // 
            // back_bttn
            // 
            this.back_bttn.BackColor = System.Drawing.Color.Transparent;
            this.back_bttn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_bttn.BackgroundImage")));
            this.back_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_bttn.Location = new System.Drawing.Point(794, -1);
            this.back_bttn.Name = "back_bttn";
            this.back_bttn.Size = new System.Drawing.Size(30, 30);
            this.back_bttn.TabIndex = 8;
            this.back_bttn.UseVisualStyleBackColor = false;
            this.back_bttn.Click += new System.EventHandler(this.back_bttn_Click);
            this.back_bttn.MouseEnter += new System.EventHandler(this.back_bttn_MouseEnter);
            this.back_bttn.MouseLeave += new System.EventHandler(this.back_bttn_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(600, 330);
            this.label2.TabIndex = 9;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(39, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "For more information : ";
            // 
            // address_lbl
            // 
            this.address_lbl.AutoSize = true;
            this.address_lbl.BackColor = System.Drawing.Color.Transparent;
            this.address_lbl.Location = new System.Drawing.Point(253, 480);
            this.address_lbl.Name = "address_lbl";
            this.address_lbl.Size = new System.Drawing.Size(106, 22);
            this.address_lbl.TabIndex = 11;
            this.address_lbl.TabStop = true;
            this.address_lbl.Text = "W3 Schools";
            this.address_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.address_lbl_LinkClicked);
            // 
            // SQLQueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 550);
            this.Controls.Add(this.address_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back_bttn);
            this.Controls.Add(this.exit_bttn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SQLQueries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQLQueries";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit_bttn;
        private System.Windows.Forms.Button back_bttn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel address_lbl;
    }
}