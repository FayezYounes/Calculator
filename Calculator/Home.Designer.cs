namespace Calculator
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_title = new System.Windows.Forms.Label();
            this.but_close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.but_divide = new System.Windows.Forms.Button();
            this.but_multiply = new System.Windows.Forms.Button();
            this.but_mynus = new System.Windows.Forms.Button();
            this.but_sum = new System.Windows.Forms.Button();
            this.but_equal = new System.Windows.Forms.Button();
            this.but_mod = new System.Windows.Forms.Button();
            this.but_nine = new System.Windows.Forms.Button();
            this.but_CE = new System.Windows.Forms.Button();
            this.but_eight = new System.Windows.Forms.Button();
            this.but_six = new System.Windows.Forms.Button();
            this.but_five = new System.Windows.Forms.Button();
            this.but_three = new System.Windows.Forms.Button();
            this.but_C = new System.Windows.Forms.Button();
            this.but_seven = new System.Windows.Forms.Button();
            this.but_two = new System.Windows.Forms.Button();
            this.but_four = new System.Windows.Forms.Button();
            this.but_dot = new System.Windows.Forms.Button();
            this.but_one = new System.Windows.Forms.Button();
            this.but_zero = new System.Windows.Forms.Button();
            this.but_negative = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lab_2 = new System.Windows.Forms.Label();
            this.lab_1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lab_title);
            this.panel1.Controls.Add(this.but_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 55);
            this.panel1.TabIndex = 0;
            // 
            // lab_title
            // 
            this.lab_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lab_title.Font = new System.Drawing.Font("Tempus Sans ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.lab_title.Location = new System.Drawing.Point(0, 0);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(273, 55);
            this.lab_title.TabIndex = 1;
            this.lab_title.Text = "Calculator\r\n";
            this.lab_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lab_title_MouseDown);
            this.lab_title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Lab_title_MouseMove);
            this.lab_title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Lab_title_MouseUp);
            // 
            // but_close
            // 
            this.but_close.BackColor = System.Drawing.Color.Transparent;
            this.but_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.but_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.but_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_close.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.but_close.Location = new System.Drawing.Point(273, 0);
            this.but_close.Name = "but_close";
            this.but_close.Size = new System.Drawing.Size(68, 55);
            this.but_close.TabIndex = 0;
            this.but_close.Text = "X";
            this.but_close.UseVisualStyleBackColor = false;
            this.but_close.Click += new System.EventHandler(this.But_close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.but_divide);
            this.panel2.Controls.Add(this.but_multiply);
            this.panel2.Controls.Add(this.but_mynus);
            this.panel2.Controls.Add(this.but_sum);
            this.panel2.Controls.Add(this.but_equal);
            this.panel2.Controls.Add(this.but_mod);
            this.panel2.Controls.Add(this.but_nine);
            this.panel2.Controls.Add(this.but_CE);
            this.panel2.Controls.Add(this.but_eight);
            this.panel2.Controls.Add(this.but_six);
            this.panel2.Controls.Add(this.but_five);
            this.panel2.Controls.Add(this.but_three);
            this.panel2.Controls.Add(this.but_C);
            this.panel2.Controls.Add(this.but_seven);
            this.panel2.Controls.Add(this.but_two);
            this.panel2.Controls.Add(this.but_four);
            this.panel2.Controls.Add(this.but_dot);
            this.panel2.Controls.Add(this.but_one);
            this.panel2.Controls.Add(this.but_zero);
            this.panel2.Controls.Add(this.but_negative);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 364);
            this.panel2.TabIndex = 1;
            // 
            // but_divide
            // 
            this.but_divide.BackColor = System.Drawing.Color.Transparent;
            this.but_divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_divide.Font = new System.Drawing.Font("Tempus Sans ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_divide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.but_divide.Location = new System.Drawing.Point(252, 17);
            this.but_divide.Name = "but_divide";
            this.but_divide.Size = new System.Drawing.Size(75, 61);
            this.but_divide.TabIndex = 0;
            this.but_divide.Text = "/";
            this.but_divide.UseVisualStyleBackColor = false;
            this.but_divide.Click += new System.EventHandler(this.But_operation_Click);
            // 
            // but_multiply
            // 
            this.but_multiply.BackColor = System.Drawing.Color.Transparent;
            this.but_multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_multiply.Font = new System.Drawing.Font("Tempus Sans ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_multiply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.but_multiply.Location = new System.Drawing.Point(252, 84);
            this.but_multiply.Name = "but_multiply";
            this.but_multiply.Size = new System.Drawing.Size(75, 61);
            this.but_multiply.TabIndex = 0;
            this.but_multiply.Text = "X";
            this.but_multiply.UseVisualStyleBackColor = false;
            this.but_multiply.Click += new System.EventHandler(this.But_operation_Click);
            // 
            // but_mynus
            // 
            this.but_mynus.BackColor = System.Drawing.Color.Transparent;
            this.but_mynus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_mynus.Font = new System.Drawing.Font("Tempus Sans ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_mynus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.but_mynus.Location = new System.Drawing.Point(252, 151);
            this.but_mynus.Name = "but_mynus";
            this.but_mynus.Size = new System.Drawing.Size(75, 61);
            this.but_mynus.TabIndex = 0;
            this.but_mynus.Text = "-";
            this.but_mynus.UseVisualStyleBackColor = false;
            this.but_mynus.Click += new System.EventHandler(this.But_operation_Click);
            // 
            // but_sum
            // 
            this.but_sum.BackColor = System.Drawing.Color.Transparent;
            this.but_sum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_sum.Font = new System.Drawing.Font("Tempus Sans ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_sum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.but_sum.Location = new System.Drawing.Point(252, 218);
            this.but_sum.Name = "but_sum";
            this.but_sum.Size = new System.Drawing.Size(75, 61);
            this.but_sum.TabIndex = 0;
            this.but_sum.Text = "+";
            this.but_sum.UseVisualStyleBackColor = false;
            this.but_sum.Click += new System.EventHandler(this.But_operation_Click);
            // 
            // but_equal
            // 
            this.but_equal.BackColor = System.Drawing.Color.Transparent;
            this.but_equal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_equal.Font = new System.Drawing.Font("Tempus Sans ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_equal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.but_equal.Location = new System.Drawing.Point(252, 285);
            this.but_equal.Name = "but_equal";
            this.but_equal.Size = new System.Drawing.Size(75, 61);
            this.but_equal.TabIndex = 0;
            this.but_equal.Text = "=";
            this.but_equal.UseVisualStyleBackColor = false;
            this.but_equal.Click += new System.EventHandler(this.But_equal_Click);
            // 
            // but_mod
            // 
            this.but_mod.BackColor = System.Drawing.Color.Transparent;
            this.but_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_mod.Font = new System.Drawing.Font("Tempus Sans ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_mod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.but_mod.Location = new System.Drawing.Point(171, 17);
            this.but_mod.Name = "but_mod";
            this.but_mod.Size = new System.Drawing.Size(75, 61);
            this.but_mod.TabIndex = 0;
            this.but_mod.Text = "%";
            this.but_mod.UseVisualStyleBackColor = false;
            this.but_mod.Click += new System.EventHandler(this.But_operation_Click);
            // 
            // but_nine
            // 
            this.but_nine.BackColor = System.Drawing.Color.Transparent;
            this.but_nine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_nine.Font = new System.Drawing.Font("Tempus Sans ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_nine.ForeColor = System.Drawing.Color.Black;
            this.but_nine.Location = new System.Drawing.Point(171, 84);
            this.but_nine.Name = "but_nine";
            this.but_nine.Size = new System.Drawing.Size(75, 61);
            this.but_nine.TabIndex = 0;
            this.but_nine.Text = "9\r\n";
            this.but_nine.UseVisualStyleBackColor = false;
            this.but_nine.Click += new System.EventHandler(this.But_Click);
            // 
            // but_CE
            // 
            this.but_CE.BackColor = System.Drawing.Color.Transparent;
            this.but_CE.CausesValidation = false;
            this.but_CE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_CE.Font = new System.Drawing.Font("Tempus Sans ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_CE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.but_CE.Location = new System.Drawing.Point(90, 17);
            this.but_CE.Name = "but_CE";
            this.but_CE.Size = new System.Drawing.Size(75, 61);
            this.but_CE.TabIndex = 0;
            this.but_CE.Text = "CE";
            this.but_CE.UseVisualStyleBackColor = false;
            this.but_CE.Click += new System.EventHandler(this.But_ce_Click);
            // 
            // but_eight
            // 
            this.but_eight.BackColor = System.Drawing.Color.Transparent;
            this.but_eight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_eight.Font = new System.Drawing.Font("Tempus Sans ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_eight.ForeColor = System.Drawing.Color.Black;
            this.but_eight.Location = new System.Drawing.Point(90, 84);
            this.but_eight.Name = "but_eight";
            this.but_eight.Size = new System.Drawing.Size(75, 61);
            this.but_eight.TabIndex = 0;
            this.but_eight.Text = "8";
            this.but_eight.UseVisualStyleBackColor = false;
            this.but_eight.Click += new System.EventHandler(this.But_Click);
            // 
            // but_six
            // 
            this.but_six.BackColor = System.Drawing.Color.Transparent;
            this.but_six.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_six.Font = new System.Drawing.Font("Tempus Sans ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_six.ForeColor = System.Drawing.Color.Black;
            this.but_six.Location = new System.Drawing.Point(171, 151);
            this.but_six.Name = "but_six";
            this.but_six.Size = new System.Drawing.Size(75, 61);
            this.but_six.TabIndex = 0;
            this.but_six.Text = "6";
            this.but_six.UseVisualStyleBackColor = false;
            this.but_six.Click += new System.EventHandler(this.But_Click);
            // 
            // but_five
            // 
            this.but_five.BackColor = System.Drawing.Color.Transparent;
            this.but_five.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_five.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_five.ForeColor = System.Drawing.Color.Black;
            this.but_five.Location = new System.Drawing.Point(90, 151);
            this.but_five.Name = "but_five";
            this.but_five.Size = new System.Drawing.Size(75, 61);
            this.but_five.TabIndex = 0;
            this.but_five.Text = "5";
            this.but_five.UseVisualStyleBackColor = false;
            this.but_five.Click += new System.EventHandler(this.But_Click);
            // 
            // but_three
            // 
            this.but_three.BackColor = System.Drawing.Color.Transparent;
            this.but_three.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_three.Font = new System.Drawing.Font("Tempus Sans ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_three.ForeColor = System.Drawing.Color.Black;
            this.but_three.Location = new System.Drawing.Point(171, 218);
            this.but_three.Name = "but_three";
            this.but_three.Size = new System.Drawing.Size(75, 61);
            this.but_three.TabIndex = 0;
            this.but_three.Text = "3";
            this.but_three.UseVisualStyleBackColor = false;
            this.but_three.Click += new System.EventHandler(this.But_Click);
            // 
            // but_C
            // 
            this.but_C.BackColor = System.Drawing.Color.Transparent;
            this.but_C.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_C.Font = new System.Drawing.Font("Tempus Sans ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_C.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.but_C.Location = new System.Drawing.Point(9, 17);
            this.but_C.Name = "but_C";
            this.but_C.Size = new System.Drawing.Size(75, 61);
            this.but_C.TabIndex = 0;
            this.but_C.Text = "C";
            this.but_C.UseVisualStyleBackColor = false;
            this.but_C.Click += new System.EventHandler(this.But_c_Click);
            // 
            // but_seven
            // 
            this.but_seven.BackColor = System.Drawing.Color.Transparent;
            this.but_seven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_seven.Font = new System.Drawing.Font("Tempus Sans ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_seven.ForeColor = System.Drawing.Color.Black;
            this.but_seven.Location = new System.Drawing.Point(9, 84);
            this.but_seven.Name = "but_seven";
            this.but_seven.Size = new System.Drawing.Size(75, 61);
            this.but_seven.TabIndex = 0;
            this.but_seven.Text = "7";
            this.but_seven.UseVisualStyleBackColor = false;
            this.but_seven.Click += new System.EventHandler(this.But_Click);
            // 
            // but_two
            // 
            this.but_two.BackColor = System.Drawing.Color.Transparent;
            this.but_two.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_two.Font = new System.Drawing.Font("Tempus Sans ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_two.ForeColor = System.Drawing.Color.Black;
            this.but_two.Location = new System.Drawing.Point(90, 218);
            this.but_two.Name = "but_two";
            this.but_two.Size = new System.Drawing.Size(75, 61);
            this.but_two.TabIndex = 0;
            this.but_two.Text = "2";
            this.but_two.UseVisualStyleBackColor = false;
            this.but_two.Click += new System.EventHandler(this.But_Click);
            // 
            // but_four
            // 
            this.but_four.BackColor = System.Drawing.Color.Transparent;
            this.but_four.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_four.Font = new System.Drawing.Font("Tempus Sans ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_four.ForeColor = System.Drawing.Color.Black;
            this.but_four.Location = new System.Drawing.Point(9, 151);
            this.but_four.Name = "but_four";
            this.but_four.Size = new System.Drawing.Size(75, 61);
            this.but_four.TabIndex = 0;
            this.but_four.Text = "4";
            this.but_four.UseVisualStyleBackColor = false;
            this.but_four.Click += new System.EventHandler(this.But_Click);
            // 
            // but_dot
            // 
            this.but_dot.BackColor = System.Drawing.Color.Transparent;
            this.but_dot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_dot.Font = new System.Drawing.Font("Tempus Sans ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_dot.ForeColor = System.Drawing.Color.Black;
            this.but_dot.Location = new System.Drawing.Point(171, 285);
            this.but_dot.Name = "but_dot";
            this.but_dot.Size = new System.Drawing.Size(75, 61);
            this.but_dot.TabIndex = 0;
            this.but_dot.Text = ".";
            this.but_dot.UseVisualStyleBackColor = false;
            this.but_dot.Click += new System.EventHandler(this.But_Click);
            // 
            // but_one
            // 
            this.but_one.BackColor = System.Drawing.Color.Transparent;
            this.but_one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_one.Font = new System.Drawing.Font("Tempus Sans ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_one.ForeColor = System.Drawing.Color.Black;
            this.but_one.Location = new System.Drawing.Point(9, 218);
            this.but_one.Name = "but_one";
            this.but_one.Size = new System.Drawing.Size(75, 61);
            this.but_one.TabIndex = 0;
            this.but_one.Text = "1";
            this.but_one.UseVisualStyleBackColor = false;
            this.but_one.Click += new System.EventHandler(this.But_Click);
            // 
            // but_zero
            // 
            this.but_zero.BackColor = System.Drawing.Color.Transparent;
            this.but_zero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_zero.Font = new System.Drawing.Font("Tempus Sans ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_zero.ForeColor = System.Drawing.Color.Black;
            this.but_zero.Location = new System.Drawing.Point(90, 285);
            this.but_zero.Name = "but_zero";
            this.but_zero.Size = new System.Drawing.Size(75, 61);
            this.but_zero.TabIndex = 0;
            this.but_zero.Text = "0\r\n";
            this.but_zero.UseVisualStyleBackColor = false;
            this.but_zero.Click += new System.EventHandler(this.But_Click);
            // 
            // but_negative
            // 
            this.but_negative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_negative.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_negative.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.but_negative.Location = new System.Drawing.Point(9, 285);
            this.but_negative.Name = "but_negative";
            this.but_negative.Size = new System.Drawing.Size(75, 61);
            this.but_negative.TabIndex = 0;
            this.but_negative.Text = "+/-";
            this.but_negative.UseVisualStyleBackColor = true;
            this.but_negative.Click += new System.EventHandler(this.But_negative_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lab_2);
            this.panel3.Controls.Add(this.lab_1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(341, 181);
            this.panel3.TabIndex = 2;
            // 
            // lab_2
            // 
            this.lab_2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lab_2.Font = new System.Drawing.Font("Tempus Sans ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_2.ForeColor = System.Drawing.Color.Black;
            this.lab_2.Location = new System.Drawing.Point(0, 76);
            this.lab_2.Name = "lab_2";
            this.lab_2.Size = new System.Drawing.Size(341, 45);
            this.lab_2.TabIndex = 3;
            // 
            // lab_1
            // 
            this.lab_1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lab_1.Font = new System.Drawing.Font("Tempus Sans ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_1.ForeColor = System.Drawing.Color.Black;
            this.lab_1.Location = new System.Drawing.Point(0, 121);
            this.lab_1.Name = "lab_1";
            this.lab_1.Size = new System.Drawing.Size(341, 60);
            this.lab_1.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(341, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button but_close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button but_multiply;
        private System.Windows.Forms.Button but_mynus;
        private System.Windows.Forms.Button but_sum;
        private System.Windows.Forms.Button but_equal;
        private System.Windows.Forms.Button but_nine;
        private System.Windows.Forms.Button but_eight;
        private System.Windows.Forms.Button but_six;
        private System.Windows.Forms.Button but_five;
        private System.Windows.Forms.Button but_three;
        private System.Windows.Forms.Button but_seven;
        private System.Windows.Forms.Button but_two;
        private System.Windows.Forms.Button but_four;
        private System.Windows.Forms.Button but_dot;
        private System.Windows.Forms.Button but_one;
        private System.Windows.Forms.Button but_zero;
        private System.Windows.Forms.Button but_negative;
        private System.Windows.Forms.Button but_divide;
        private System.Windows.Forms.Button but_mod;
        private System.Windows.Forms.Button but_CE;
        private System.Windows.Forms.Button but_C;
        private System.Windows.Forms.Label lab_title;
        private System.Windows.Forms.Label lab_1;
        private System.Windows.Forms.Label lab_2;
    }
}

