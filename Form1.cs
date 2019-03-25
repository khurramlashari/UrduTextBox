/*
 * Author: Muhammad Mobeen Movania
 * Last modified: 9 June 2007
 * 
 * This product is provided as is without any implied warranty
 * Use it at your own risk.
 * You may use this in a product provided that you keep this notice
 * and the Author tag above and also provide the author name in your
 * application somewhere ideally in the about box. 
 * If you feel you have improved it, please let me know at mobeen211@yahoo.com
 * so that others may benefit from it. 
 * 
 * This demonstrate how you can create a simple UrduTextBox in c#.
 * */
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace UrduTextBoxDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private UrduTextBoxDemo.UrduTextBox urduTextBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.urduTextBox1 = new UrduTextBoxDemo.UrduTextBox();
			this.SuspendLayout();
			// 
			// urduTextBox1
			// 
			this.urduTextBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(178)));
			this.urduTextBox1.Location = new System.Drawing.Point(8, 8);
			this.urduTextBox1.Name = "urduTextBox1";
			this.urduTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.urduTextBox1.Size = new System.Drawing.Size(280, 32);
			this.urduTextBox1.TabIndex = 0;
			this.urduTextBox1.Text = "urduTextBox1";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.Add(this.urduTextBox1);
			this.Name = "Form1";
			this.Text = "Test urdu textbox";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			urduTextBox1.Text="یہاںلكھیں";
		}
	}
}
