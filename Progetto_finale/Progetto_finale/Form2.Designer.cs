
namespace Progetto_finale
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.esciBtn = new System.Windows.Forms.Button();
            this.pescaBtn = new System.Windows.Forms.Button();
            this.passaturnoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // esciBtn
            // 
            this.esciBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.esciBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.esciBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.esciBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.esciBtn.ForeColor = System.Drawing.Color.Yellow;
            this.esciBtn.Location = new System.Drawing.Point(12, 12);
            this.esciBtn.Name = "esciBtn";
            this.esciBtn.Size = new System.Drawing.Size(112, 56);
            this.esciBtn.TabIndex = 19;
            this.esciBtn.Text = "ESCI";
            this.esciBtn.UseVisualStyleBackColor = false;
            this.esciBtn.Click += new System.EventHandler(this.esciBtn_Click);
            // 
            // pescaBtn
            // 
            this.pescaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pescaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pescaBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pescaBtn.ForeColor = System.Drawing.Color.Yellow;
            this.pescaBtn.Location = new System.Drawing.Point(377, 285);
            this.pescaBtn.Name = "pescaBtn";
            this.pescaBtn.Size = new System.Drawing.Size(112, 60);
            this.pescaBtn.TabIndex = 23;
            this.pescaBtn.Text = "PESCA";
            this.pescaBtn.UseVisualStyleBackColor = false;
            this.pescaBtn.Click += new System.EventHandler(this.pescaBtn_Click);
            // 
            // passaturnoBtn
            // 
            this.passaturnoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passaturnoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passaturnoBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passaturnoBtn.ForeColor = System.Drawing.Color.Yellow;
            this.passaturnoBtn.Location = new System.Drawing.Point(377, 395);
            this.passaturnoBtn.Name = "passaturnoBtn";
            this.passaturnoBtn.Size = new System.Drawing.Size(112, 60);
            this.passaturnoBtn.TabIndex = 24;
            this.passaturnoBtn.Text = "PASSA IL TURNO";
            this.passaturnoBtn.UseVisualStyleBackColor = false;
            this.passaturnoBtn.Click += new System.EventHandler(this.passaturnoBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1306, 731);
            this.Controls.Add(this.passaturnoBtn);
            this.Controls.Add(this.pescaBtn);
            this.Controls.Add(this.esciBtn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button esciBtn;
        private System.Windows.Forms.Button pescaBtn;
        private System.Windows.Forms.Button passaturnoBtn;
    }
}