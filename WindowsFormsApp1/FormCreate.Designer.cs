﻿namespace WindowsFormsApp1
{
    partial class CreateDoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDoc));
            this.label_period = new System.Windows.Forms.Label();
            this.dateTimePicker_one = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_two = new System.Windows.Forms.DateTimePicker();
            this.checkBox_period_all = new System.Windows.Forms.CheckBox();
            this.textBox_file_name = new System.Windows.Forms.TextBox();
            this.label_enter_file_name = new System.Windows.Forms.Label();
            this.button_create = new System.Windows.Forms.Button();
            this.label_error = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_period
            // 
            this.label_period.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_period.AutoSize = true;
            this.label_period.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_period.Location = new System.Drawing.Point(45, 56);
            this.label_period.Name = "label_period";
            this.label_period.Size = new System.Drawing.Size(79, 24);
            this.label_period.TabIndex = 0;
            this.label_period.Text = "Период";
            this.label_period.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker_one
            // 
            this.dateTimePicker_one.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_one.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_one.Location = new System.Drawing.Point(154, 60);
            this.dateTimePicker_one.Name = "dateTimePicker_one";
            this.dateTimePicker_one.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_one.TabIndex = 1;
            // 
            // dateTimePicker_two
            // 
            this.dateTimePicker_two.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_two.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker_two.Location = new System.Drawing.Point(399, 59);
            this.dateTimePicker_two.Name = "dateTimePicker_two";
            this.dateTimePicker_two.Size = new System.Drawing.Size(174, 20);
            this.dateTimePicker_two.TabIndex = 2;
            // 
            // checkBox_period_all
            // 
            this.checkBox_period_all.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox_period_all.AutoSize = true;
            this.checkBox_period_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_period_all.Location = new System.Drawing.Point(49, 165);
            this.checkBox_period_all.Name = "checkBox_period_all";
            this.checkBox_period_all.Size = new System.Drawing.Size(470, 28);
            this.checkBox_period_all.TabIndex = 3;
            this.checkBox_period_all.Text = "Показать все выполненные задачи за все время";
            this.checkBox_period_all.UseVisualStyleBackColor = true;
            // 
            // textBox_file_name
            // 
            this.textBox_file_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_file_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_file_name.Location = new System.Drawing.Point(309, 241);
            this.textBox_file_name.Name = "textBox_file_name";
            this.textBox_file_name.Size = new System.Drawing.Size(210, 29);
            this.textBox_file_name.TabIndex = 4;
            // 
            // label_enter_file_name
            // 
            this.label_enter_file_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_enter_file_name.AutoSize = true;
            this.label_enter_file_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_enter_file_name.Location = new System.Drawing.Point(46, 246);
            this.label_enter_file_name.Name = "label_enter_file_name";
            this.label_enter_file_name.Size = new System.Drawing.Size(238, 24);
            this.label_enter_file_name.TabIndex = 5;
            this.label_enter_file_name.Text = "Введите название файла";
            // 
            // button_create
            // 
            this.button_create.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_create.Location = new System.Drawing.Point(241, 319);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(168, 41);
            this.button_create.TabIndex = 6;
            this.button_create.Text = "Создать!";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(215, 286);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(45, 16);
            this.label_error.TabIndex = 7;
            this.label_error.Text = "label1";
            this.label_error.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Показать в папке";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Помощь";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.label_enter_file_name);
            this.Controls.Add(this.textBox_file_name);
            this.Controls.Add(this.checkBox_period_all);
            this.Controls.Add(this.dateTimePicker_two);
            this.Controls.Add(this.dateTimePicker_one);
            this.Controls.Add(this.label_period);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateDoc";
            this.Text = "Создание отчета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_period;
        private System.Windows.Forms.DateTimePicker dateTimePicker_one;
        private System.Windows.Forms.DateTimePicker dateTimePicker_two;
        private System.Windows.Forms.CheckBox checkBox_period_all;
        private System.Windows.Forms.TextBox textBox_file_name;
        private System.Windows.Forms.Label label_enter_file_name;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}