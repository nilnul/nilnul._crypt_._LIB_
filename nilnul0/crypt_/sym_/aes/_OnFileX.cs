using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using nilnul.fs.address_;
using nilnul.fs.address_.spear_;

namespace nilnul.crypt_.sym_.aes
{
	static public class _OnFileX
	{
		public const string NoLed_IN_DottedExt = "aes";
		public const string Ext = "." + NoLed_IN_DottedExt;

		public static void _Encrypt(string inputFile, string password, string outputFile)
		{
			//http://stackoverflow.com/questions/27645527/aes-encryption-on-large-files

			//generate random salt
			byte[] salt = _crypt._SaltX.GenerateRandomSalt();

			//create output file name
			FileStream fsCrypt = new FileStream(
				outputFile, FileMode.Create
			);

			//convert password string to byte arrray
			byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);

			//Set Rijndael symmetric encryption algorithm
			RijndaelManaged AES = new RijndaelManaged();
			AES.KeySize = 256;
			AES.BlockSize = 128;
			AES.Padding = PaddingMode.PKCS7;

			//http://stackoverflow.com/questions/2659214/why-do-i-need-to-use-the-rfc2898derivebytes-class-in-net-instead-of-directly
			//"What it does is repeatedly hash the user password along with the salt." High iteration counts.
			var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
			AES.Key = key.GetBytes(AES.KeySize / 8);
			AES.IV = key.GetBytes(AES.BlockSize / 8);

			//Cipher modes: http://security.stackexchange.com/questions/52665/which-is-the-best-cipher-mode-and-padding-mode-for-aes-encryption
			AES.Mode = CipherMode.CFB;

			//write salt to the begining of the output file, so in this case can be random every time
			fsCrypt.Write(salt, 0, salt.Length);

			CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateEncryptor(), CryptoStreamMode.Write);

			FileStream fsIn = new FileStream(inputFile, FileMode.Open);

			//create a buffer (1mb) so only this amount will allocate in the memory and not the whole file
			byte[] buffer = new byte[1048576];
			int read;

			try
			{
				while ((read = fsIn.Read(buffer, 0, buffer.Length)) > 0)
				{
					//Application.DoEvents(); // -> for responsive GUI, using Task will be better!
					cs.Write(buffer, 0, read);
				}

				//close up
				fsIn.Close();

			}
			catch (Exception ex)
			{
				throw;
			}
			finally
			{
				cs.Close();
				fsCrypt.Close();
			}
		}
		public static void _Encrypt(SpearI parentDoc, string password, SpearI targetDoc)
		{
			_Encrypt(parentDoc.ToString(), password, targetDoc.ToString());
		}

		public static ParentDoc _Encrypt(string inputFile, string password)
		{
			var parentDoc = nilnul.fs.address_.spear_.ParentDoc.Parse(inputFile);
			var target = new nilnul.fs.address_.spear_.ParentDoc(
				parentDoc.parent
				,
				new nilnul.fs.folder.denote_.mainVered_.appendSubIfNeed_.Next(parentDoc.parent).denote(
					parentDoc.doc.ToString()
					,
					Ext
				)
			);

			_Encrypt(
				parentDoc, password, target
			);
			return target;
		}

		public static void _Decrypt(string inputFile, string password, string outputFile)
		{
			//todo:
			// - create error message on wrong password
			// - on cancel: close and delete file
			// - on wrong password: close and delete file!
			// - create a better filen name
			// - could be check md5 hash on the files but it make this slow

			byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
			byte[] salt = new byte[32];

			FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);
			fsCrypt.Read(salt, 0, salt.Length);

			RijndaelManaged AES = new RijndaelManaged();
			AES.KeySize = 256;
			AES.BlockSize = 128;
			var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
			AES.Key = key.GetBytes(AES.KeySize / 8);
			AES.IV = key.GetBytes(AES.BlockSize / 8);
			AES.Padding = PaddingMode.PKCS7;
			AES.Mode = CipherMode.CFB;

			CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);

			FileStream fsOut = new FileStream(outputFile, FileMode.Create);

			int read;
			byte[] buffer = new byte[1048576];

			try
			{
				while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
				{
					//Application.DoEvents();
					fsOut.Write(buffer, 0, read);
				}
			}
			catch (System.Security.Cryptography.CryptographicException ex_CryptographicException)
			{
				MessageBox.Show(
					$"Possible wrong pass due to exception: {ex_CryptographicException}"
				);
				//throw;
			}
			catch (Exception ex)
			{
				throw;
			}
			finally
			{
				try
				{
					cs.Close();
				}
				catch (System.Security.Cryptography.CryptographicException ex_CryptographicException)
				{
					//MessageBox.Show(
					//	$"Possible wrong pass due to exception: {ex_CryptographicException}"
					//);
					//throw;
				}
				catch (Exception ex)
				{
					throw;
				}
				finally
				{
					fsOut.Close();
					fsCrypt.Close();
				}

			}

		}
		public static ParentDoc _Decrypt(string inputFile, string password)
		{
			var parentDoc = nilnul.fs.address_.spear_.ParentDoc.Parse(inputFile);

			string newDoc;
			if (
				nilnul.fs._address.doc_._exted.ext.Eq.Singleton.eq(
					nilnul.fs.address_.spear._DocExtX.Ext(parentDoc)
					,
					Ext
				)
			)
			{
				newDoc = nilnul.fs.address_.spear._DocMainX.Main(parentDoc).ToString();


			}
			else
			{
				newDoc = parentDoc.doc.ToString() + ".decrypted";
			}
			var target = new nilnul.fs.address_.spear_.ParentDoc(
				parentDoc.parent
				,
				new nilnul.fs.folder.denote_.MainVered(parentDoc.parent).next_ofDoc(newDoc
				)
			);

			_Decrypt(
				parentDoc, password, target
			);
			return target;
		}

		public static void _Decrypt(SpearI parentDoc, string password, SpearI targetDoc)
		{
			_Decrypt(parentDoc.ToString(), password, targetDoc.ToString());
		}

	}
}
