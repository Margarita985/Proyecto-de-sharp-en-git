/*
 * Created by SharpDevelop.
 * User: marga
 * Date: 23/10/2024
 * Time: 08:39 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RFC
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form2 : Form
	{
		public Form2(string text, string text2)
			
		{
			InitializeComponent();
			lbl_nom2.Text=text;
			lbl_rfc.Text=text2;
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			
		}
	}
}

