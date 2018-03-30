namespace studentprofilegui
{
    partial class firstwindow
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
            this.addinginfo = new System.Windows.Forms.Button();
            this.deleting = new System.Windows.Forms.Button();
            this.searchingbtn = new System.Windows.Forms.Button();
            this.mark_attendencebtn = new System.Windows.Forms.Button();
            this.top_cgpabtn = new System.Windows.Forms.Button();
            this.view_attendencebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addinginfo
            // 
            this.addinginfo.BackColor = System.Drawing.Color.Blue;
            this.addinginfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addinginfo.ForeColor = System.Drawing.Color.White;
            this.addinginfo.Location = new System.Drawing.Point(42, 31);
            this.addinginfo.Name = "addinginfo";
            this.addinginfo.Size = new System.Drawing.Size(109, 49);
            this.addinginfo.TabIndex = 0;
            this.addinginfo.Text = "To Add";
            this.addinginfo.UseVisualStyleBackColor = false;
            this.addinginfo.Click += new System.EventHandler(this.addinginfo_Click);
            // 
            // deleting
            // 
            this.deleting.BackColor = System.Drawing.Color.Blue;
            this.deleting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleting.ForeColor = System.Drawing.Color.White;
            this.deleting.Location = new System.Drawing.Point(42, 247);
            this.deleting.Name = "deleting";
            this.deleting.Size = new System.Drawing.Size(109, 49);
            this.deleting.TabIndex = 1;
            this.deleting.Text = "Delete";
            this.deleting.UseVisualStyleBackColor = false;
            this.deleting.Click += new System.EventHandler(this.deleting_Click);
            // 
            // searchingbtn
            // 
            this.searchingbtn.BackColor = System.Drawing.Color.Blue;
            this.searchingbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchingbtn.ForeColor = System.Drawing.Color.White;
            this.searchingbtn.Location = new System.Drawing.Point(42, 139);
            this.searchingbtn.Name = "searchingbtn";
            this.searchingbtn.Size = new System.Drawing.Size(109, 49);
            this.searchingbtn.TabIndex = 2;
            this.searchingbtn.Text = "To search";
            this.searchingbtn.UseVisualStyleBackColor = false;
            this.searchingbtn.Click += new System.EventHandler(this.searchingbtn_Click);
            // 
            // mark_attendencebtn
            // 
            this.mark_attendencebtn.BackColor = System.Drawing.Color.Blue;
            this.mark_attendencebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mark_attendencebtn.ForeColor = System.Drawing.Color.White;
            this.mark_attendencebtn.Location = new System.Drawing.Point(452, 31);
            this.mark_attendencebtn.Name = "mark_attendencebtn";
            this.mark_attendencebtn.Size = new System.Drawing.Size(109, 49);
            this.mark_attendencebtn.TabIndex = 3;
            this.mark_attendencebtn.Text = "Mark attendence";
            this.mark_attendencebtn.UseVisualStyleBackColor = false;
            this.mark_attendencebtn.Click += new System.EventHandler(this.mark_attendencebtn_Click);
            // 
            // top_cgpabtn
            // 
            this.top_cgpabtn.BackColor = System.Drawing.Color.Blue;
            this.top_cgpabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top_cgpabtn.ForeColor = System.Drawing.Color.White;
            this.top_cgpabtn.Location = new System.Drawing.Point(452, 247);
            this.top_cgpabtn.Name = "top_cgpabtn";
            this.top_cgpabtn.Size = new System.Drawing.Size(109, 49);
            this.top_cgpabtn.TabIndex = 4;
            this.top_cgpabtn.Text = "Highest CGPA\'s";
            this.top_cgpabtn.UseVisualStyleBackColor = false;
            this.top_cgpabtn.Click += new System.EventHandler(this.top_cgpabtn_Click);
            // 
            // view_attendencebtn
            // 
            this.view_attendencebtn.BackColor = System.Drawing.Color.Blue;
            this.view_attendencebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view_attendencebtn.ForeColor = System.Drawing.Color.White;
            this.view_attendencebtn.Location = new System.Drawing.Point(452, 139);
            this.view_attendencebtn.Name = "view_attendencebtn";
            this.view_attendencebtn.Size = new System.Drawing.Size(109, 49);
            this.view_attendencebtn.TabIndex = 5;
            this.view_attendencebtn.Text = "View attendence";
            this.view_attendencebtn.UseVisualStyleBackColor = false;
            this.view_attendencebtn.Click += new System.EventHandler(this.view_attendencebtn_Click);
            // 
            // firstwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::studentprofilegui.Properties.Resources.admin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(591, 374);
            this.Controls.Add(this.view_attendencebtn);
            this.Controls.Add(this.top_cgpabtn);
            this.Controls.Add(this.mark_attendencebtn);
            this.Controls.Add(this.searchingbtn);
            this.Controls.Add(this.deleting);
            this.Controls.Add(this.addinginfo);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "firstwindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "firstwindow";
            this.Load += new System.EventHandler(this.firstwindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addinginfo;
        private System.Windows.Forms.Button deleting;
        private System.Windows.Forms.Button searchingbtn;
        private System.Windows.Forms.Button mark_attendencebtn;
        private System.Windows.Forms.Button top_cgpabtn;
        private System.Windows.Forms.Button view_attendencebtn;
    }
}