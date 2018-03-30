namespace studentprofilegui
{
    partial class searchingbyid
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchidtxt = new System.Windows.Forms.TextBox();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enrollment";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchidtxt
            // 
            this.searchidtxt.BackColor = System.Drawing.Color.Blue;
            this.searchidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchidtxt.ForeColor = System.Drawing.Color.White;
            this.searchidtxt.Location = new System.Drawing.Point(131, 58);
            this.searchidtxt.Name = "searchidtxt";
            this.searchidtxt.Size = new System.Drawing.Size(152, 20);
            this.searchidtxt.TabIndex = 1;
            // 
            // Searchbtn
            // 
            this.Searchbtn.BackColor = System.Drawing.Color.Blue;
            this.Searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.ForeColor = System.Drawing.Color.White;
            this.Searchbtn.Location = new System.Drawing.Point(186, 124);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(97, 38);
            this.Searchbtn.TabIndex = 2;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.UseVisualStyleBackColor = false;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // listView1
            // 
            this.listView1.FormattingEnabled = true;
            this.listView1.Location = new System.Drawing.Point(305, 58);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(318, 212);
            this.listView1.TabIndex = 4;
            // 
            // searchingbyid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::studentprofilegui.Properties.Resources.search_logo_md;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(635, 300);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.searchidtxt);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "searchingbyid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "searchingbyid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchidtxt;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.ListBox listView1;
    }
}