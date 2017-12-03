/*
 * Created by SharpDevelop.
 * User: Giang Thai
 * Date: 12/3/2017
 * Time: 1:37 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace locate_on_GoogleMaps
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button buttonGET;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.RadioButton rBtnFromMyIP;
		private System.Windows.Forms.RadioButton rBtnFromCoordinate;
		private System.Windows.Forms.RadioButton rBtnFromAddress;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxLong;
		private System.Windows.Forms.TextBox textBoxLat;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxAddress;
		private System.Windows.Forms.RadioButton rBtnCoordinate;
		private System.Windows.Forms.RadioButton rBtnAddress;
		private System.Windows.Forms.WebBrowser webBrowser1;
		
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonGET = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.rBtnFromMyIP = new System.Windows.Forms.RadioButton();
            this.rBtnFromCoordinate = new System.Windows.Forms.RadioButton();
            this.rBtnFromAddress = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLong = new System.Windows.Forms.TextBox();
            this.textBoxLat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.rBtnCoordinate = new System.Windows.Forms.RadioButton();
            this.rBtnAddress = new System.Windows.Forms.RadioButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonGET);
            this.splitContainer1.Panel1.Controls.Add(this.buttonOK);
            this.splitContainer1.Panel1.Controls.Add(this.rBtnFromMyIP);
            this.splitContainer1.Panel1.Controls.Add(this.rBtnFromCoordinate);
            this.splitContainer1.Panel1.Controls.Add(this.rBtnFromAddress);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxLong);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxLat);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxAddress);
            this.splitContainer1.Panel1.Controls.Add(this.rBtnCoordinate);
            this.splitContainer1.Panel1.Controls.Add(this.rBtnAddress);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(883, 448);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonGET
            // 
            this.buttonGET.Location = new System.Drawing.Point(108, 360);
            this.buttonGET.Name = "buttonGET";
            this.buttonGET.Size = new System.Drawing.Size(75, 23);
            this.buttonGET.TabIndex = 14;
            this.buttonGET.Text = "GET";
            this.buttonGET.UseVisualStyleBackColor = true;
            this.buttonGET.Click += new System.EventHandler(this.buttonGET_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(108, 182);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 13;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // rBtnFromMyIP
            // 
            this.rBtnFromMyIP.Location = new System.Drawing.Point(12, 303);
            this.rBtnFromMyIP.Name = "rBtnFromMyIP";
            this.rBtnFromMyIP.Size = new System.Drawing.Size(161, 24);
            this.rBtnFromMyIP.TabIndex = 12;
            this.rBtnFromMyIP.TabStop = true;
            this.rBtnFromMyIP.Text = "From My IP to Coordinate";
            this.rBtnFromMyIP.UseVisualStyleBackColor = true;
            this.rBtnFromMyIP.CheckedChanged += new System.EventHandler(this.rBtnFromMyIP_CheckedChanged);
            // 
            // rBtnFromCoordinate
            // 
            this.rBtnFromCoordinate.Location = new System.Drawing.Point(12, 273);
            this.rBtnFromCoordinate.Name = "rBtnFromCoordinate";
            this.rBtnFromCoordinate.Size = new System.Drawing.Size(161, 24);
            this.rBtnFromCoordinate.TabIndex = 11;
            this.rBtnFromCoordinate.TabStop = true;
            this.rBtnFromCoordinate.Text = "From Coordinate to Address";
            this.rBtnFromCoordinate.UseVisualStyleBackColor = true;
            this.rBtnFromCoordinate.CheckedChanged += new System.EventHandler(this.rBtnFromCoordinate_CheckedChanged);
            // 
            // rBtnFromAddress
            // 
            this.rBtnFromAddress.Location = new System.Drawing.Point(12, 243);
            this.rBtnFromAddress.Name = "rBtnFromAddress";
            this.rBtnFromAddress.Size = new System.Drawing.Size(161, 24);
            this.rBtnFromAddress.TabIndex = 10;
            this.rBtnFromAddress.TabStop = true;
            this.rBtnFromAddress.Text = "From Address to Coordinate";
            this.rBtnFromAddress.UseVisualStyleBackColor = true;
            this.rBtnFromAddress.CheckedChanged += new System.EventHandler(this.rBtnFromAddress_CheckedChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Get Information";
            // 
            // textBoxLong
            // 
            this.textBoxLong.Location = new System.Drawing.Point(64, 145);
            this.textBoxLong.Name = "textBoxLong";
            this.textBoxLong.Size = new System.Drawing.Size(213, 20);
            this.textBoxLong.TabIndex = 8;
            // 
            // textBoxLat
            // 
            this.textBoxLat.Location = new System.Drawing.Point(64, 121);
            this.textBoxLat.Name = "textBoxLat";
            this.textBoxLat.Size = new System.Drawing.Size(213, 20);
            this.textBoxLat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Long:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lat:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Coordinate";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Address";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(12, 72);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(265, 20);
            this.textBoxAddress.TabIndex = 2;
            this.textBoxAddress.Text = "Trường Đại học Công nghệ Thông tin";
            // 
            // rBtnCoordinate
            // 
            this.rBtnCoordinate.Location = new System.Drawing.Point(150, 25);
            this.rBtnCoordinate.Name = "rBtnCoordinate";
            this.rBtnCoordinate.Size = new System.Drawing.Size(104, 24);
            this.rBtnCoordinate.TabIndex = 1;
            this.rBtnCoordinate.TabStop = true;
            this.rBtnCoordinate.Text = "Coordinate";
            this.rBtnCoordinate.UseVisualStyleBackColor = true;
            this.rBtnCoordinate.CheckedChanged += new System.EventHandler(this.rBtnCoordinate_CheckedChanged);
            // 
            // rBtnAddress
            // 
            this.rBtnAddress.Location = new System.Drawing.Point(12, 25);
            this.rBtnAddress.Name = "rBtnAddress";
            this.rBtnAddress.Size = new System.Drawing.Size(104, 24);
            this.rBtnAddress.TabIndex = 0;
            this.rBtnAddress.TabStop = true;
            this.rBtnAddress.Text = "Address";
            this.rBtnAddress.UseVisualStyleBackColor = true;
            this.rBtnAddress.CheckedChanged += new System.EventHandler(this.rBtnAddress_CheckedChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(585, 448);
            this.webBrowser1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 448);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "locate_on_GoogleMaps";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
	}
}
