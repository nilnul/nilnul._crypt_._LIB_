using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.crypt_.asym._cert
{
	/// <summary>
	/// 服务器的证书由 CA 机构认证并签名的。而 CA 机构的证书一般都会预存在浏览器里面。
	///
	/// 任何人都可以为任何域名生成证书。然而，你的浏览器却并不认这些证书。它只相信少数几个机构颁发的证书，这些机构就是证书颁发机构。因此只有这些机构才有权颁发证书，这些证书可以告诉全世界他们已经对你进行了审查，确认了你是该域名的拥有者和管理者。
	/// And a browser will ask user whether they would trust a CA.
	/// </summary>
	/// alias:
	///		Ca
	class Auth
	{
	}
}
