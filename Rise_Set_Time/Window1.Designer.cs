namespace Rise_Set_Time
{
    partial class Window1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtlat = new System.Windows.Forms.TextBox();
            this.txtlon = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.lblrise = new System.Windows.Forms.Label();
            this.lblset = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Latitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(524, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Longitude";
            // 
            // txtlat
            // 
            this.txtlat.Location = new System.Drawing.Point(255, 89);
            this.txtlat.Multiline = true;
            this.txtlat.Name = "txtlat";
            this.txtlat.Size = new System.Drawing.Size(220, 52);
            this.txtlat.TabIndex = 2;
            // 
            // txtlon
            // 
            this.txtlon.Location = new System.Drawing.Point(679, 89);
            this.txtlon.Multiline = true;
            this.txtlon.Name = "txtlon";
            this.txtlon.Size = new System.Drawing.Size(220, 52);
            this.txtlon.TabIndex = 3;
            // 
            // btnGet
            // 
            this.btnGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.Location = new System.Drawing.Point(365, 226);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(288, 63);
            this.btnGet.TabIndex = 4;
            this.btnGet.Text = "Get Data";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // lblrise
            // 
            this.lblrise.AutoSize = true;
            this.lblrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrise.Location = new System.Drawing.Point(107, 378);
            this.lblrise.Name = "lblrise";
            this.lblrise.Size = new System.Drawing.Size(0, 20);
            this.lblrise.TabIndex = 5;
            // 
            // lblset
            // 
            this.lblset.AutoSize = true;
            this.lblset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblset.Location = new System.Drawing.Point(107, 425);
            this.lblset.Name = "lblset";
            this.lblset.Size = new System.Drawing.Size(0, 20);
            this.lblset.TabIndex = 6;
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1058, 652);
            this.Controls.Add(this.lblset);
            this.Controls.Add(this.lblrise);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.txtlon);
            this.Controls.Add(this.txtlat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Window1";
            this.Text = "Window1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlat;
        private System.Windows.Forms.TextBox txtlon;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Label lblrise;
        private System.Windows.Forms.Label lblset;
    }
}

