/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 1/8/2019
 * Time: 8:53 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NguyenVanCong_1706020007
{
	/// <summary>
	/// Description of clsRectangle.
	/// </summary>
	public class clsRectangle:clsHinh
	{
		public clsRectangle()
		{
		}
		public clsRectangle(clsDiem a,clsDiem b)
		{
			A1 = a;
			B1 = b;
		}
		public override void Draw(System.Drawing.Graphics g, System.Drawing.Pen p)
		{
			g.DrawRectangle(p,A1.Nx,A1.Ny,B1.Nx,B1.Ny);
		}
	}
}
