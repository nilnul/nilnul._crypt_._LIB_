using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Security.Cryptography;
using System.Text;

namespace nilnul.crypt_.protect_
{


	public class InUsr
	{
		private static readonly byte[] _entropyBytes = Encoding.UTF8.GetBytes("NuGet");

		public static string EncryptString(string value)
		{
			//if (!RuntimeEnvironmentHelper.IsWindows && !RuntimeEnvironmentHelper.IsMono)
			//{
			//	throw new NotSupportedException(Resources.Error_EncryptionUnsupported);
			//}

			var decryptedByteArray = Encoding.UTF8.GetBytes(value);
			var encryptedByteArray = ProtectedData.Protect(decryptedByteArray, _entropyBytes, DataProtectionScope.CurrentUser);
			var encryptedString = Convert.ToBase64String(encryptedByteArray);
			return encryptedString;
		}

		public static string DecryptString(string encryptedString)
		{
			//if (!RuntimeEnvironmentHelper.IsWindows && !RuntimeEnvironmentHelper.IsMono)
			//{
			//	throw new NotSupportedException(Resources.Error_EncryptionUnsupported);
			//}

			var encryptedByteArray = Convert.FromBase64String(encryptedString);
			var decryptedByteArray = ProtectedData.Unprotect(encryptedByteArray, _entropyBytes, DataProtectionScope.CurrentUser);
			return Encoding.UTF8.GetString(decryptedByteArray);
		}
		/*excerpted from Nuget Source code*/
	}
}


