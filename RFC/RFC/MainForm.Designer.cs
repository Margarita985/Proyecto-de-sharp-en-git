/*
 * Created by SharpDevelop.
 * User: marga
 * Date: 23/10/2024
 * Time: 06:31 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RFC
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.TxtNombre = new System.Windows.Forms.TextBox();
			this.TxtApellido1 = new System.Windows.Forms.TextBox();
			this.TxtApellido2 = new System.Windows.Forms.TextBox();
			this.TxtTelefono = new System.Windows.Forms.TextBox();
			this.TxtDireccion = new System.Windows.Forms.TextBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.BtnLimpiar = new System.Windows.Forms.Button();
			this.BtnEjecutar = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.lblrfc = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "NOMBRE";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(3, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(119, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "APELLIDO PATERNO";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(3, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(119, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "APELLIDO MATERNO";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(3, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "TELEFONO";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(3, 191);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "DIRECCION";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(3, 241);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "SEMESTR";
			// 
			// TxtNombre
			// 
			this.TxtNombre.Location = new System.Drawing.Point(118, 42);
			this.TxtNombre.Name = "TxtNombre";
			this.TxtNombre.Size = new System.Drawing.Size(100, 20);
			this.TxtNombre.TabIndex = 6;
			// 
			// TxtApellido1
			// 
			this.TxtApellido1.Location = new System.Drawing.Point(118, 79);
			this.TxtApellido1.Name = "TxtApellido1";
			this.TxtApellido1.Size = new System.Drawing.Size(100, 20);
			this.TxtApellido1.TabIndex = 7;
			// 
			// TxtApellido2
			// 
			this.TxtApellido2.Location = new System.Drawing.Point(118, 116);
			this.TxtApellido2.Name = "TxtApellido2";
			this.TxtApellido2.Size = new System.Drawing.Size(100, 20);
			this.TxtApellido2.TabIndex = 8;
			// 
			// TxtTelefono
			// 
			this.TxtTelefono.Location = new System.Drawing.Point(118, 155);
			this.TxtTelefono.Name = "TxtTelefono";
			this.TxtTelefono.Size = new System.Drawing.Size(100, 20);
			this.TxtTelefono.TabIndex = 9;
			// 
			// TxtDireccion
			// 
			this.TxtDireccion.Location = new System.Drawing.Point(118, 194);
			this.TxtDireccion.Name = "TxtDireccion";
			this.TxtDireccion.Size = new System.Drawing.Size(100, 20);
			this.TxtDireccion.TabIndex = 10;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"semestre 1",
									"semestre 2",
									"semestre 3",
									"semestre 4",
									"semestre 5",
									"semestre 6"});
			this.comboBox1.Location = new System.Drawing.Point(118, 243);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 11;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(128, 277);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 12;
			// 
			// BtnLimpiar
			// 
			this.BtnLimpiar.Location = new System.Drawing.Point(12, 322);
			this.BtnLimpiar.Name = "BtnLimpiar";
			this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.BtnLimpiar.TabIndex = 13;
			this.BtnLimpiar.Text = "LIMPIAR";
			this.BtnLimpiar.UseVisualStyleBackColor = true;
			this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// BtnEjecutar
			// 
			this.BtnEjecutar.Location = new System.Drawing.Point(143, 322);
			this.BtnEjecutar.Name = "BtnEjecutar";
			this.BtnEjecutar.Size = new System.Drawing.Size(75, 23);
			this.BtnEjecutar.TabIndex = 14;
			this.BtnEjecutar.Text = "EJECUTAR";
			this.BtnEjecutar.UseVisualStyleBackColor = true;
			this.BtnEjecutar.Click += new System.EventHandler(this.BtnEjecutarClick);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(3, 277);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(119, 23);
			this.label7.TabIndex = 15;
			this.label7.Text = "FECHA NACIMIENTO";
			// 
			// lblrfc
			// 
			this.lblrfc.Location = new System.Drawing.Point(278, 158);
			this.lblrfc.Name = "lblrfc";
			this.lblrfc.Size = new System.Drawing.Size(100, 23);
			this.lblrfc.TabIndex = 16;
			this.lblrfc.Text = "______";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(440, 386);
			this.Controls.Add(this.lblrfc);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.BtnEjecutar);
			this.Controls.Add(this.BtnLimpiar);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.TxtDireccion);
			this.Controls.Add(this.TxtTelefono);
			this.Controls.Add(this.TxtApellido2);
			this.Controls.Add(this.TxtApellido1);
			this.Controls.Add(this.TxtNombre);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "RFC";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblrfc;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button BtnEjecutar;
		private System.Windows.Forms.Button BtnLimpiar;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox TxtDireccion;
		private System.Windows.Forms.TextBox TxtTelefono;
		private System.Windows.Forms.TextBox TxtApellido2;
		private System.Windows.Forms.TextBox TxtApellido1;
		private System.Windows.Forms.TextBox TxtNombre;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
