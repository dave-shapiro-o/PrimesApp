
namespace PrimesApp
{
    partial class PrimeFinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimeFinder));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.answerTextLeft = new System.Windows.Forms.Label();
            this.answerTextRight = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.calculatingLabel = new System.Windows.Forms.Label();
            this.pBoxClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.Color.Azure;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.Location = new System.Drawing.Point(319, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 28);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.calculateButton.FlatAppearance.BorderSize = 0;
            this.calculateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.calculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Noto Sans Cond", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculateButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.calculateButton.Location = new System.Drawing.Point(333, 227);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(0);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(122, 46);
            this.calculateButton.TabIndex = 1;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Noto Sans", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.LightCyan;
            this.titleLabel.Location = new System.Drawing.Point(28, 27);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(696, 43);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Sieve Of Eratosthenes - Prime Number Finder";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descriptionLabel.ForeColor = System.Drawing.Color.LightCyan;
            this.descriptionLabel.Location = new System.Drawing.Point(186, 99);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(413, 27);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Enter number to calculate all primes below:";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Noto Sans", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.ForeColor = System.Drawing.Color.Red;
            this.resultLabel.Location = new System.Drawing.Point(309, 297);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 55);
            this.resultLabel.TabIndex = 4;
            // 
            // answerTextLeft
            // 
            this.answerTextLeft.AutoSize = true;
            this.answerTextLeft.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerTextLeft.ForeColor = System.Drawing.Color.LightCyan;
            this.answerTextLeft.Location = new System.Drawing.Point(165, 314);
            this.answerTextLeft.Name = "answerTextLeft";
            this.answerTextLeft.Size = new System.Drawing.Size(0, 33);
            this.answerTextLeft.TabIndex = 5;
            // 
            // answerTextRight
            // 
            this.answerTextRight.AutoSize = true;
            this.answerTextRight.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerTextRight.ForeColor = System.Drawing.Color.LightCyan;
            this.answerTextRight.Location = new System.Drawing.Point(435, 314);
            this.answerTextRight.Name = "answerTextRight";
            this.answerTextRight.Size = new System.Drawing.Size(0, 33);
            this.answerTextRight.TabIndex = 5;
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.showButton.FlatAppearance.BorderSize = 0;
            this.showButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.showButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateBlue;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Font = new System.Drawing.Font("Noto Sans", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.showButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.showButton.Location = new System.Drawing.Point(298, 390);
            this.showButton.Margin = new System.Windows.Forms.Padding(0);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(202, 47);
            this.showButton.TabIndex = 6;
            this.showButton.Text = "SHOW PRIMES";
            this.showButton.UseVisualStyleBackColor = false;
            this.showButton.Visible = false;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // calculatingLabel
            // 
            this.calculatingLabel.AutoSize = true;
            this.calculatingLabel.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculatingLabel.ForeColor = System.Drawing.Color.LightCyan;
            this.calculatingLabel.Location = new System.Drawing.Point(482, 239);
            this.calculatingLabel.Name = "calculatingLabel";
            this.calculatingLabel.Size = new System.Drawing.Size(130, 27);
            this.calculatingLabel.TabIndex = 7;
            this.calculatingLabel.Text = "Calculating...";
            this.calculatingLabel.Visible = false;
            // 
            // pBoxClose
            // 
            this.pBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pBoxClose.Image")));
            this.pBoxClose.Location = new System.Drawing.Point(741, 12);
            this.pBoxClose.Name = "pBoxClose";
            this.pBoxClose.Size = new System.Drawing.Size(47, 46);
            this.pBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxClose.TabIndex = 8;
            this.pBoxClose.TabStop = false;
            this.pBoxClose.Click += new System.EventHandler(this.pBoxClose_Click);
            this.pBoxClose.MouseEnter += new System.EventHandler(this.pBoxClose_MouseEnter);
            this.pBoxClose.MouseLeave += new System.EventHandler(this.pBoxClose_MouseLeave);
            // 
            // PrimeFinder
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.pBoxClose);
            this.Controls.Add(this.calculatingLabel);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.answerTextRight);
            this.Controls.Add(this.answerTextLeft);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "PrimeFinder";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prime Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label answerTextLeft;
        private System.Windows.Forms.Label answerTextRight;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label calculatingLabel;
        private System.Windows.Forms.PictureBox pBoxClose;
    }
}

