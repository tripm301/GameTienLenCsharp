/*
 * Created by SharpDevelop.
 * User: chepchip
 * Date: 4/18/2017
 * Time: 1:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using TINH_TONG_2_SO___ANTT;

namespace CLIENT
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBoLuoc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.picPlayer1 = new System.Windows.Forms.PictureBox();
            this.picPlayer2 = new System.Windows.Forms.PictureBox();
            this.picPlayer3 = new System.Windows.Forms.PictureBox();
            this.picPlayer4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "127.0.0.1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 52);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "13000";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(217, 52);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sẵn sàng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(23, 92);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(186, 119);
            this.textBox5.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(403, 495);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(438, 495);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 193);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(483, 495);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(161, 193);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(530, 495);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(161, 193);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(570, 495);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(161, 193);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(620, 495);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(161, 193);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(670, 495);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(161, 193);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(720, 495);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(161, 193);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 19;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(766, 495);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(161, 193);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 20;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(813, 495);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(161, 193);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 21;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(858, 495);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(161, 193);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 22;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(905, 495);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(161, 193);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 23;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox12_Click);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Location = new System.Drawing.Point(958, 495);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(161, 193);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 24;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            // 
            // pictureBox14
            // 
            this.pictureBox14.Location = new System.Drawing.Point(958, 461);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(161, 193);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 38;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Click += new System.EventHandler(this.pictureBox14_Click);
            // 
            // pictureBox15
            // 
            this.pictureBox15.Location = new System.Drawing.Point(905, 461);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(161, 193);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 37;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Click += new System.EventHandler(this.pictureBox15_Click);
            // 
            // pictureBox16
            // 
            this.pictureBox16.Location = new System.Drawing.Point(858, 461);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(161, 193);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 36;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Click += new System.EventHandler(this.pictureBox16_Click);
            // 
            // pictureBox17
            // 
            this.pictureBox17.Location = new System.Drawing.Point(813, 461);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(161, 193);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 35;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Click += new System.EventHandler(this.pictureBox17_Click);
            // 
            // pictureBox18
            // 
            this.pictureBox18.Location = new System.Drawing.Point(766, 461);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(161, 193);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 34;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Click += new System.EventHandler(this.pictureBox18_Click);
            // 
            // pictureBox19
            // 
            this.pictureBox19.Location = new System.Drawing.Point(720, 461);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(161, 193);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox19.TabIndex = 33;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Click += new System.EventHandler(this.pictureBox19_Click);
            // 
            // pictureBox20
            // 
            this.pictureBox20.Location = new System.Drawing.Point(670, 461);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(161, 193);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 32;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Click += new System.EventHandler(this.pictureBox20_Click);
            // 
            // pictureBox21
            // 
            this.pictureBox21.Location = new System.Drawing.Point(620, 461);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(161, 193);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox21.TabIndex = 31;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Click += new System.EventHandler(this.pictureBox21_Click);
            // 
            // pictureBox22
            // 
            this.pictureBox22.Location = new System.Drawing.Point(570, 461);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(161, 193);
            this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox22.TabIndex = 30;
            this.pictureBox22.TabStop = false;
            this.pictureBox22.Click += new System.EventHandler(this.pictureBox22_Click);
            // 
            // pictureBox23
            // 
            this.pictureBox23.Location = new System.Drawing.Point(530, 461);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(161, 193);
            this.pictureBox23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox23.TabIndex = 29;
            this.pictureBox23.TabStop = false;
            this.pictureBox23.Click += new System.EventHandler(this.pictureBox23_Click);
            // 
            // pictureBox24
            // 
            this.pictureBox24.Location = new System.Drawing.Point(483, 461);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(161, 193);
            this.pictureBox24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox24.TabIndex = 28;
            this.pictureBox24.TabStop = false;
            this.pictureBox24.Click += new System.EventHandler(this.pictureBox24_Click);
            // 
            // pictureBox25
            // 
            this.pictureBox25.Location = new System.Drawing.Point(438, 461);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(161, 193);
            this.pictureBox25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox25.TabIndex = 27;
            this.pictureBox25.TabStop = false;
            this.pictureBox25.Click += new System.EventHandler(this.pictureBox25_Click);
            // 
            // pictureBox26
            // 
            this.pictureBox26.Location = new System.Drawing.Point(403, 461);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(161, 193);
            this.pictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox26.TabIndex = 26;
            this.pictureBox26.TabStop = false;
            this.pictureBox26.Click += new System.EventHandler(this.pictureBox26_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1164, 545);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 39;
            this.button4.Text = "Đánh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1164, 516);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Xếp bài";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBoLuoc
            // 
            this.btnBoLuoc.Location = new System.Drawing.Point(1164, 621);
            this.btnBoLuoc.Name = "btnBoLuoc";
            this.btnBoLuoc.Size = new System.Drawing.Size(75, 23);
            this.btnBoLuoc.TabIndex = 40;
            this.btnBoLuoc.Text = "Bỏ lược";
            this.btnBoLuoc.UseVisualStyleBackColor = true;
            this.btnBoLuoc.Click += new System.EventHandler(this.btnBoLuoc_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(26, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 408);
            this.panel1.TabIndex = 41;
            // 
            // pictureBox27
            // 
            this.pictureBox27.Location = new System.Drawing.Point(403, 128);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(161, 193);
            this.pictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox27.TabIndex = 42;
            this.pictureBox27.TabStop = false;
            // 
            // pictureBox28
            // 
            this.pictureBox28.Location = new System.Drawing.Point(438, 128);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(161, 193);
            this.pictureBox28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox28.TabIndex = 43;
            this.pictureBox28.TabStop = false;
            // 
            // pictureBox29
            // 
            this.pictureBox29.Location = new System.Drawing.Point(483, 128);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(161, 193);
            this.pictureBox29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox29.TabIndex = 44;
            this.pictureBox29.TabStop = false;
            // 
            // pictureBox30
            // 
            this.pictureBox30.Location = new System.Drawing.Point(530, 128);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(161, 193);
            this.pictureBox30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox30.TabIndex = 45;
            this.pictureBox30.TabStop = false;
            // 
            // pictureBox31
            // 
            this.pictureBox31.Location = new System.Drawing.Point(570, 128);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(161, 193);
            this.pictureBox31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox31.TabIndex = 46;
            this.pictureBox31.TabStop = false;
            // 
            // pictureBox32
            // 
            this.pictureBox32.Location = new System.Drawing.Point(620, 128);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(161, 193);
            this.pictureBox32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox32.TabIndex = 47;
            this.pictureBox32.TabStop = false;
            // 
            // pictureBox33
            // 
            this.pictureBox33.Location = new System.Drawing.Point(670, 128);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(161, 193);
            this.pictureBox33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox33.TabIndex = 48;
            this.pictureBox33.TabStop = false;
            // 
            // pictureBox34
            // 
            this.pictureBox34.Location = new System.Drawing.Point(720, 128);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(161, 193);
            this.pictureBox34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox34.TabIndex = 49;
            this.pictureBox34.TabStop = false;
            // 
            // pictureBox35
            // 
            this.pictureBox35.Location = new System.Drawing.Point(766, 128);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(161, 193);
            this.pictureBox35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox35.TabIndex = 50;
            this.pictureBox35.TabStop = false;
            // 
            // pictureBox36
            // 
            this.pictureBox36.Location = new System.Drawing.Point(813, 128);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(161, 193);
            this.pictureBox36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox36.TabIndex = 51;
            this.pictureBox36.TabStop = false;
            // 
            // pictureBox37
            // 
            this.pictureBox37.Location = new System.Drawing.Point(858, 128);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(161, 193);
            this.pictureBox37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox37.TabIndex = 52;
            this.pictureBox37.TabStop = false;
            // 
            // pictureBox38
            // 
            this.pictureBox38.Location = new System.Drawing.Point(905, 128);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(161, 193);
            this.pictureBox38.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox38.TabIndex = 53;
            this.pictureBox38.TabStop = false;
            // 
            // pictureBox39
            // 
            this.pictureBox39.Location = new System.Drawing.Point(958, 128);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(161, 193);
            this.pictureBox39.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox39.TabIndex = 54;
            this.pictureBox39.TabStop = false;
            // 
            // picPlayer1
            // 
            this.picPlayer1.Location = new System.Drawing.Point(747, 375);
            this.picPlayer1.Name = "picPlayer1";
            this.picPlayer1.Size = new System.Drawing.Size(64, 80);
            this.picPlayer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer1.TabIndex = 55;
            this.picPlayer1.TabStop = false;
            // 
            // picPlayer2
            // 
            this.picPlayer2.Location = new System.Drawing.Point(1175, 200);
            this.picPlayer2.Name = "picPlayer2";
            this.picPlayer2.Size = new System.Drawing.Size(64, 80);
            this.picPlayer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer2.TabIndex = 56;
            this.picPlayer2.TabStop = false;
            // 
            // picPlayer3
            // 
            this.picPlayer3.Location = new System.Drawing.Point(747, 22);
            this.picPlayer3.Name = "picPlayer3";
            this.picPlayer3.Size = new System.Drawing.Size(64, 80);
            this.picPlayer3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer3.TabIndex = 57;
            this.picPlayer3.TabStop = false;
            // 
            // picPlayer4
            // 
            this.picPlayer4.Location = new System.Drawing.Point(323, 200);
            this.picPlayer4.Name = "picPlayer4";
            this.picPlayer4.Size = new System.Drawing.Size(64, 80);
            this.picPlayer4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer4.TabIndex = 58;
            this.picPlayer4.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 717);
            this.Controls.Add(this.picPlayer4);
            this.Controls.Add(this.picPlayer3);
            this.Controls.Add(this.picPlayer2);
            this.Controls.Add(this.picPlayer1);
            this.Controls.Add(this.pictureBox39);
            this.Controls.Add(this.pictureBox38);
            this.Controls.Add(this.pictureBox37);
            this.Controls.Add(this.pictureBox36);
            this.Controls.Add(this.pictureBox35);
            this.Controls.Add(this.pictureBox34);
            this.Controls.Add(this.pictureBox33);
            this.Controls.Add(this.pictureBox32);
            this.Controls.Add(this.pictureBox31);
            this.Controls.Add(this.pictureBox30);
            this.Controls.Add(this.pictureBox29);
            this.Controls.Add(this.pictureBox28);
            this.Controls.Add(this.pictureBox27);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBoLuoc);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox22);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox23);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox24);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox25);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox26);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "CLIENT";
            this.Load += new System.EventHandler(this.MainFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
		void MainFormLoad(object sender, System.EventArgs e)
		{
			CheckForIllegalCrossThreadCalls = false;
            TurnOffCardTop();
            
        }
		
		private TCPModel tcp;
        private Card[] cards = new Card[13];
        private Card[] chooseCard = new Card[13];
        private Card[] cardPlay = new Card[13];
        private int chooseCardNumber = 0;
        private int soBaiConLai = 13;
        private string baiDanh = null;
        PictureBox[] arrPic = new PictureBox[4];
        private int ID;//
        private int soNguoiHienTai=0;
        void UpdatePic()
        {
            arrPic[0] = picPlayer1;
            arrPic[1] = picPlayer2;
            arrPic[2] = picPlayer3;
            arrPic[3] = picPlayer4;
        }
        void TurnOffCardTop()
        {
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            pictureBox21.Visible = false;
            pictureBox22.Visible = false;
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;
            pictureBox25.Visible = false;
            pictureBox26.Visible = false;
        }
        void TurnOnCardBot()
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
        }
        //hàm đóng forrm
        public void closeForm()
        {
            this.Dispose();
            this.Close();
        }
        void Button1Click(object sender, System.EventArgs e)
		{
			//Step 1: Ket noi toi server
			tcp = new TCPModel(textBox1.Text,int.Parse(textBox2.Text));
			int flag = tcp.ConnectToServer();
            tcp.SendData("JOIN");
			button1.Enabled = false;
            Thread t = new Thread(ReceiveData);
            t.Start();
		}
		
		void Button2Click(object sender, System.EventArgs e)
		{
			//step 2: Gui yeu cau server 
			string str = "START";
			int flag = tcp.SendData(str);
		}

        void ResetChooseCard()
        {
            chooseCard = new Card[13];
        }


        void ReceiveData()
        {
            while (true)
            {
                UpdatePic();
                string data = tcp.ReadData();
                textBox5.Text = data;
                string[] str = data.Split('_');
                //HEAD
                switch (str[0]) {
                    case "TABLE":
                        {
                            if (str[0] == "TABLE")
                            {
                                int soclient = int.Parse(str[1]);
                                ID = soclient;
                                if (soclient == 1)
                                {
                                    picPlayer1.Image = CLIENT.Properties.Resources.Me;
                                }
                                if (soclient == 2)
                                {
                                    picPlayer4.Image = CLIENT.Properties.Resources.Player1;
                                    picPlayer1.Image = CLIENT.Properties.Resources.Me;
                                }
                                if (soclient == 3)
                                {
                                    picPlayer3.Image = CLIENT.Properties.Resources.Player1;
                                    picPlayer4.Image = CLIENT.Properties.Resources.Player1;
                                    picPlayer1.Image = CLIENT.Properties.Resources.Me;
                                }
                                if (soclient == 4)
                                {
                                    picPlayer3.Image = CLIENT.Properties.Resources.Player1;
                                    picPlayer4.Image = CLIENT.Properties.Resources.Player1;
                                    picPlayer1.Image = CLIENT.Properties.Resources.Me;
                                    picPlayer2.Image = CLIENT.Properties.Resources.Player1;
                                }

                            }
                            break;
                        }
                    case "JOIN":
                        {

                            for (int i = 0; i < 4; i++)
                            {
                                if (IsNullOrEmpty(arrPic[i]))
                                {
                                    arrPic[i].Image = CLIENT.Properties.Resources.Player1;
                                    i = 5;
                                }
                            }
                            soNguoiHienTai = ID + 1;
                            break;

                        }
                    case "START":
                        {
                            NhanBai(data);

                            DrawSetCard();
                            break;
                        }
                        /*
                        if (str[0] == "TABLE")
                        {


                        }

                        else
                        {
                            NhanBai(data);
                            PostCardPlaying(data);
                            DrawSetCard();

                        }*/

                        /* else
                         {
                             NhanBai(data);

                             DrawSetCard();

                         }*/

                }
            }
        }
        public bool IsNullOrEmpty( PictureBox pb)
            {
                return pb == null || pb.Image == null;
            }

        public void PostCardPlaying(string data)
        {
            int i = 0;
            Card card = new Card();

            string[] arrListStr = data.Split('_');
            foreach (string item in arrListStr)
            {
                if (i == 13)
                {
                    break;
                }
                cardPlay[i] = card.input(item);
                i++;
            }

            pictureBox27.Image = DrawCard(cardPlay[0]);
            pictureBox28.Image = DrawCard(cardPlay[1]);
            pictureBox29.Image = DrawCard(cardPlay[2]);
            pictureBox30.Image = DrawCard(cardPlay[3]);
            pictureBox31.Image = DrawCard(cardPlay[4]);
            pictureBox32.Image = DrawCard(cardPlay[5]);
            pictureBox33.Image = DrawCard(cardPlay[6]);
            pictureBox34.Image = DrawCard(cardPlay[7]);
            pictureBox35.Image = DrawCard(cardPlay[8]);
            pictureBox36.Image = DrawCard(cardPlay[9]);
            pictureBox37.Image = DrawCard(cardPlay[10]);
            pictureBox38.Image = DrawCard(cardPlay[11]);
            pictureBox39.Image = DrawCard(cardPlay[12]);
        }

        /*public void DeletePictureBox()
        {
            pictureBox27.Image = null;
            pictureBox27.Image = null;
            pictureBox27.Image = null;
            pictureBox27.Image = null;
            pictureBox27.Image = null;
            pictureBox27.Image = null;
*/
        public void DrawSetCard()
        {
            pictureBox1.Image = DrawCard(cards[0]);
            pictureBox1.Visible = true;
            pictureBox2.Image = DrawCard(cards[1]);
            pictureBox2.Visible = true;
            pictureBox3.Image = DrawCard(cards[2]);
            pictureBox3.Visible = true;
            pictureBox4.Image = DrawCard(cards[3]);
            pictureBox4.Visible = true;
            pictureBox5.Image = DrawCard(cards[4]);
            pictureBox5.Visible = true;
            pictureBox6.Image = DrawCard(cards[5]);
            pictureBox6.Visible = true;
            pictureBox7.Image = DrawCard(cards[6]);
            pictureBox7.Visible = true;
            pictureBox8.Image = DrawCard(cards[7]);
            pictureBox8.Visible = true;
            pictureBox9.Image = DrawCard(cards[8]);
            pictureBox9.Visible = true;
            pictureBox10.Image = DrawCard(cards[9]);
            pictureBox10.Visible = true;
            pictureBox11.Image = DrawCard(cards[10]);
            pictureBox11.Visible = true;
            pictureBox12.Image = DrawCard(cards[11]);
            pictureBox12.Visible = true;
            pictureBox13.Image = DrawCard(cards[12]);
            pictureBox13.Visible = true;
        }

        public void PostCard() // Hàm đánh bài khi bài họp lệ
        {
            //Cập nhật giao diện đánh bài
            Card[] arrTemp = new Card[13];
            Card[] arrTemp2 = new Card[13];
            int j = 12;
            
            for (int i = 12; i >= 0; i--)
            {
                
                if(chooseCard[i] != null)
                {
                    arrTemp[j] = chooseCard[i];
                    j--;
                }
            }
           
            pictureBox27.Image = DrawCard(arrTemp[0]);
            pictureBox28.Image = DrawCard(arrTemp[1]);
            pictureBox29.Image = DrawCard(arrTemp[2]);
            pictureBox30.Image = DrawCard(arrTemp[3]);
            pictureBox31.Image = DrawCard(arrTemp[4]);
            pictureBox32.Image = DrawCard(arrTemp[5]);
            pictureBox33.Image = DrawCard(arrTemp[6]);
            pictureBox34.Image = DrawCard(arrTemp[7]);
            pictureBox35.Image = DrawCard(arrTemp[8]);
            pictureBox36.Image = DrawCard(arrTemp[9]);
            pictureBox37.Image = DrawCard(arrTemp[10]);
            pictureBox38.Image = DrawCard(arrTemp[11]);
            pictureBox39.Image = DrawCard(arrTemp[12]);

            //Xóa bài đã đánh
            for (int i = 0; i < 13; i++)
            {
                if(chooseCard[i] != null)
                {
                    cards[i] = null;

                    soBaiConLai--;

                }
            }
            //Cập nhật lại bài hiện có
            int x = 12;
            for(int i = 12; i >= 0; i--)
            {
                if(cards[i] != null)
                {
                    arrTemp2[x] = cards[i];
                    x--;
                }
            }
            
            
            for (int i = 0; i < 13; i++)
            {
                if (arrTemp2[i] != null)
                {
                    cards[i] = arrTemp2[i];
                    
                }
                else
                {
                    cards[i] = null; 
                }
            }
            TurnOffCardTop();
            DrawSetCard();
            ResetChooseCard();
        }

        
        public void NhanBai(string data)
        {
            int i = 0;
            Card card = new Card();

            string[] arrListStr = data.Split('_');
            string[] arrList = new string[arrListStr.Length - 1];
            for(int j = 0; j < arrListStr.Length - 1; j++)
            {
                arrList[j] = arrListStr[j + 1];
            }
            foreach (string item in arrList)
            {
                if (i == 13)
                {
                    break;
                }
                cards[i] = card.input(item);
                i++;
            }
        }

         Image DrawCard(Card card)
        {
           
            PictureBox pb = new PictureBox();
            pb.Visible = false;
            pb.Width = 161;
            pb.Height = 193;
            if (card != null)
            {
                string temp = card.GetID(card);
                switch (temp)
                {
                    case "144":
                        pb.Image = CLIENT.Properties.Resources._1C;
                        break;
                    case "143":
                        pb.Image = CLIENT.Properties.Resources._1R;
                        break;
                    case "142":
                        pb.Image = CLIENT.Properties.Resources._1H;
                        break;
                    case "141":
                        pb.Image = CLIENT.Properties.Resources._1B;
                        break;
                    case "154":
                        pb.Image = CLIENT.Properties.Resources._2C;
                        break;
                    case "153":
                        pb.Image = CLIENT.Properties.Resources._2R;
                        break;
                    case "152":
                        pb.Image = CLIENT.Properties.Resources._2H;
                        break;
                    case "151":
                        pb.Image = CLIENT.Properties.Resources._2B;
                        break;
                    case "34":
                        pb.Image = CLIENT.Properties.Resources._3C;
                        break;
                    case "33":
                        pb.Image = CLIENT.Properties.Resources._3R;
                        break;
                    case "32":
                        pb.Image = CLIENT.Properties.Resources._3H;
                        break;
                    case "31":
                        pb.Image = CLIENT.Properties.Resources._3B;
                        break;
                    case "44":
                        pb.Image = CLIENT.Properties.Resources._4C;
                        break;
                    case "43":
                        pb.Image = CLIENT.Properties.Resources._4R;
                        break;
                    case "42":
                        pb.Image = CLIENT.Properties.Resources._4H;
                        break;
                    case "41":
                        pb.Image = CLIENT.Properties.Resources._4B;
                        break;
                    case "54":
                        pb.Image = CLIENT.Properties.Resources._5C;
                        break;
                    case "53":
                        pb.Image = CLIENT.Properties.Resources._5R;
                        break;
                    case "52":
                        pb.Image = CLIENT.Properties.Resources._5H;
                        break;
                    case "51":
                        pb.Image = CLIENT.Properties.Resources._5B;
                        break;
                    case "64":
                        pb.Image = CLIENT.Properties.Resources._6C;
                        break;
                    case "63":
                        pb.Image = CLIENT.Properties.Resources._6R;
                        break;
                    case "62":
                        pb.Image = CLIENT.Properties.Resources._6H;
                        break;
                    case "61":
                        pb.Image = CLIENT.Properties.Resources._6B;
                        break;
                    case "74":
                        pb.Image = CLIENT.Properties.Resources._7C;
                        break;
                    case "73":
                        pb.Image = CLIENT.Properties.Resources._7R;
                        break;
                    case "72":
                        pb.Image = CLIENT.Properties.Resources._7H;
                        break;
                    case "71":
                        pb.Image = CLIENT.Properties.Resources._7B;
                        break;
                    case "84":
                        pb.Image = CLIENT.Properties.Resources._8C;
                        break;
                    case "83":
                        pb.Image = CLIENT.Properties.Resources._8R;
                        break;
                    case "82":
                        pb.Image = CLIENT.Properties.Resources._8H;
                        break;
                    case "81":
                        pb.Image = CLIENT.Properties.Resources._8B;
                        break;
                    case "94":
                        pb.Image = CLIENT.Properties.Resources._9C;
                        break;
                    case "93":
                        pb.Image = CLIENT.Properties.Resources._9R;
                        break;
                    case "92":
                        pb.Image = CLIENT.Properties.Resources._9H;
                        break;
                    case "91":
                        pb.Image = CLIENT.Properties.Resources._9B;
                        break;
                    case "104":
                        pb.Image = CLIENT.Properties.Resources._10C;
                        break;
                    case "103":
                        pb.Image = CLIENT.Properties.Resources._10R;
                        break;
                    case "102":
                        pb.Image = CLIENT.Properties.Resources._10H;
                        break;
                    case "101":
                        pb.Image = CLIENT.Properties.Resources._10B;
                        break;
                    case "114":
                        pb.Image = CLIENT.Properties.Resources.JC;
                        break;
                    case "113":
                        pb.Image = CLIENT.Properties.Resources.JR;
                        break;
                    case "112":
                        pb.Image = CLIENT.Properties.Resources.JH;
                        break;
                    case "111":
                        pb.Image = CLIENT.Properties.Resources.JB;
                        break;
                    case "124":
                        pb.Image = CLIENT.Properties.Resources.QC;
                        break;
                    case "123":
                        pb.Image = CLIENT.Properties.Resources.QR;
                        break;
                    case "122":
                        pb.Image = CLIENT.Properties.Resources.QH;
                        break;
                    case "121":
                        pb.Image = CLIENT.Properties.Resources.QB;
                        break;
                    case "134":
                        pb.Image = CLIENT.Properties.Resources.KC;
                        break;
                    case "133":
                        pb.Image = CLIENT.Properties.Resources.KR;
                        break;
                    case "132":
                        pb.Image = CLIENT.Properties.Resources.KH;
                        break;
                    case "131":
                        pb.Image = CLIENT.Properties.Resources.KB;
                        break;
                    default:
                        pb.Image = CLIENT.Properties.Resources.PP;
                        break;
                }
                return pb.Image;
            }

            return null;
        }

        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        private PictureBox pictureBox20;
        private PictureBox pictureBox21;
        private PictureBox pictureBox22;
        private PictureBox pictureBox23;
        private PictureBox pictureBox24;
        private PictureBox pictureBox25;
        private PictureBox pictureBox26;
        private Button button4;
        private Button button3;
        private Button btnBoLuoc;
        private Panel panel1;
        private PictureBox pictureBox27;
        private PictureBox pictureBox28;
        private PictureBox pictureBox29;
        private PictureBox pictureBox30;
        private PictureBox pictureBox31;
        private PictureBox pictureBox32;
        private PictureBox pictureBox33;
        private PictureBox pictureBox34;
        private PictureBox pictureBox35;
        private PictureBox pictureBox36;
        private PictureBox pictureBox37;
        private PictureBox pictureBox38;
        private PictureBox pictureBox39;
        private PictureBox picPlayer1;
        private PictureBox picPlayer2;
        private PictureBox picPlayer3;
        private PictureBox picPlayer4;
    }
}
