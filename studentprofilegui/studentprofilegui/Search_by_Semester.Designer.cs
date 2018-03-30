namespace studentprofilegui
{
    partial class Search_by_Semester
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
            this.searchingsemestertxt = new System.Windows.Forms.TextBox();
            this.Search_semester = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Semester (as \"first etc\" )";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchingsemestertxt
            // 
            this.searchingsemestertxt.BackColor = System.Drawing.Color.Blue;
            this.searchingsemestertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchingsemestertxt.ForeColor = System.Drawing.Color.White;
            this.searchingsemestertxt.Location = new System.Drawing.Point(229, 40);
            this.searchingsemestertxt.Name = "searchingsemestertxt";
            this.searchingsemestertxt.Size = new System.Drawing.Size(200, 20);
            this.searchingsemestertxt.TabIndex = 1;
            // 
            // Search_semester
            // 
            this.Search_semester.BackColor = System.Drawing.Color.Blue;
            this.Search_semester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_semester.ForeColor = System.Drawing.Color.White;
            this.Search_semester.Location = new System.Drawing.Point(248, 107);
            this.Search_semester.Name = "Search_semester";
            this.Search_semester.Size = new System.Drawing.Size(113, 38);
            this.Search_semester.TabIndex = 2;
            this.Search_semester.Text = "Search";
            this.Search_semester.UseVisualStyleBackColor = false;
            this.Search_semester.Click += new System.EventHandler(this.Search_semester_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(435, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(188, 219);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(26, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Search_by_Semester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::studentprofilegui.Properties.Resources.search_logo_md;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(663, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Search_semester);
            this.Controls.Add(this.searchingsemestertxt);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Search_by_Semester";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search_by_Semester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchingsemestertxt;
        private System.Windows.Forms.Button Search_semester;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
    }
}