/*
 * Created by SharpDevelop.
 * User: marga
 * Date: 23/10/2024
 * Time: 08:39 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace RFC
{
	partial class Form2
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
			this.lbl_nom2 = new System.Windows.Forms.Label();
			this.lbl_rfc = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_nom2
			// 
			this.lbl_nom2.Location = new System.Drawing.Point(64, 21);
			this.lbl_nom2.Name = "lbl_nom2";
			this.lbl_nom2.Size = new System.Drawing.Size(208, 23);
			this.lbl_nom2.TabIndex = 0;
			this.lbl_nom2.Text = "_____";
			// 
			// lbl_rfc
			// 
			this.lbl_rfc.Location = new System.Drawing.Point(68, 73);
			this.lbl_rfc.Name = "lbl_rfc";
			this.lbl_rfc.Size = new System.Drawing.Size(100, 23);
			this.lbl_rfc.TabIndex = 1;
			this.lbl_rfc.Text = "__________";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.lbl_rfc);
			this.Controls.Add(this.lbl_nom2);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lbl_rfc;
		private System.Windows.Forms.Label lbl_nom2;
	}
}
