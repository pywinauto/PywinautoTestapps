using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Form1";
        }
        private void InitializeComponent(uint mode, uint itemsCount, uint colCount = 1, int seed = 0, int length = 8)
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Form " + itemsCount.ToString();
            uint rowCount = itemsCount / colCount;
            if (itemsCount % colCount != 0)
            {
                rowCount++;
            }

            Random r = new Random(seed);
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            for (uint i = 0; i < itemsCount; i++)
            {
                StringBuilder text = new StringBuilder(length);
                for (int i2 = 0; i2 < length; i2++)
                {
                    text.Append(characters[r.Next(characters.Length)]);
                }
                var label = new Label();
                label.Text = text.ToString();

                text = new StringBuilder(length);
                for (int i2 = 0; i2 < length; i2++)
                {
                    text.Append(characters[r.Next(characters.Length)]);
                }

                Control obj = new Control();

                switch (mode)
                {
                    case 1:
                        var btn = new Button();
                        btn.Text = text.ToString();
                        obj = btn;
                        break;
                    case 2:
                        var txt = new TextBox();
                        txt.Text = text.ToString();
                        obj = txt;
                        break;
                    case 3:
                        var combo = new ComboBox();
                        combo.Text = text.ToString();
                        text = new StringBuilder(length);
                        for (int i2 = 0; i2 < length; i2++)
                        {
                            text.Append(characters[r.Next(characters.Length)]);
                        }
                        combo.Items.Add(text.ToString());
                        text = new StringBuilder(length);
                        for (int i2 = 0; i2 < length; i2++)
                        {
                            text.Append(characters[r.Next(characters.Length)]);
                        }
                        combo.Items.Add(text.ToString());
                        text = new StringBuilder(length);
                        for (int i2 = 0; i2 < length; i2++)
                        {
                            text.Append(characters[r.Next(characters.Length)]);
                        }
                        combo.Items.Add(text.ToString());
                        obj = combo;
                        break;
                }


                int height = label.Height;
                if (height < obj.Height)
                {
                    height = obj.Height;
                }
                int width = label.Width + obj.Width;

                label.Top = (int)(i % rowCount) * height;
                label.Left = (int)(i / rowCount) * width;
                obj.Top = label.Top;
                obj.Left = label.Right;
                this.Controls.Add(label);
                this.Controls.Add(obj);
            }

            this.AutoScroll = true;
        }
        #endregion
    }
}

