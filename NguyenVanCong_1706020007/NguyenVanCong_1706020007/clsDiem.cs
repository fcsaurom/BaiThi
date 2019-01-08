/*
 * Created by SharpDevelop.
 * User: Admin
 * Date: 1/8/2019
 * Time: 8:35 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace NguyenVanCong_1706020007
{
	/// <summary>
	/// Description of clsDiem.
	/// </summary>
	public class clsDiem
	{
		int x,y;
		public clsDiem()
		{
			x=0;
			y=0;
		}
		public clsDiem(int Nx,int Ny)
		{
			x = Nx;
			y = Ny;	
		}
		public int Nx
		{
			get
			{
				return x;
			}
			set
			{
				x =value;
			}
		}
		public int Ny
		{
			get 
			{
				return y;
				
			}
			set
			{
				y =value;
			}
		}
	}
}
