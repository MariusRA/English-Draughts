
namespace Draughts
{
    partial class blueWon
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
            this.labelBlueWon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBlueWon
            // 
            this.labelBlueWon.AutoSize = true;
            this.labelBlueWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlueWon.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelBlueWon.Location = new System.Drawing.Point(252, 187);
            this.labelBlueWon.Name = "labelBlueWon";
            this.labelBlueWon.Size = new System.Drawing.Size(289, 69);
            this.labelBlueWon.TabIndex = 0;
            this.labelBlueWon.Text = "Blue Won";
            // 
            // blueWon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelBlueWon);
            this.Name = "blueWon";
            this.Text = "Game Ended";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBlueWon;
    }
}