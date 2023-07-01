using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._crypt.hash_.sha_
{
	/// <summary>
	/// sha256
	/// </summary>
	public class TwoFivSix
	{
		static public byte[] Bytes(byte[] bytes)
		{
			using (var hasher = System.Security.Cryptography.SHA256.Create())
			{
				return hasher.ComputeHash(bytes);

			}
			;


		}
		static public byte[] Bytes(string bytes)
		{

			return Bytes(
				Encoding.UTF8.GetBytes(bytes)
			);

		}

		static public string HexLower(string bytes)
		{

			//return   string.(
			//	Bytes(bytes).Select(b=>b.ToString("x2") )
			//);

			return  string.Join("",
				Bytes(bytes).Select(b=>b.ToString("x2") )	//x:lower hex; 2: "0d" rather than "d"
			);


		}



	}
}
