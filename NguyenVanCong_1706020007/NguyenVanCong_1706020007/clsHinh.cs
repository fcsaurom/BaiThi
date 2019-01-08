/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 1/8/2019
 * Time: 8:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;

namespace NguyenVanCong_1706020007
{
	/// <summary>
	/// Description of clsHinh.
	/// </summary>
	public class clsHinh
	{
		clsDiem A ,B, C;
		public clsDiem A1
		{
			get
			{
				return A;
			}
			set
			{
				A.Nx = value.Nx;
				A.Ny = value.Ny;
			}
		}
		public clsDiem B1
		{
			get
			{
				return B;
			}
			set
			{
				B.Nx = value.Nx;
				B.Ny = value.Ny;
			}
		}
		public clsDiem C1
		{
			get
			{
				return C;
			}
			set
			{
				C.Nx = value.Nx;
				C.Ny = value.Ny;
			}
		}
		public clsHinh()
		{
			A = new clsDiem();
			B = new clsDiem();
			C = new clsDiem();
		}
		public clsHinh(clsDiem a,clsDiem b, clsDiem c)
		{
			A = a;
			B = b;
			C = c;
		}
		public virtual void Draw(Graphics g, Pen p)
		{
			
		}
	}
}
