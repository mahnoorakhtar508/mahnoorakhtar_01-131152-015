namespace studentprofilegui
{
    partial class delete_record
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
            this.delete_recordtxt = new System.Windows.Forms.TextBox();
            this.deletebtn = new System.Windows.Forms.Button();
            this.back_main = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enrollment";
            // 
            // delete_recordtxt
            // 
            this.delete_recordtxt.BackColor = System.Drawing.Color.Blue;
            this.delete_recordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_recordtxt.ForeColor = System.Drawing.Color.White;
            this.delete_recordtxt.Location = new System.Drawing.Point(145, 45);
            this.delete_recordtxt.Name = "delete_recordtxt";
            this.delete_recordtxt.Size = new System.Drawing.Size(184, 20);
            this.delete_recordtxt.TabIndex = 1;
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Blue;
            this.deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deletebtn.Location = new System.Drawing.Point(218, 103);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(111, 40);
            this.deletebtn.TabIndex = 2;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // back_main
            // 
            this.back_main.BackColor = System.Drawing.Color.Blue;
            this.back_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_main.ForeColor = System.Drawing.Color.White;
            this.back_main.Location = new System.Drawing.Point(591, 271);
            this.back_main.Name = "back_main";
            this.back_main.Size = new System.Drawing.Size(111, 50);
            this.back_main.TabIndex = 3;
            this.back_main.Text = "Back";
            this.back_main.UseVisualStyleBackColor = false;
            this.back_main.Click += new System.EventHandler(this.back_main_Click);
            // 
            // delete_record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = global::studentprofilegui.Properties.Resources.delete_logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 354);
            this.Controls.Add(this.back_main);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.delete_recordtxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "delete_record";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "delete_record";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox delete_recordtxt;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button back_main;
    }
}