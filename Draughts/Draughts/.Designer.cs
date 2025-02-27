﻿
namespace Draughts
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
            this.redCaptured = new System.Windows.Forms.Label();
            this.blueCaptured = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lTurn = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.blueP = new System.Windows.Forms.PictureBox();
            this.redP = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.blueP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redP)).BeginInit();
            this.SuspendLayout();
            // 
            // redCaptured
            // 
            this.redCaptured.AutoSize = true;
            this.redCaptured.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redCaptured.Location = new System.Drawing.Point(863, 126);
            this.redCaptured.Name = "redCaptured";
            this.redCaptured.Size = new System.Drawing.Size(24, 25);
            this.redCaptured.TabIndex = 2;
            this.redCaptured.Text = "0";
            // 
            // blueCaptured
            // 
            this.blueCaptured.AutoSize = true;
            this.blueCaptured.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blueCaptured.Location = new System.Drawing.Point(863, 394);
            this.blueCaptured.Name = "blueCaptured";
            this.blueCaptured.Size = new System.Drawing.Size(24, 25);
            this.blueCaptured.TabIndex = 3;
            this.blueCaptured.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(771, 488);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Show pieces positions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lTurn
            // 
            this.lTurn.AutoSize = true;
            this.lTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTurn.Location = new System.Drawing.Point(771, 271);
            this.lTurn.Name = "lTurn";
            this.lTurn.Size = new System.Drawing.Size(0, 25);
            this.lTurn.TabIndex = 5;
            // 
            // btnGoBack
            // 
            this.btnGoBack.Location = new System.Drawing.Point(771, 547);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(116, 35);
            this.btnGoBack.TabIndex = 6;
            this.btnGoBack.Text = "Exit Game";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // blueP
            // 
            this.blueP.Image = global::Draughts.Properties.Resources.blueTransparent;
            this.blueP.Location = new System.Drawing.Point(771, 373);
            this.blueP.Name = "blueP";
            this.blueP.Size = new System.Drawing.Size(60, 60);
            this.blueP.TabIndex = 1;
            this.blueP.TabStop = false;
            // 
            // redP
            // 
            this.redP.Image = global::Draughts.Properties.Resources.redTransparent;
            this.redP.Location = new System.Drawing.Point(771, 110);
            this.redP.Name = "redP";
            this.redP.Size = new System.Drawing.Size(60, 60);
            this.redP.TabIndex = 0;
            this.redP.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1075, 764);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.lTurn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.blueCaptured);
            this.Controls.Add(this.redCaptured);
            this.Controls.Add(this.blueP);
            this.Controls.Add(this.redP);
            this.Name = "Form1";
            this.Text = "English Draughts";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.blueP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox redP;
        private System.Windows.Forms.PictureBox blueP;
        private System.Windows.Forms.Label redCaptured;
        private System.Windows.Forms.Label blueCaptured;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lTurn;
        private System.Windows.Forms.Button btnGoBack;
    }
}

