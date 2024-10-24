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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.lbl_nom2 = new System.Windows.Forms.Label();
			this.lbl_rfc = new System.Windows.Forms.Label();
			this.BtnSig = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_nom2
			// 
			this.lbl_nom2.BackColor = System.Drawing.Color.Tan;
			this.lbl_nom2.Location = new System.Drawing.Point(26, 9);
			this.lbl_nom2.Name = "lbl_nom2";
			this.lbl_nom2.Size = new System.Drawing.Size(208, 23);
			this.lbl_nom2.TabIndex = 0;
			this.lbl_nom2.Text = "_____";
			// 
			// lbl_rfc
			// 
			this.lbl_rfc.BackColor = System.Drawing.Color.Tan;
			this.lbl_rfc.Location = new System.Drawing.Point(26, 53);
			this.lbl_rfc.Name = "lbl_rfc";
			this.lbl_rfc.Size = new System.Drawing.Size(100, 23);
			this.lbl_rfc.TabIndex = 1;
			this.lbl_rfc.Text = "__________";
			// 
			// BtnSig
			// 
			this.BtnSig.BackColor = System.Drawing.Color.SandyBrown;
			this.BtnSig.Location = new System.Drawing.Point(71, 141);
			this.BtnSig.Name = "BtnSig";
			this.BtnSig.Size = new System.Drawing.Size(114, 38);
			this.BtnSig.TabIndex = 2;
			this.BtnSig.Text = "Siguiente";
			this.BtnSig.UseVisualStyleBackColor = false;
			this.BtnSig.Click += new System.EventHandler(this.BtnSigClick);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(276, 261);
			this.Controls.Add(this.BtnSig);
			this.Controls.Add(this.lbl_rfc);
			this.Controls.Add(this.lbl_nom2);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button BtnSig;
		private System.Windows.Forms.Label lbl_rfc;
		private System.Windows.Forms.Label lbl_nom2;
	}
}
