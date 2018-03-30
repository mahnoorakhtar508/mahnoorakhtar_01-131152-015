namespace studentprofilegui
{
    partial class searchingName
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
            this.name_search_label = new System.Windows.Forms.Label();
            this.searchnametxt = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListView();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_search_label
            // 
            this.name_search_label.AutoSize = true;
            this.name_search_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_search_label.Location = new System.Drawing.Point(12, 68);
            this.name_search_label.Name = "name_search_label";
            this.name_search_label.Size = new System.Drawing.Size(49, 16);
            this.name_search_label.TabIndex = 0;
            this.name_search_label.Text = "Name";
            this.name_search_label.Click += new System.EventHandler(this.name_search_label_Click);
            // 
            // searchnametxt
            // 
            this.searchnametxt.BackColor = System.Drawing.Color.Blue;
            this.searchnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchnametxt.ForeColor = System.Drawing.Color.White;
            this.searchnametxt.Location = new System.Drawing.Point(79, 64);
            this.searchnametxt.Name = "searchnametxt";
            this.searchnametxt.Size = new System.Drawing.Size(182, 20);
            this.searchnametxt.TabIndex = 1;
            this.searchnametxt.TextChanged += new System.EventHandler(this.searchtxt_TextChanged);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.Blue;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.ForeColor = System.Drawing.Color.White;
            this.searchbtn.Location = new System.Drawing.Point(160, 124);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(101, 54);
            this.searchbtn.TabIndex = 2;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(318, 54);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(242, 174);
            this.list.TabIndex = 3;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Blue;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.White;
            this.backbtn.Location = new System.Drawing.Point(491, 274);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(115, 49);
            this.backbtn.TabIndex = 4;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // searchingName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::studentprofilegui.Properties.Resources.search_logo_md;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(635, 348);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.list);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchnametxt);
            this.Controls.Add(this.name_search_label);
            this.DoubleBuffered = true;
            this.Name = "searchingName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search_Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_search_label;
        private System.Windows.Forms.TextBox searchnametxt;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.Button backbtn;
    }
}