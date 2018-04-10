namespace last_paint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pencil = new System.Windows.Forms.Button();
            this.Rectangle = new System.Windows.Forms.Button();
            this.Eraser = new System.Windows.Forms.Button();
            this.Fill = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.White = new System.Windows.Forms.Button();
            this.Black = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.Blue = new System.Windows.Forms.Button();
            this.Green = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.Purple = new System.Windows.Forms.Button();
            this.Orange = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(968, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Pencil
            // 
            this.Pencil.Image = ((System.Drawing.Image)(resources.GetObject("Pencil.Image")));
            this.Pencil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Pencil.Location = new System.Drawing.Point(12, 12);
            this.Pencil.Name = "Pencil";
            this.Pencil.Size = new System.Drawing.Size(57, 51);
            this.Pencil.TabIndex = 1;
            this.Pencil.UseVisualStyleBackColor = true;
            this.Pencil.Click += new System.EventHandler(this.tool_click);
            // 
            // Rectangle
            // 
            this.Rectangle.Image = ((System.Drawing.Image)(resources.GetObject("Rectangle.Image")));
            this.Rectangle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Rectangle.Location = new System.Drawing.Point(75, 12);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(57, 51);
            this.Rectangle.TabIndex = 2;
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.tool_click);
            // 
            // Eraser
            // 
            this.Eraser.Image = ((System.Drawing.Image)(resources.GetObject("Eraser.Image")));
            this.Eraser.Location = new System.Drawing.Point(264, 12);
            this.Eraser.Name = "Eraser";
            this.Eraser.Size = new System.Drawing.Size(57, 51);
            this.Eraser.TabIndex = 3;
            this.Eraser.UseVisualStyleBackColor = true;
            this.Eraser.Click += new System.EventHandler(this.tool_click);
            // 
            // Fill
            // 
            this.Fill.Image = ((System.Drawing.Image)(resources.GetObject("Fill.Image")));
            this.Fill.Location = new System.Drawing.Point(201, 12);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(57, 51);
            this.Fill.TabIndex = 4;
            this.Fill.UseVisualStyleBackColor = true;
            this.Fill.Click += new System.EventHandler(this.tool_click);
            // 
            // Circle
            // 
            this.Circle.Image = ((System.Drawing.Image)(resources.GetObject("Circle.Image")));
            this.Circle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Circle.Location = new System.Drawing.Point(138, 12);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(57, 51);
            this.Circle.TabIndex = 5;
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.tool_click);
            // 
            // White
            // 
            this.White.BackColor = System.Drawing.Color.White;
            this.White.Location = new System.Drawing.Point(385, 12);
            this.White.Name = "White";
            this.White.Size = new System.Drawing.Size(26, 26);
            this.White.TabIndex = 6;
            this.White.UseVisualStyleBackColor = false;
            this.White.Click += new System.EventHandler(this.clolor_click);
            // 
            // Black
            // 
            this.Black.BackColor = System.Drawing.Color.Black;
            this.Black.Location = new System.Drawing.Point(385, 44);
            this.Black.Name = "Black";
            this.Black.Size = new System.Drawing.Size(26, 26);
            this.Black.TabIndex = 7;
            this.Black.UseVisualStyleBackColor = false;
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(417, 12);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(26, 26);
            this.Red.TabIndex = 8;
            this.Red.UseVisualStyleBackColor = false;
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.Color.Blue;
            this.Blue.Location = new System.Drawing.Point(417, 44);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(26, 26);
            this.Blue.TabIndex = 9;
            this.Blue.UseVisualStyleBackColor = false;
            // 
            // Green
            // 
            this.Green.BackColor = System.Drawing.Color.Green;
            this.Green.Location = new System.Drawing.Point(449, 12);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(26, 26);
            this.Green.TabIndex = 10;
            this.Green.UseVisualStyleBackColor = false;
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.Location = new System.Drawing.Point(449, 44);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(26, 26);
            this.Yellow.TabIndex = 11;
            this.Yellow.UseVisualStyleBackColor = false;
            // 
            // Purple
            // 
            this.Purple.BackColor = System.Drawing.Color.Purple;
            this.Purple.Location = new System.Drawing.Point(481, 44);
            this.Purple.Name = "Purple";
            this.Purple.Size = new System.Drawing.Size(26, 26);
            this.Purple.TabIndex = 12;
            this.Purple.UseVisualStyleBackColor = false;
            // 
            // Orange
            // 
            this.Orange.BackColor = System.Drawing.Color.Orange;
            this.Orange.Location = new System.Drawing.Point(481, 12);
            this.Orange.Name = "Orange";
            this.Orange.Size = new System.Drawing.Size(26, 26);
            this.Orange.TabIndex = 13;
            this.Orange.UseVisualStyleBackColor = false;
            // 
            // trackBar1
            // 
            this.trackBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.trackBar1.BackColor = System.Drawing.Color.Peru;
            this.trackBar1.Location = new System.Drawing.Point(543, 18);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(157, 45);
            this.trackBar1.TabIndex = 14;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 521);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Orange);
            this.Controls.Add(this.Purple);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Black);
            this.Controls.Add(this.White);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.Fill);
            this.Controls.Add(this.Eraser);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.Pencil);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Pencil;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.Button Eraser;
        private System.Windows.Forms.Button Fill;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button White;
        private System.Windows.Forms.Button Black;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Blue;
        private System.Windows.Forms.Button Green;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Button Purple;
        private System.Windows.Forms.Button Orange;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

