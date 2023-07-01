using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.crypt_.asym.cert
{
	/// <summary>
	/// who is the owner of the public key of the issuer of a cert ? Is the issuer trustable?
	/// We need to get the cert of the issuer.
	///
	/// This process is repeated until we reach the end: a self signed cert where the subject and the issuer is the same.
	///
	/// This is the root CA, which is well-known, and builtin by Os, browser, etc.
	/// </summary>
	class IChain
	{
	}
}
