using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Media;
namespace Exam
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
            this.ClientSize = new System.Drawing.Size(400, 550);
            this.Text = "Music player";
            this.BackColor = Color.Red;

            Gif_pbox.BackgroundImage = Image.FromFile("gif.gif");
            Gif_pbox.Size = new Size(180, 179);
            Gif_pbox.Location = new Point(75, 0);
            Gif_pbox.SizeMode = PictureBoxSizeMode.Zoom;
            this.Controls.Add(Gif_pbox);

            Left_btn.Text = "<";
            Left_btn.Font = new Font("Arial", 20);
            Left_btn.Location = new Point(0, 230);
            Left_btn.Size = new Size(50, 50);
            Left_btn.Click += Left_btn_Click;
            this.Controls.Add(Left_btn);

            Play_btn.Font = new Font("Arial", 20);
            Play_btn.Size = new Size(100, 60);
            Play_btn.Location = new Point(110, 220);
            Play_btn.Text = "Play";
            Play_btn.Click += Play_btn_Click;
            this.Controls.Add(Play_btn);

            Right_btn.Text = ">";
            Right_btn.Font = new Font("Arial", 20);
            Right_btn.Location = new Point(260, 230);
            Right_btn.Size = new Size(50, 50);
            Right_btn.Click += Right_btn_Click;
            this.Controls.Add(Right_btn);

            Add_btn.Text = "+";
            Add_btn.Font = new Font("Arial", 20);
            Add_btn.Location = new Point(340, 350);
            Add_btn.Size = new Size(50, 50);
            Add_btn.Click += Add_btn_Click;
            this.Controls.Add(Add_btn);

            Delete_btn.Text = "-";
            Delete_btn.Font = new Font("Arial", 20);
            Delete_btn.Location = new Point(340, 400);
            Delete_btn.Size = new Size(50, 50);
            this.Controls.Add(Delete_btn);

            Songs_lb.Location = new Point(0, 330);
            Songs_lb.Size = new Size(300, 200);
            this.Controls.Add(Songs_lb);
        }

        private void Play_btn_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(music[num]);
            simpleSound.Play();
        }

        private void Left_btn_Click(object sender, EventArgs e)
        {
            if (num > 0)
            {
                num--;
                SetMusic(num);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void Right_btn_Click(object sender, EventArgs e)
        {
            if (num < PictureCount)
            {
                num++;
                SetMusic(num);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        void SetMusic(int indx = 0)
        {
            //Songs_lb.Items.Fromfile(music[num]);
        }
        int PictureCount = 0;
        int num = 0;
        private void Add_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "*.**|*.*|*.mp3|*.mp3|*.wav|*.wav";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    PictureCount++;
                    num++;
                    music.Add(dialog.FileName);
                Songs_lb.Items.Add(dialog.FileName);
                }
            }
        }


        List<string> music = new List<string>();

        Button Left_btn = new Button();
        Button Right_btn = new Button();
        Button Play_btn = new Button();

        Button Add_btn = new Button();
        Button Delete_btn = new Button();

        ListBox Songs_lb = new ListBox();

        PictureBox Gif_pbox = new PictureBox();
    }

        #endregion
    }
   

