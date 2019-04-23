namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.obrazek = new System.Windows.Forms.PictureBox();
            this.timerSpadanie = new System.Windows.Forms.Timer(this.components);
            this.lblPunkty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).BeginInit();
            this.SuspendLayout();
            // 
            // obrazek
            // 
            this.obrazek.Location = new System.Drawing.Point(4, 18);
            this.obrazek.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.obrazek.Name = "obrazek";
            this.obrazek.Size = new System.Drawing.Size(1584, 848);
            this.obrazek.TabIndex = 4;
            this.obrazek.TabStop = false;
            this.obrazek.MouseClick += new System.Windows.Forms.MouseEventHandler(this.obrazek_MouseClick);
            // 
            // timerSpadanie
            // 
            this.timerSpadanie.Enabled = true;
            this.timerSpadanie.Interval = 750;
            this.timerSpadanie.Tick += new System.EventHandler(this.timerSpadanie_Tick);
            // 
            // lblPunkty
            // 
            this.lblPunkty.AutoSize = true;
            this.lblPunkty.Location = new System.Drawing.Point(6, 877);
            this.lblPunkty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPunkty.Name = "lblPunkty";
            this.lblPunkty.Size = new System.Drawing.Size(0, 20);
            this.lblPunkty.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 911);
            this.Controls.Add(this.obrazek);
            this.Controls.Add(this.lblPunkty);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.obrazek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox obrazek;
        private System.Windows.Forms.Timer timerSpadanie;
        private System.Windows.Forms.Label lblPunkty;
    }
}

