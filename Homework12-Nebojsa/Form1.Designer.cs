namespace Homework12_Nebojsa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCircleAreaPerimeter = new System.Windows.Forms.Button();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(60, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Perimeter (2r * pi)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(60, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Area (r*r*Pi)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(60, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pi = 3.14";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimeter.Location = new System.Drawing.Point(156, 175);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(18, 20);
            this.lblPerimeter.TabIndex = 3;
            this.lblPerimeter.Text = "0";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(156, 205);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(18, 20);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Radius of circle";
            // 
            // btnCircleAreaPerimeter
            // 
            this.btnCircleAreaPerimeter.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCircleAreaPerimeter.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnCircleAreaPerimeter.FlatAppearance.BorderSize = 2;
            this.btnCircleAreaPerimeter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCircleAreaPerimeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCircleAreaPerimeter.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCircleAreaPerimeter.Location = new System.Drawing.Point(160, 100);
            this.btnCircleAreaPerimeter.Name = "btnCircleAreaPerimeter";
            this.btnCircleAreaPerimeter.Size = new System.Drawing.Size(95, 37);
            this.btnCircleAreaPerimeter.TabIndex = 6;
            this.btnCircleAreaPerimeter.Text = "Calculate";
            this.btnCircleAreaPerimeter.UseVisualStyleBackColor = false;
            this.btnCircleAreaPerimeter.Click += new System.EventHandler(this.btnCircleAreaPerimeter_Click);
            this.btnCircleAreaPerimeter.MouseEnter += new System.EventHandler(this.btnCircleAreaPerimeter_MouseEnter);
            // 
            // txtRadius
            // 
            this.txtRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRadius.Location = new System.Drawing.Point(160, 55);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(95, 23);
            this.txtRadius.TabIndex = 7;
            this.txtRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.btnCircleAreaPerimeter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCircleAreaPerimeter;
        private System.Windows.Forms.TextBox txtRadius;
    }
}

