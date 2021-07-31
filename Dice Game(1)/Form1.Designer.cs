
namespace Dice_Game_1_
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
            this.textCurrentScore = new System.Windows.Forms.TextBox();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textCurrentScore
            // 
            this.textCurrentScore.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textCurrentScore.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textCurrentScore.Location = new System.Drawing.Point(59, 42);
            this.textCurrentScore.Multiline = true;
            this.textCurrentScore.Name = "textCurrentScore";
            this.textCurrentScore.Size = new System.Drawing.Size(592, 257);
            this.textCurrentScore.TabIndex = 0;
            // 
            // btnRollDice
            // 
            this.btnRollDice.BackColor = System.Drawing.SystemColors.Window;
            this.btnRollDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollDice.ForeColor = System.Drawing.Color.Blue;
            this.btnRollDice.Location = new System.Drawing.Point(651, 42);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(117, 63);
            this.btnRollDice.TabIndex = 1;
            this.btnRollDice.Text = "Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = false;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRollDice);
            this.Controls.Add(this.textCurrentScore);
            this.Name = "Form1";
            this.Text = "Dice Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textCurrentScore;
        private System.Windows.Forms.Button btnRollDice;
    }
}

