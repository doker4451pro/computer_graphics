namespace Sem2
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
            this.окружностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.элипсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьПолеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьЦветToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.черныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зеленыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.какПользоватьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Draw = new System.Windows.Forms.Button();
            this.RandomButton = new System.Windows.Forms.Button();
            this.buttonUnder = new System.Windows.Forms.Button();
            this.buttonFile = new System.Windows.Forms.Button();
            this.textBoxX0 = new System.Windows.Forms.TextBox();
            this.textBoxY0 = new System.Windows.Forms.TextBox();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
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
            this.окружностьToolStripMenuItem,
            this.элипсToolStripMenuItem,
            this.очиститьПолеToolStripMenuItem,
            this.сменитьЦветToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // окружностьToolStripMenuItem
            // 
            this.окружностьToolStripMenuItem.Name = "окружностьToolStripMenuItem";
            this.окружностьToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.окружностьToolStripMenuItem.Text = "окружность";
            this.окружностьToolStripMenuItem.Click += new System.EventHandler(this.окружностьToolStripMenuItem_Click);
            // 
            // элипсToolStripMenuItem
            // 
            this.элипсToolStripMenuItem.Name = "элипсToolStripMenuItem";
            this.элипсToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.элипсToolStripMenuItem.Text = "элипс";
            this.элипсToolStripMenuItem.Click += new System.EventHandler(this.элипсToolStripMenuItem_Click);
            // 
            // очиститьПолеToolStripMenuItem
            // 
            this.очиститьПолеToolStripMenuItem.Name = "очиститьПолеToolStripMenuItem";
            this.очиститьПолеToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.очиститьПолеToolStripMenuItem.Text = "очистить поле";
            this.очиститьПолеToolStripMenuItem.Click += new System.EventHandler(this.очиститьПолеToolStripMenuItem_Click);
            // 
            // сменитьЦветToolStripMenuItem
            // 
            this.сменитьЦветToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.черныйToolStripMenuItem,
            this.синийToolStripMenuItem,
            this.зеленыйToolStripMenuItem});
            this.сменитьЦветToolStripMenuItem.Name = "сменитьЦветToolStripMenuItem";
            this.сменитьЦветToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.сменитьЦветToolStripMenuItem.Text = "сменить цвет";
            // 
            // черныйToolStripMenuItem
            // 
            this.черныйToolStripMenuItem.Name = "черныйToolStripMenuItem";
            this.черныйToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.черныйToolStripMenuItem.Text = "черный";
            this.черныйToolStripMenuItem.Click += new System.EventHandler(this.черныйToolStripMenuItem_Click);
            // 
            // синийToolStripMenuItem
            // 
            this.синийToolStripMenuItem.Name = "синийToolStripMenuItem";
            this.синийToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.синийToolStripMenuItem.Text = "синий";
            this.синийToolStripMenuItem.Click += new System.EventHandler(this.синийToolStripMenuItem_Click);
            // 
            // зеленыйToolStripMenuItem
            // 
            this.зеленыйToolStripMenuItem.Name = "зеленыйToolStripMenuItem";
            this.зеленыйToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.зеленыйToolStripMenuItem.Text = "зеленый";
            this.зеленыйToolStripMenuItem.Click += new System.EventHandler(this.зеленыйToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.какПользоватьсяToolStripMenuItem});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.оПрограммеToolStripMenuItem.Text = "о программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // какПользоватьсяToolStripMenuItem
            // 
            this.какПользоватьсяToolStripMenuItem.Name = "какПользоватьсяToolStripMenuItem";
            this.какПользоватьсяToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.какПользоватьсяToolStripMenuItem.Text = "как пользоваться";
            this.какПользоватьсяToolStripMenuItem.Click += new System.EventHandler(this.какПользоватьсяToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
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
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.Draw, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.RandomButton, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonUnder, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.buttonFile, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.textBoxX0, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxY0, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxX1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxY1, 1, 3);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "X0=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 69);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y0=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 138);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(111, 69);
            this.label3.TabIndex = 2;
            this.label3.Text = "A=";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 69);
            this.label4.TabIndex = 3;
            this.label4.Text = "B=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Draw
            // 
            this.Draw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Draw.Location = new System.Drawing.Point(3, 279);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(111, 63);
            this.Draw.TabIndex = 4;
            this.Draw.Text = "Нарисовать";
            this.Draw.UseVisualStyleBackColor = true;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // RandomButton
            // 
            this.RandomButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RandomButton.Location = new System.Drawing.Point(120, 279);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(111, 63);
            this.RandomButton.TabIndex = 5;
            this.RandomButton.Text = "Нарисовать рандомом";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // buttonUnder
            // 
            this.buttonUnder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUnder.Location = new System.Drawing.Point(3, 348);
            this.buttonUnder.Name = "buttonUnder";
            this.buttonUnder.Size = new System.Drawing.Size(111, 65);
            this.buttonUnder.TabIndex = 6;
            this.buttonUnder.Text = "Нарисовать рядом";
            this.buttonUnder.UseVisualStyleBackColor = true;
            this.buttonUnder.Click += new System.EventHandler(this.buttonUnder_Click);
            // 
            // buttonFile
            // 
            this.buttonFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFile.Location = new System.Drawing.Point(120, 348);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(111, 65);
            this.buttonFile.TabIndex = 7;
            this.buttonFile.Text = "Читать из файла";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Visible = false;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // textBoxX0
            // 
            this.textBoxX0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxX0.Location = new System.Drawing.Point(120, 44);
            this.textBoxX0.Name = "textBoxX0";
            this.textBoxX0.Size = new System.Drawing.Size(100, 22);
            this.textBoxX0.TabIndex = 8;
            // 
            // textBoxY0
            // 
            this.textBoxY0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxY0.Location = new System.Drawing.Point(120, 113);
            this.textBoxY0.Name = "textBoxY0";
            this.textBoxY0.Size = new System.Drawing.Size(100, 22);
            this.textBoxY0.TabIndex = 9;
            // 
            // textBoxX1
            // 
            this.textBoxX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxX1.Location = new System.Drawing.Point(120, 182);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(100, 22);
            this.textBoxX1.TabIndex = 10;
            // 
            // textBoxY1
            // 
            this.textBoxY1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxY1.Location = new System.Drawing.Point(120, 251);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(100, 22);
            this.textBoxY1.TabIndex = 11;
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
            this.Text = "Seminar2 Построение окружности и эллипса Бурашников Роман БПИ175";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem окружностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem элипсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьПолеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьЦветToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem черныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зеленыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.Button buttonUnder;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.TextBox textBoxX0;
        private System.Windows.Forms.TextBox textBoxY0;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.ToolStripMenuItem какПользоватьсяToolStripMenuItem;
    }
}

