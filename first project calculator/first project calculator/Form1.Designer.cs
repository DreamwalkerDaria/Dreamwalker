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
            this.Onedivfarg = new System.Windows.Forms.Button();
            this.Grad = new System.Windows.Forms.Button();
            this.Max = new System.Windows.Forms.Button();
            this.Min = new System.Windows.Forms.Button();
            this.Average = new System.Windows.Forms.Button();
            this.Geommean = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 47);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 266);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(193, 22);
            this.textBox3.TabIndex = 2;
            // 
            // Addition
            // 
            this.Addition.Location = new System.Drawing.Point(16, 79);
            this.Addition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(93, 86);
            this.Addition.TabIndex = 3;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.operations);
            // 
            // Subtraction
            // 
            this.Subtraction.Location = new System.Drawing.Point(117, 79);
            this.Subtraction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(93, 86);
            this.Subtraction.TabIndex = 4;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.operations);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(16, 172);
            this.Multiply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(93, 86);
            this.Multiply.TabIndex = 5;
            this.Multiply.Text = "x";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.operations);
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(117, 172);
            this.Division.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(93, 86);
            this.Division.TabIndex = 6;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.operations);
            // 
            // Degree
            // 
            this.Degree.Location = new System.Drawing.Point(219, 79);
            this.Degree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Degree.Name = "Degree";
            this.Degree.Size = new System.Drawing.Size(93, 37);
            this.Degree.TabIndex = 7;
            this.Degree.Text = "Degree";
            this.Degree.UseVisualStyleBackColor = true;
            this.Degree.Click += new System.EventHandler(this.oneoperations);
            // 
            // Root
            // 
            this.Root.Location = new System.Drawing.Point(421, 79);
            this.Root.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(97, 37);
            this.Root.TabIndex = 8;
            this.Root.Text = "Root";
            this.Root.UseVisualStyleBackColor = true;
            this.Root.Click += new System.EventHandler(this.oneoperations);
            // 
            // Cube
            // 
            this.Cube.Location = new System.Drawing.Point(320, 79);
            this.Cube.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cube.Name = "Cube";
            this.Cube.Size = new System.Drawing.Size(93, 37);
            this.Cube.TabIndex = 9;
            this.Cube.Text = "Cube";
            this.Cube.UseVisualStyleBackColor = true;
            this.Cube.Click += new System.EventHandler(this.oneoperations);
            // 
            // Tg
            // 
            this.Tg.Location = new System.Drawing.Point(219, 215);
            this.Tg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tg.Name = "Tg";
            this.Tg.Size = new System.Drawing.Size(47, 43);
            this.Tg.TabIndex = 10;
            this.Tg.Text = "Tg";
            this.Tg.UseVisualStyleBackColor = true;
            this.Tg.Click += new System.EventHandler(this.oneoperations);
            // 
            // Ctg
            // 
            this.Ctg.Location = new System.Drawing.Point(265, 215);
            this.Ctg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ctg.Name = "Ctg";
            this.Ctg.Size = new System.Drawing.Size(47, 43);
            this.Ctg.TabIndex = 11;
            this.Ctg.Text = "Ctg";
            this.Ctg.UseVisualStyleBackColor = true;
            this.Ctg.Click += new System.EventHandler(this.oneoperations);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(219, 172);
            this.Sin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(47, 43);
            this.Sin.TabIndex = 12;
            this.Sin.Text = "Sin";
            this.Sin.UseVisualStyleBackColor = true;
            this.Sin.Click += new System.EventHandler(this.oneoperations);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(265, 172);
            this.Cos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(47, 43);
            this.Cos.TabIndex = 13;
            this.Cos.Text = "Cos";
            this.Cos.UseVisualStyleBackColor = true;
            this.Cos.Click += new System.EventHandler(this.oneoperations);
            // 
            // Module
            // 
            this.Module.Location = new System.Drawing.Point(219, 128);
            this.Module.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(93, 37);
            this.Module.TabIndex = 14;
            this.Module.Text = "Module";
            this.Module.UseVisualStyleBackColor = true;
            this.Module.Click += new System.EventHandler(this.oneoperations);
            // 
            // Ln
            // 
            this.Ln.Location = new System.Drawing.Point(320, 128);
            this.Ln.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ln.Name = "Ln";
            this.Ln.Size = new System.Drawing.Size(93, 37);
            this.Ln.TabIndex = 15;
            this.Ln.Text = "Ln";
            this.Ln.UseVisualStyleBackColor = true;
            this.Ln.Click += new System.EventHandler(this.oneoperations);
            // 
            // Exp
            // 
            this.Exp.Location = new System.Drawing.Point(421, 128);
            this.Exp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exp.Name = "Exp";
            this.Exp.Size = new System.Drawing.Size(97, 37);
            this.Exp.TabIndex = 16;
            this.Exp.Text = "Exp";
            this.Exp.UseVisualStyleBackColor = true;
            this.Exp.Click += new System.EventHandler(this.oneoperations);
            // 
            // Onedivfarg
            // 
            this.Onedivfarg.Location = new System.Drawing.Point(320, 172);
            this.Onedivfarg.Margin = new System.Windows.Forms.Padding(4);
            this.Onedivfarg.Name = "Onedivfarg";
            this.Onedivfarg.Size = new System.Drawing.Size(47, 43);
            this.Onedivfarg.TabIndex = 17;
            this.Onedivfarg.Text = "1/x";
            this.Onedivfarg.UseVisualStyleBackColor = true;
            this.Onedivfarg.Click += new System.EventHandler(this.oneoperations);
            // 
            // Grad
            // 
            this.Grad.Location = new System.Drawing.Point(366, 172);
            this.Grad.Margin = new System.Windows.Forms.Padding(4);
            this.Grad.Name = "Grad";
            this.Grad.Size = new System.Drawing.Size(47, 43);
            this.Grad.TabIndex = 18;
            this.Grad.Text = "grad";
            this.Grad.UseVisualStyleBackColor = true;
            this.Grad.Click += new System.EventHandler(this.oneoperations);
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(219, 47);
            this.Max.Margin = new System.Windows.Forms.Padding(4);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(148, 24);
            this.Max.TabIndex = 19;
            this.Max.Text = "Max";
            this.Max.UseVisualStyleBackColor = true;
            this.Max.Click += new System.EventHandler(this.operations);
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(370, 47);
            this.Min.Margin = new System.Windows.Forms.Padding(4);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(148, 24);
            this.Min.TabIndex = 20;
            this.Min.Text = "Min";
            this.Min.UseVisualStyleBackColor = true;
            this.Min.Click += new System.EventHandler(this.operations);
            // 
            // Average
            // 
            this.Average.Location = new System.Drawing.Point(219, 15);
            this.Average.Margin = new System.Windows.Forms.Padding(4);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(148, 24);
            this.Average.TabIndex = 21;
            this.Average.Text = "Average";
            this.Average.UseVisualStyleBackColor = true;
            this.Average.Click += new System.EventHandler(this.operations);
            // 
            // Geommean
            // 
            this.Geommean.Location = new System.Drawing.Point(370, 15);
            this.Geommean.Margin = new System.Windows.Forms.Padding(4);
            this.Geommean.Name = "Geommean";
            this.Geommean.Size = new System.Drawing.Size(148, 24);
            this.Geommean.TabIndex = 22;
            this.Geommean.Text = "Geom mean";
            this.Geommean.UseVisualStyleBackColor = true;
            this.Geommean.Click += new System.EventHandler(this.operations);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 305);
            this.Controls.Add(this.Geommean);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Max);
            this.Controls.Add(this.Grad);
            this.Controls.Add(this.Onedivfarg);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button Onedivfarg;
        private System.Windows.Forms.Button Grad;
        private System.Windows.Forms.Button Max;
        private System.Windows.Forms.Button Min;
        private System.Windows.Forms.Button Average;
        private System.Windows.Forms.Button Geommean;
    }
}

