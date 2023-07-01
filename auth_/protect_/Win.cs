using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.crypt_.protect_
{

	/*The Data Protection API (DPAPI) is an API provided by Windows to encrypt and decrypt data using the user or machine credentials. If you go with this method, you will have to handle where you store the protected data. You can store it in a file for instance. The framework exposes this API through System.Security.Cryptography.ProtectedData. There are 2 static methods: Protect and Unprotect.

var entropy = new byte[] { 0, 1, 2, 3 };
var secret = Encoding.UTF8.GetBytes("Pa$$w0rd");

// Encrypt the data
byte[] protectedData = ProtectedData.Protect(secret, entropy, DataProtectionScope.CurrentUser);

// Encrypt the data
try
{
    byte[] clearData = ProtectedData.Unprotect(protectedData, entropy, DataProtectionScope.CurrentUser);
    string decryptedPassord = Encoding.UTF8.GetString(clearData);
}
catch (CryptographicException)
{
    // The entropy is different from the one used for encryption
    // The data was not encrypted by the current user (scope == CurrentUser)
    // The data was not encrypted on this machine (scope == LocalMachine)
}
Any application running with the current user can decrypt the data protected using this API. So, optional entropy is a way to prevent other applications from decrypting the data protected by your application. They'll have to know the entropy vector of your application. This means they need to decompile the application. While this is possible in .NET, it makes it a little more complex. This is why you should use an entropy for your application.*/
	//class Win
	//{
	//}
}
