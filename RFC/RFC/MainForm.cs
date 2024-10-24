/*
 * Created by SharpDevelop.
 * User: marga
 * Date: 23/10/2024
 * Time: 06:31 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RFC
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnEjecutarClick(object sender, EventArgs e)
		{
			string Nombre= TxtNombre.Text;
			string ApellidoPaterno= TxtApellido1.Text;
			string ApellidoMaterno= TxtApellido2.Text;
			string Telefono = TxtTelefono.Text;
			string Direccion = TxtDireccion.Text;
			string Semestre= comboBox1.SelectedItem.ToString();
			     DateTime
			fechadenacimiento=dateTimePicker1.Value;
			 
			     
			     
			     Random random= new Random();
			     string h=random.Next(100000, 9999999).ToString("D6");
			     string RFC= ApellidoPaterno.Substring(0,2)+ ApellidoMaterno.Substring(0,1)+ Nombre.Substring(0,1)+ fechadenacimiento.ToString("yyMMdd")+ h.Substring(0,3);
			     lblrfc.Text="RFC= "+ RFC;
			          
			          
			          	
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			TxtApellido1.Text= "";
			TxtApellido2.Text= "";
			TxtDireccion.Text="";
			TxtNombre.Text="";
			TxtTelefono.Text="";
			comboBox1.Text="";
			dateTimePicker1.Text="";
			lblrfc.Text="";
		}
	}
}
