namespace Sem3_2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cleatButton = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.linebutton = new System.Windows.Forms.Button();
            this.rectanglebutton = new System.Windows.Forms.Button();
            this.standartButton = new System.Windows.Forms.Button();
            this.partialButton = new System.Windows.Forms.Button();
            this.Clipbutton = new System.Windows.Forms.Button();
            this.randombutton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cleatButton,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cleatButton
            // 
            this.cleatButton.Name = "cleatButton";
            this.cleatButton.Size = new System.Drawing.Size(123, 26);
            this.cleatButton.Text = "очистить поле";
            this.cleatButton.Click += new System.EventHandler(this.cleatButton_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.оПрограммеToolStripMenuItem.Text = "о программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 422);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 416);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.linebutton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rectanglebutton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.standartButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.partialButton, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.Clipbutton, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.randombutton, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(563, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(234, 416);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // linebutton
            // 
            this.linebutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linebutton.Location = new System.Drawing.Point(3, 3);
            this.linebutton.Name = "linebutton";
            this.linebutton.Size = new System.Drawing.Size(228, 63);
            this.linebutton.TabIndex = 0;
            this.linebutton.Text = "линия";
            this.linebutton.UseVisualStyleBackColor = true;
            this.linebutton.Click += new System.EventHandler(this.linebutton_Click);
            // 
            // rectanglebutton
            // 
            this.rectanglebutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglebutton.Location = new System.Drawing.Point(3, 72);
            this.rectanglebutton.Name = "rectanglebutton";
            this.rectanglebutton.Size = new System.Drawing.Size(228, 63);
            this.rectanglebutton.TabIndex = 1;
            this.rectanglebutton.Text = "поле";
            this.rectanglebutton.UseVisualStyleBackColor = true;
            this.rectanglebutton.Click += new System.EventHandler(this.rectanglebutton_Click);
            // 
            // standartButton
            // 
            this.standartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.standartButton.Location = new System.Drawing.Point(3, 141);
            this.standartButton.Name = "standartButton";
            this.standartButton.Size = new System.Drawing.Size(228, 63);
            this.standartButton.TabIndex = 2;
            this.standartButton.Text = "Стандартно";
            this.standartButton.UseVisualStyleBackColor = true;
            this.standartButton.Click += new System.EventHandler(this.standartButton_Click);
            // 
            // partialButton
            // 
            this.partialButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partialButton.Location = new System.Drawing.Point(3, 210);
            this.partialButton.Name = "partialButton";
            this.partialButton.Size = new System.Drawing.Size(228, 63);
            this.partialButton.TabIndex = 3;
            this.partialButton.Text = "Частично";
            this.partialButton.UseVisualStyleBackColor = true;
            this.partialButton.Click += new System.EventHandler(this.partialButton_Click);
            // 
            // Clipbutton
            // 
            this.Clipbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clipbutton.Location = new System.Drawing.Point(3, 279);
            this.Clipbutton.Name = "Clipbutton";
            this.Clipbutton.Size = new System.Drawing.Size(228, 63);
            this.Clipbutton.TabIndex = 4;
            this.Clipbutton.Text = "Обрезать";
            this.Clipbutton.UseVisualStyleBackColor = true;
            this.Clipbutton.Click += new System.EventHandler(this.Clipbutton_Click);
            // 
            // randombutton
            // 
            this.randombutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.randombutton.Location = new System.Drawing.Point(3, 348);
            this.randombutton.Name = "randombutton";
            this.randombutton.Size = new System.Drawing.Size(228, 65);
            this.randombutton.TabIndex = 5;
            this.randombutton.Text = "рандом";
            this.randombutton.UseVisualStyleBackColor = true;
            this.randombutton.Click += new System.EventHandler(this.randombutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Seminar 3 Бурашников Роман БПИ175 отсечения";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cleatButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button linebutton;
        private System.Windows.Forms.Button rectanglebutton;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button standartButton;
        private System.Windows.Forms.Button partialButton;
        private System.Windows.Forms.Button Clipbutton;
        private System.Windows.Forms.Button randombutton;
    }
}

