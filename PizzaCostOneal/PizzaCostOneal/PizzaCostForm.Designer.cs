namespace PizzaCostOneal
{
    partial class PizzaCostForm
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
            this.lblSelectSize = new System.Windows.Forms.Label();
            this.lblTopping = new System.Windows.Forms.Label();
            this.nudTopping = new System.Windows.Forms.NumericUpDown();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radExtraLarge = new System.Windows.Forms.RadioButton();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblDrinks = new System.Windows.Forms.Label();
            this.radCoke = new System.Windows.Forms.RadioButton();
            this.radSprite = new System.Windows.Forms.RadioButton();
            this.radPepsi = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudTopping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectSize
            // 
            this.lblSelectSize.AutoSize = true;
            this.lblSelectSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectSize.Location = new System.Drawing.Point(12, 40);
            this.lblSelectSize.Name = "lblSelectSize";
            this.lblSelectSize.Size = new System.Drawing.Size(276, 25);
            this.lblSelectSize.TabIndex = 0;
            this.lblSelectSize.Text = "Select the size of the pizza ";
            // 
            // lblTopping
            // 
            this.lblTopping.AutoSize = true;
            this.lblTopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopping.Location = new System.Drawing.Point(40, 312);
            this.lblTopping.Name = "lblTopping";
            this.lblTopping.Size = new System.Drawing.Size(287, 25);
            this.lblTopping.TabIndex = 5;
            this.lblTopping.Text = "Select the number of topping";
            // 
            // nudTopping
            // 
            this.nudTopping.Location = new System.Drawing.Point(375, 316);
            this.nudTopping.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudTopping.Name = "nudTopping";
            this.nudTopping.Size = new System.Drawing.Size(120, 20);
            this.nudTopping.TabIndex = 6;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(56, 380);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(98, 25);
            this.lblSubtotal.TabIndex = 7;
            this.lblSubtotal.Text = "SubTotal";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(56, 504);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 25);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "Total";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(56, 442);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(44, 25);
            this.lblTax.TabIndex = 9;
            this.lblTax.Text = "Hst";
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(749, 47);
            this.nudSize.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(120, 20);
            this.nudSize.TabIndex = 11;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(389, 186);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(135, 41);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PizzaCostOneal.Properties.Resources.pizza;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(943, 567);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // radSmall
            // 
            this.radSmall.AutoSize = true;
            this.radSmall.Location = new System.Drawing.Point(45, 104);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(50, 17);
            this.radSmall.TabIndex = 13;
            this.radSmall.TabStop = true;
            this.radSmall.Text = "Small";
            this.radSmall.UseVisualStyleBackColor = true;
            // 
            // radMedium
            // 
            this.radMedium.AutoSize = true;
            this.radMedium.Location = new System.Drawing.Point(45, 146);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(62, 17);
            this.radMedium.TabIndex = 14;
            this.radMedium.TabStop = true;
            this.radMedium.Text = "Medium";
            this.radMedium.UseVisualStyleBackColor = true;
            // 
            // radExtraLarge
            // 
            this.radExtraLarge.AutoSize = true;
            this.radExtraLarge.Location = new System.Drawing.Point(50, 222);
            this.radExtraLarge.Name = "radExtraLarge";
            this.radExtraLarge.Size = new System.Drawing.Size(76, 17);
            this.radExtraLarge.TabIndex = 15;
            this.radExtraLarge.TabStop = true;
            this.radExtraLarge.Text = "Exra Large";
            this.radExtraLarge.UseVisualStyleBackColor = true;
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.Location = new System.Drawing.Point(45, 186);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(52, 17);
            this.radLarge.TabIndex = 16;
            this.radLarge.TabStop = true;
            this.radLarge.Text = "Large";
            this.radLarge.UseVisualStyleBackColor = true;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(384, 42);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(309, 25);
            this.lblNumber.TabIndex = 17;
            this.lblNumber.Text = "Select the number of the pizza ";
            // 
            // lblDrinks
            // 
            this.lblDrinks.AutoSize = true;
            this.lblDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrinks.Location = new System.Drawing.Point(741, 312);
            this.lblDrinks.Name = "lblDrinks";
            this.lblDrinks.Size = new System.Drawing.Size(62, 24);
            this.lblDrinks.TabIndex = 18;
            this.lblDrinks.Text = "Drinks";
            // 
            // radCoke
            // 
            this.radCoke.AutoSize = true;
            this.radCoke.Location = new System.Drawing.Point(745, 351);
            this.radCoke.Name = "radCoke";
            this.radCoke.Size = new System.Drawing.Size(50, 17);
            this.radCoke.TabIndex = 19;
            this.radCoke.TabStop = true;
            this.radCoke.Text = "Coke";
            this.radCoke.UseVisualStyleBackColor = true;
            // 
            // radSprite
            // 
            this.radSprite.AutoSize = true;
            this.radSprite.Location = new System.Drawing.Point(749, 388);
            this.radSprite.Name = "radSprite";
            this.radSprite.Size = new System.Drawing.Size(52, 17);
            this.radSprite.TabIndex = 20;
            this.radSprite.TabStop = true;
            this.radSprite.Text = "Sprite";
            this.radSprite.UseVisualStyleBackColor = true;
            // 
            // radPepsi
            // 
            this.radPepsi.AutoSize = true;
            this.radPepsi.Location = new System.Drawing.Point(749, 427);
            this.radPepsi.Name = "radPepsi";
            this.radPepsi.Size = new System.Drawing.Size(51, 17);
            this.radPepsi.TabIndex = 21;
            this.radPepsi.TabStop = true;
            this.radPepsi.Text = "Pepsi";
            this.radPepsi.UseVisualStyleBackColor = true;
            // 
            // PizzaCostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 556);
            this.Controls.Add(this.radPepsi);
            this.Controls.Add(this.radSprite);
            this.Controls.Add(this.radCoke);
            this.Controls.Add(this.lblDrinks);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.radLarge);
            this.Controls.Add(this.radExtraLarge);
            this.Controls.Add(this.radMedium);
            this.Controls.Add(this.radSmall);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.nudSize);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.nudTopping);
            this.Controls.Add(this.lblTopping);
            this.Controls.Add(this.lblSelectSize);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PizzaCostForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudTopping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectSize;
        private System.Windows.Forms.Label lblTopping;
        private System.Windows.Forms.NumericUpDown nudTopping;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.RadioButton radExtraLarge;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblDrinks;
        private System.Windows.Forms.RadioButton radCoke;
        private System.Windows.Forms.RadioButton radSprite;
        private System.Windows.Forms.RadioButton radPepsi;
    }
}

