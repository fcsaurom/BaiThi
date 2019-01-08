/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 1/8/2019
 * Time: 8:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Drawing2D;

namespace NguyenVanCong_1706020007
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Image file;
		Graphics g;
		Pen pen;
		List<clsHinh> List = new List<clsHinh>();
		clsDiem A = new clsDiem();
		clsDiem B = new clsDiem();
		clsDiem C = new clsDiem();
		clsLine Line ;
		clsTriangle triangle;
		clsEclip Eclip;
		clsRectangle rec;
		bool DrawNormal = false;
		bool Drawrectangle = false;
		bool DrawEclip = false;
		bool DrawLine = false;
		bool isDrawing = false;
		bool DrawTriangle = false;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			g = pnDrawBoard.CreateGraphics();
			pen = new Pen(Color.Black);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void TNormalClick(object sender, EventArgs e)
		{
			DrawNormal = true;
			DrawEclip= false;
			Drawrectangle = false;
			DrawLine = false;
			DrawTriangle = false;
		}
		
		void TLineClick(object sender, EventArgs e)
		{
			DrawLine = true;
			DrawNormal = false;
			DrawEclip= false;
			Drawrectangle = false;
			DrawTriangle = false;
		}
		
		void TCircleClick(object sender, EventArgs e)
		{
			DrawEclip = true;
			DrawLine = false;
			DrawNormal = false;
			Drawrectangle = false;
			DrawTriangle = false;
		}
		
		void TRecClick(object sender, EventArgs e)
		{
			Drawrectangle = true;
			DrawLine = false;
			DrawNormal = false;
			DrawEclip= false;
			DrawTriangle = false;
		}
		
		void TClearClick(object sender, EventArgs e)
		{
			g.Clear(Color.White);
			List.Clear();
		}
		
		void TSaveClick(object sender, EventArgs e)
		{
			SaveFileDialog dialog = new SaveFileDialog();
			dialog.Filter ="JPEG(*.jpg)|*.jpg";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				
			   int width = Convert.ToInt32(pnDrawBoard.Width); 
			   int height = Convert.ToInt32(pnDrawBoard.Height); 
			   Bitmap bmp = new Bitmap( width,height);
			   Rectangle Rec = new Rectangle(0,0,width,height);
			   pnDrawBoard.DrawToBitmap(bmp,Rec);
			   bmp.Save(dialog.FileName, ImageFormat.Jpeg);
			}
		}
		
		void TLoadClick(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.Filter = "JPEG(*.jpg)|*.jpg";
			if(open.ShowDialog() == DialogResult.OK )
			{
				
				file = Image.FromFile(open.FileName);
				pnDrawBoard.Image = file;
				MessageBox.Show("Load OK !");
			}
		}
		
		void PnDrawBoardClick(object sender, EventArgs e)
		{
			
		}
		
		void PnDrawBoardMouseDown(object sender, MouseEventArgs e)
		{
			if(DrawNormal == true)
			{
				isDrawing = true;
				A.Nx = e.X;
				A.Ny = e.Y;
			}
			if(DrawLine == true)
			{
				isDrawing = true;
				A.Nx = e.X;
				A.Ny = e.Y;
			}
			if(Drawrectangle == true)
			{
				isDrawing = true;
				A.Nx = e.X;
				A.Ny = e.Y;
			}
			if(DrawEclip == true)
			{
				isDrawing = true;
				A.Nx = e.X;
				A.Ny = e.Y;
			}
			if(DrawTriangle == true)
			{
				isDrawing = true;
				A.Nx = e.X;
				A.Ny = e.Y;
			}
		}
		
		void PnDrawBoardMouseMove(object sender, MouseEventArgs e)
		{
			if(isDrawing == true)
			{
			
				if(DrawNormal == true)
				{
					g.DrawLine(pen,new Point(A.Nx,A.Ny),e.Location);
					A.Nx = e.X;
					A.Ny = e.Y;
				}
				if(DrawLine == true)
				{
					
					g.DrawLine(new Pen(Color.White),A.Nx,A.Ny,B.Nx,B.Ny);
					B.Nx = e.X;
					B.Ny = e.Y;
					foreach(var item in List)
					{
						item.Draw(g,pen);
					}
					g.DrawLine(pen,A.Nx,A.Ny,B.Nx,B.Ny);
				
				}
				if(Drawrectangle == true)
				{
					g.DrawRectangle(new Pen(Color.White),A.Nx,A.Ny,B.Nx,B.Ny);
					B.Nx = e.X;
					B.Ny = e.Y;
					foreach(var item in List)
					{
						item.Draw(g,pen);
					}
					g.DrawRectangle(pen,A.Nx,A.Ny,B.Nx,B.Ny);
				
				}
				if(DrawEclip == true)
				{
					g.DrawEllipse(new Pen(Color.White),A.Nx,A.Ny,B.Nx,B.Ny);
					B.Nx = e.X;
					B.Ny = e.Y;
					foreach(var item in List)
					{
						item.Draw(g,pen);
					}
					g.DrawEllipse(pen,A.Nx,A.Ny,B.Nx,B.Ny);
				}
				
			}
		}
		
		void PnDrawBoardMouseUp(object sender, MouseEventArgs e)
		{
			isDrawing = false;
			B.Nx = e.X;
			B.Ny = e.Y;
			if(DrawLine == true)
			{
				Line = new clsLine(A,B);
				List.Add(Line);
				foreach(var item in List)
				{
					item.Draw(g,pen);
				}
			}
			if(DrawEclip == true)
			{
				Eclip = new clsEclip(A,B);
				List.Add(Eclip);
				foreach (var item in List) {
					item.Draw(g,pen);
				}
				B.Nx =0;
				B.Ny =0;
			}
			if(Drawrectangle == true)
			{
				rec = new clsRectangle(A,B);
				List.Add(rec);
				foreach (var item in List) {
					item.Draw(g,pen);
				}
				B.Nx =0;
				B.Ny =0;
			}
			if(DrawTriangle == true)
			{
				triangle = new clsTriangle(A,B,C);
				List.Add(triangle);
				foreach(var item in List)
				{
					item.Draw(g, new Pen(Color.White));
				}
				Point [] a = new Point[4];
				a[0] = new Point(A.Nx, A.Nx);
				a[1] = new Point(B.Nx, B.Ny);
				a[2] = new Point(C.Nx, A.Ny);
				a[3] = new Point(A.Nx, A.Nx);
				g.DrawLines(pen,a);
			}
			
		}
		
		void TTriangleClick(object sender, EventArgs e)
		{
			DrawEclip = false;
			DrawLine = false;
			DrawNormal = false;
			Drawrectangle = false;
			DrawTriangle = true;
		}
	}
}
