/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 1/8/2019
 * Time: 8:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NguyenVanCong_1706020007
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tNormal = new System.Windows.Forms.ToolStripButton();
			this.tLine = new System.Windows.Forms.ToolStripButton();
			this.tTriangle = new System.Windows.Forms.ToolStripButton();
			this.tRec = new System.Windows.Forms.ToolStripButton();
			this.tCircle = new System.Windows.Forms.ToolStripButton();
			this.tClear = new System.Windows.Forms.ToolStripButton();
			this.tSave = new System.Windows.Forms.ToolStripButton();
			this.tLoad = new System.Windows.Forms.ToolStripButton();
			this.pnDrawBoard = new System.Windows.Forms.PictureBox();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pnDrawBoard)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tNormal,
									this.tLine,
									this.tTriangle,
									this.tRec,
									this.tCircle,
									this.tClear,
									this.tSave,
									this.tLoad});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(517, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tNormal
			// 
			this.tNormal.Image = ((System.Drawing.Image)(resources.GetObject("tNormal.Image")));
			this.tNormal.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tNormal.Name = "tNormal";
			this.tNormal.Size = new System.Drawing.Size(67, 22);
			this.tNormal.Text = "Normal";
			this.tNormal.Click += new System.EventHandler(this.TNormalClick);
			// 
			// tLine
			// 
			this.tLine.Image = ((System.Drawing.Image)(resources.GetObject("tLine.Image")));
			this.tLine.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tLine.Name = "tLine";
			this.tLine.Size = new System.Drawing.Size(49, 22);
			this.tLine.Text = "Line";
			this.tLine.Click += new System.EventHandler(this.TLineClick);
			// 
			// tTriangle
			// 
			this.tTriangle.Image = ((System.Drawing.Image)(resources.GetObject("tTriangle.Image")));
			this.tTriangle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tTriangle.Name = "tTriangle";
			this.tTriangle.Size = new System.Drawing.Size(69, 22);
			this.tTriangle.Text = "Triangle";
			this.tTriangle.Click += new System.EventHandler(this.TTriangleClick);
			// 
			// tRec
			// 
			this.tRec.Image = ((System.Drawing.Image)(resources.GetObject("tRec.Image")));
			this.tRec.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tRec.Name = "tRec";
			this.tRec.Size = new System.Drawing.Size(79, 22);
			this.tRec.Text = "Rectangle";
			this.tRec.Click += new System.EventHandler(this.TRecClick);
			// 
			// tCircle
			// 
			this.tCircle.Image = ((System.Drawing.Image)(resources.GetObject("tCircle.Image")));
			this.tCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tCircle.Name = "tCircle";
			this.tCircle.Size = new System.Drawing.Size(57, 22);
			this.tCircle.Text = "Circle";
			this.tCircle.Click += new System.EventHandler(this.TCircleClick);
			// 
			// tClear
			// 
			this.tClear.Image = ((System.Drawing.Image)(resources.GetObject("tClear.Image")));
			this.tClear.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tClear.Name = "tClear";
			this.tClear.Size = new System.Drawing.Size(54, 22);
			this.tClear.Text = "Clear";
			this.tClear.Click += new System.EventHandler(this.TClearClick);
			// 
			// tSave
			// 
			this.tSave.Image = ((System.Drawing.Image)(resources.GetObject("tSave.Image")));
			this.tSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tSave.Name = "tSave";
			this.tSave.Size = new System.Drawing.Size(51, 22);
			this.tSave.Text = "Save";
			this.tSave.Click += new System.EventHandler(this.TSaveClick);
			// 
			// tLoad
			// 
			this.tLoad.Image = ((System.Drawing.Image)(resources.GetObject("tLoad.Image")));
			this.tLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tLoad.Name = "tLoad";
			this.tLoad.Size = new System.Drawing.Size(53, 22);
			this.tLoad.Text = "Load";
			this.tLoad.Click += new System.EventHandler(this.TLoadClick);
			// 
			// pnDrawBoard
			// 
			this.pnDrawBoard.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.pnDrawBoard.Location = new System.Drawing.Point(12, 28);
			this.pnDrawBoard.Name = "pnDrawBoard";
			this.pnDrawBoard.Size = new System.Drawing.Size(492, 256);
			this.pnDrawBoard.TabIndex = 1;
			this.pnDrawBoard.TabStop = false;
			this.pnDrawBoard.Click += new System.EventHandler(this.PnDrawBoardClick);
			this.pnDrawBoard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnDrawBoardMouseDown);
			this.pnDrawBoard.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnDrawBoardMouseMove);
			this.pnDrawBoard.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PnDrawBoardMouseUp);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(517, 296);
			this.Controls.Add(this.pnDrawBoard);
			this.Controls.Add(this.toolStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "NguyenVanCong_1706020007";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pnDrawBoard)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripButton tTriangle;
		private System.Windows.Forms.ToolStripButton tLoad;
		private System.Windows.Forms.ToolStripButton tSave;
		private System.Windows.Forms.ToolStripButton tClear;
		private System.Windows.Forms.ToolStripButton tCircle;
		private System.Windows.Forms.ToolStripButton tNormal;
		private System.Windows.Forms.PictureBox pnDrawBoard;
		private System.Windows.Forms.ToolStripButton tRec;
		private System.Windows.Forms.ToolStripButton tLine;
		private System.Windows.Forms.ToolStrip toolStrip1;
	}
}
