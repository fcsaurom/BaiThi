/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 1/8/2019
 * Time: 9:06 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace NguyenVanCong_1706020007
{
	/// <summary>
	/// Description of clsTriangle.
	/// </summary>
	public class clsTriangle:clsHinh
	{
		public clsTriangle()
		{
		}
		public clsTriangle(clsDiem a, clsDiem b, clsDiem c)
		{
			A1 = a;
			B1 = b;
			C1 = c;
		}
		public void Draw(System.Drawing.Graphics g, System.Drawing.Pen p, PointF [] points)
		{
			points = new PointF[4];
			points[0] = new PointF((A1.Nx + B1.Nx)/2,0);
			points[1] = new PointF((A1.Nx + B1.Nx)/2,B1.Ny);
			points[2] = new PointF(B1.Ny,A1.Ny);
			points[3] = new PointF(A1.Ny,(A1.Nx + B1.Nx)/2);
			g.DrawRectangle(p,A1.Nx, A1.Ny, B1.Nx, B1.Ny);
			g.DrawPolygon(p,points);
		}
	}
}
