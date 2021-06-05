
namespace Progetto_finale
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.giocaBtn = new System.Windows.Forms.Button();
            this.regoleBtn = new System.Windows.Forms.Button();
            this.esciBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // giocaBtn
            // 
            this.giocaBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("giocaBtn.BackgroundImage")));
            this.giocaBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.giocaBtn.ForeColor = System.Drawing.Color.Yellow;
            this.giocaBtn.Location = new System.Drawing.Point(59, 232);
            this.giocaBtn.Name = "giocaBtn";
            this.giocaBtn.Size = new System.Drawing.Size(307, 81);
            this.giocaBtn.TabIndex = 0;
            this.giocaBtn.Text = "GIOCA";
            this.giocaBtn.UseVisualStyleBackColor = true;
            this.giocaBtn.Click += new System.EventHandler(this.giocaBtn_Click);
            // 
            // regoleBtn
            // 
            this.regoleBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("regoleBtn.BackgroundImage")));
            this.regoleBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.regoleBtn.ForeColor = System.Drawing.Color.Yellow;
            this.regoleBtn.Location = new System.Drawing.Point(59, 319);
            this.regoleBtn.Name = "regoleBtn";
            this.regoleBtn.Size = new System.Drawing.Size(307, 81);
            this.regoleBtn.TabIndex = 1;
            this.regoleBtn.Text = "REGOLE";
            this.regoleBtn.UseVisualStyleBackColor = true;
            this.regoleBtn.Click += new System.EventHandler(this.regoleBtn_Click);
            // 
            // esciBtn
            // 
            this.esciBtn.BackColor = System.Drawing.Color.Maroon;
            this.esciBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("esciBtn.BackgroundImage")));
            this.esciBtn.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.esciBtn.ForeColor = System.Drawing.Color.Yellow;
            this.esciBtn.Location = new System.Drawing.Point(59, 406);
            this.esciBtn.Name = "esciBtn";
            this.esciBtn.Size = new System.Drawing.Size(307, 81);
            this.esciBtn.TabIndex = 3;
            this.esciBtn.Text = "ESCI";
            this.esciBtn.UseVisualStyleBackColor = false;
            this.esciBtn.Click += new System.EventHandler(this.esciBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(109, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 117);
            this.label1.TabIndex = 4;
            this.label1.Text = "UNO!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1306, 731);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.esciBtn);
            this.Controls.Add(this.regoleBtn);
            this.Controls.Add(this.giocaBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button giocaBtn;
        private System.Windows.Forms.Button regoleBtn;
        private System.Windows.Forms.Button esciBtn;
        private System.Windows.Forms.Label label1;
    }
}

