
namespace PrimesApp
{
    partial class ListDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListDisplay));
            this.displayOfPrimes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // displayOfPrimes
            // 
            this.displayOfPrimes.AcceptsReturn = true;
            this.displayOfPrimes.AcceptsTab = true;
            this.displayOfPrimes.AllowDrop = true;
            this.displayOfPrimes.BackColor = System.Drawing.Color.MidnightBlue;
            this.displayOfPrimes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayOfPrimes.ForeColor = System.Drawing.Color.LightCyan;
            this.displayOfPrimes.Location = new System.Drawing.Point(0, 0);
            this.displayOfPrimes.Margin = new System.Windows.Forms.Padding(5);
            this.displayOfPrimes.Multiline = true;
            this.displayOfPrimes.Name = "displayOfPrimes";
            this.displayOfPrimes.ReadOnly = true;
            this.displayOfPrimes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.displayOfPrimes.Size = new System.Drawing.Size(868, 509);
            this.displayOfPrimes.TabIndex = 0;
            // 
            // ListDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(867, 508);
            this.Controls.Add(this.displayOfPrimes);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "ListDisplay";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "List of Primes";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayOfPrimes;
    }
}