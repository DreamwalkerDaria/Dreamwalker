namespace first_project_calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Addition = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Degree = new System.Windows.Forms.Button();
            this.Root = new System.Windows.Forms.Button();
            this.Cube = new System.Windows.Forms.Button();
            this.Tg = new System.Windows.Forms.Button();
            this.Ctg = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.Button();
            this.Cos = new System.Windows.Forms.Button();
            this.Module = new System.Windows.Forms.Button();
            this.Ln = new System.Windows.Forms.Button();
            this.Exp = new System.Windows.Forms.Button();
            this.Fraction = new System.Windows.Forms.Button();
            this.Misunx = new System.Windows.Forms.Button();
            this.Max = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.Average = new System.Windows.Forms.Button();
            this.Geommean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 216);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 20);
            this.textBox3.TabIndex = 2;
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(12, 64);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(70, 70);
            this.Addition.TabIndex = 3;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.operations);
            // 
            // Subtraction
            // 
            this.Subtraction.Location = new System.Drawing.Point(88, 64);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(70, 70);
            this.Subtraction.TabIndex = 4;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.operations);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(12, 140);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(70, 70);
            this.Multiply.TabIndex = 5;
            this.Multiply.Text = "x";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.operations);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(88, 140);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(70, 70);
            this.Division.TabIndex = 6;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.operations);
            // 
            // Degree
            // 
            this.Degree.Location = new System.Drawing.Point(164, 64);
            this.Degree.Name = "Degree";
            this.Degree.Size = new System.Drawing.Size(70, 30);
            this.Degree.TabIndex = 7;
            this.Degree.Text = "Degree";
            this.Degree.UseVisualStyleBackColor = true;
            this.Degree.Click += new System.EventHandler(this.oneoperations);
            // 
            // Root
            // 
            this.Root.Location = new System.Drawing.Point(316, 64);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(73, 30);
            this.Root.TabIndex = 8;
            this.Root.Text = "Root";
            this.Root.UseVisualStyleBackColor = true;
            this.Root.Click += new System.EventHandler(this.oneoperations);
            // 
            // Cube
            // 
            this.Cube.Location = new System.Drawing.Point(240, 64);
            this.Cube.Name = "Cube";
            this.Cube.Size = new System.Drawing.Size(70, 30);
            this.Cube.TabIndex = 9;
            this.Cube.Text = "Cube";
            this.Cube.UseVisualStyleBackColor = true;
            this.Cube.Click += new System.EventHandler(this.oneoperations);
            // 
            // Tg
            // 
            this.Tg.Location = new System.Drawing.Point(164, 175);
            this.Tg.Name = "Tg";
            this.Tg.Size = new System.Drawing.Size(35, 35);
            this.Tg.TabIndex = 10;
            this.Tg.Text = "Tg";
            this.Tg.UseVisualStyleBackColor = true;
            this.Tg.Click += new System.EventHandler(this.oneoperations);
            // 
            // Ctg
            // 
            this.Ctg.Location = new System.Drawing.Point(199, 175);
            this.Ctg.Name = "Ctg";
            this.Ctg.Size = new System.Drawing.Size(35, 35);
            this.Ctg.TabIndex = 11;
            this.Ctg.Text = "Ctg";
            this.Ctg.UseVisualStyleBackColor = true;
            this.Ctg.Click += new System.EventHandler(this.oneoperations);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(164, 140);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(35, 35);
            this.Sin.TabIndex = 12;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.oneoperations);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(199, 140);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(35, 35);
            this.Cos.TabIndex = 13;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.oneoperations);
            // 
            // Module
            // 
            this.Module.Location = new System.Drawing.Point(164, 104);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(70, 30);
            this.Module.TabIndex = 14;
            this.Module.Text = "Module";
            this.Module.UseVisualStyleBackColor = true;
            this.Module.Click += new System.EventHandler(this.oneoperations);
            // 
            // Ln
            // 
            this.Ln.Location = new System.Drawing.Point(240, 104);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(70, 30);
            this.Ln.TabIndex = 15;
            this.Ln.Text = "Ln";
            this.Ln.UseVisualStyleBackColor = true;
            this.Ln.Click += new System.EventHandler(this.oneoperations);
            // 
            // Exp
            // 
            this.Exp.Location = new System.Drawing.Point(316, 104);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(73, 30);
            this.Exp.TabIndex = 16;
            this.Exp.Text = "Exp";
            this.Exp.UseVisualStyleBackColor = true;
            this.Exp.Click += new System.EventHandler(this.oneoperations);
            // 
            // Fraction
            // 
            this.Fraction.Location = new System.Drawing.Point(240, 140);
            this.Fraction.Name = "Fraction";
            this.Fraction.Size = new System.Drawing.Size(35, 35);
            this.Fraction.TabIndex = 17;
            this.Fraction.Text = "1/x";
            this.Fraction.UseVisualStyleBackColor = true;
            this.Fraction.Click += new System.EventHandler(this.oneoperations);
            // 
            // Misunx
            // 
            this.Misunx.Location = new System.Drawing.Point(274, 140);
            this.Misunx.Name = "Misunx";
            this.Misunx.Size = new System.Drawing.Size(35, 35);
            this.Misunx.TabIndex = 18;
            this.Misunx.Text = "-х";
            this.Misunx.UseVisualStyleBackColor = true;
            this.Misunx.Click += new System.EventHandler(this.oneoperations);
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(164, 38);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(111, 20);
            this.Max.TabIndex = 19;
            this.Max.Text = "Max";
            this.Max.UseVisualStyleBackColor = true;
            this.Max.Click += new System.EventHandler(this.operations);
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(278, 38);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(111, 20);
            this.Min.TabIndex = 20;
            this.Min.Text = "Min";
            this.Min.UseVisualStyleBackColor = true;
            this.Min.Click += new System.EventHandler(this.operations);
            // 
            // Average
            // 
            this.Average.Location = new System.Drawing.Point(164, 12);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(111, 20);
            this.Average.TabIndex = 21;
            this.Average.Text = "Average";
            this.Average.UseVisualStyleBackColor = true;
            this.Average.Click += new System.EventHandler(this.operations);
            // 
            // Geommean
            // 
            this.Geommean.Location = new System.Drawing.Point(278, 12);
            this.Geommean.Name = "Geommean";
            this.Geommean.Size = new System.Drawing.Size(111, 20);
            this.Geommean.TabIndex = 22;
            this.Geommean.Text = "Geom mean";
            this.Geommean.UseVisualStyleBackColor = true;
            this.Geommean.Click += new System.EventHandler(this.operations);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 245);
            this.Controls.Add(this.Geommean);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.Misunx);
            this.Controls.Add(this.Fraction);
            this.Controls.Add(this.Exp);
            this.Controls.Add(this.Ln);
            this.Controls.Add(this.Module);
            this.Controls.Add(this.Cos);
            this.Controls.Add(this.Sin);
            this.Controls.Add(this.Ctg);
            this.Controls.Add(this.Tg);
            this.Controls.Add(this.Cube);
            this.Controls.Add(this.Root);
            this.Controls.Add(this.Degree);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Degree;
        private System.Windows.Forms.Button Root;
        private System.Windows.Forms.Button Cube;
        private System.Windows.Forms.Button Tg;
        private System.Windows.Forms.Button Ctg;
        private System.Windows.Forms.Button Sin;
        private System.Windows.Forms.Button Cos;
        private System.Windows.Forms.Button Module;
        private System.Windows.Forms.Button Ln;
        private System.Windows.Forms.Button Exp;
        private System.Windows.Forms.Button Fraction;
        private System.Windows.Forms.Button Misunx;
        private System.Windows.Forms.Button Max;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Button Average;
        private System.Windows.Forms.Button Geommean;
    }
}

