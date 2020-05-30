using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Simple Scalable Benchmark";
        }
        private void InitializeComponent(uint mode, uint itemsCount, uint colCount = 1, int seed = 0, int length = 8)
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Simple Scalable Benchmark " + itemsCount.ToString();
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

