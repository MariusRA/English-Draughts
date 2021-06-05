
namespace Draughts
{
    partial class redWon
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
            this.labelRedWon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelRedWon
            // 
            this.labelRedWon.AutoSize = true;
            this.labelRedWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRedWon.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelRedWon.Location = new System.Drawing.Point(256, 191);
            this.labelRedWon.Name = "labelRedWon";
            this.labelRedWon.Size = new System.Drawing.Size(278, 69);
            this.labelRedWon.TabIndex = 0;
            this.labelRedWon.Text = "Red Won";
            // 
            // redWon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRedWon);
            this.Name = "redWon";
            this.Text = "Game Ended";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRedWon;
    }
}