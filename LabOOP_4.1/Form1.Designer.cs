﻿namespace LabOOP_4._1
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
            this.panelPaint = new System.Windows.Forms.Panel();
            this.buttonPaint = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelCoord = new System.Windows.Forms.Label();
            this.labelCoordX = new System.Windows.Forms.Label();
            this.labelCoordY = new System.Windows.Forms.Label();
            this.buttonClearStg = new System.Windows.Forms.Button();
            this.buttonDeleteActiveStg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelPaint
            // 
            this.panelPaint.BackColor = System.Drawing.Color.White;
            this.panelPaint.Location = new System.Drawing.Point(12, 12);
            this.panelPaint.Name = "panelPaint";
            this.panelPaint.Size = new System.Drawing.Size(776, 359);
            this.panelPaint.TabIndex = 0;
            this.panelPaint.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelPaint_MouseClick);
            this.panelPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPaint_MouseMove);
            // 
            // buttonPaint
            // 
            this.buttonPaint.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonPaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPaint.Location = new System.Drawing.Point(12, 378);
            this.buttonPaint.Name = "buttonPaint";
            this.buttonPaint.Size = new System.Drawing.Size(163, 85);
            this.buttonPaint.TabIndex = 1;
            this.buttonPaint.Text = "Отрисовать объекты хранилища";
            this.buttonPaint.UseVisualStyleBackColor = false;
            this.buttonPaint.Click += new System.EventHandler(this.buttonPaint_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(640, 378);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(148, 85);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Очистить полотно";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelCoord
            // 
            this.labelCoord.AutoSize = true;
            this.labelCoord.Location = new System.Drawing.Point(338, 378);
            this.labelCoord.Name = "labelCoord";
            this.labelCoord.Size = new System.Drawing.Size(136, 17);
            this.labelCoord.TabIndex = 3;
            this.labelCoord.Text = "Координаты мыши:";
            this.labelCoord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelCoordX
            // 
            this.labelCoordX.AutoSize = true;
            this.labelCoordX.Location = new System.Drawing.Point(387, 400);
            this.labelCoordX.Name = "labelCoordX";
            this.labelCoordX.Size = new System.Drawing.Size(16, 17);
            this.labelCoordX.TabIndex = 4;
            this.labelCoordX.Text = "0";
            this.labelCoordX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCoordY
            // 
            this.labelCoordY.AutoSize = true;
            this.labelCoordY.Location = new System.Drawing.Point(387, 417);
            this.labelCoordY.Name = "labelCoordY";
            this.labelCoordY.Size = new System.Drawing.Size(16, 17);
            this.labelCoordY.TabIndex = 5;
            this.labelCoordY.Text = "0";
            this.labelCoordY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClearStg
            // 
            this.buttonClearStg.Location = new System.Drawing.Point(183, 378);
            this.buttonClearStg.Name = "buttonClearStg";
            this.buttonClearStg.Size = new System.Drawing.Size(149, 85);
            this.buttonClearStg.TabIndex = 6;
            this.buttonClearStg.Text = "Удалить объекты из хранилища";
            this.buttonClearStg.UseVisualStyleBackColor = true;
            this.buttonClearStg.Click += new System.EventHandler(this.buttonClearStg_Click);
            // 
            // buttonDeleteActiveStg
            // 
            this.buttonDeleteActiveStg.Location = new System.Drawing.Point(481, 378);
            this.buttonDeleteActiveStg.Name = "buttonDeleteActiveStg";
            this.buttonDeleteActiveStg.Size = new System.Drawing.Size(153, 85);
            this.buttonDeleteActiveStg.TabIndex = 7;
            this.buttonDeleteActiveStg.Text = "Удалить выделенные элементы из хранилища";
            this.buttonDeleteActiveStg.UseVisualStyleBackColor = true;
            this.buttonDeleteActiveStg.Click += new System.EventHandler(this.buttonDeleteActiveStg_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.buttonDeleteActiveStg);
            this.Controls.Add(this.buttonClearStg);
            this.Controls.Add(this.labelCoordY);
            this.Controls.Add(this.labelCoordX);
            this.Controls.Add(this.labelCoord);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonPaint);
            this.Controls.Add(this.panelPaint);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelPaint;
        private System.Windows.Forms.Button buttonPaint;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelCoord;
        private System.Windows.Forms.Label labelCoordX;
        private System.Windows.Forms.Label labelCoordY;
        private System.Windows.Forms.Button buttonClearStg;
        private System.Windows.Forms.Button buttonDeleteActiveStg;
    }
}

