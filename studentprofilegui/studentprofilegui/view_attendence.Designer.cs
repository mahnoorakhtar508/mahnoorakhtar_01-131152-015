namespace studentprofilegui
{
    partial class view_attendence
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
            this.search = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.listing = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Blue;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(344, 288);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(87, 46);
            this.search.TabIndex = 3;
            this.search.Text = "View";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.Blue;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.White;
            this.backbtn.Location = new System.Drawing.Point(29, 288);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(87, 46);
            this.backbtn.TabIndex = 5;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // listing
            // 
            this.listing.FormattingEnabled = true;
            this.listing.Location = new System.Drawing.Point(448, 36);
            this.listing.Name = "listing";
            this.listing.Size = new System.Drawing.Size(168, 277);
            this.listing.TabIndex = 6;
            // 
            // view_attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::studentprofilegui.Properties.Resources.attendance_splash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(656, 346);
            this.Controls.Add(this.listing);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.search);
            this.DoubleBuffered = true;
            this.Name = "view_attendence";
            this.Text = "view_attendence";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.ListBox listing;
    }
}