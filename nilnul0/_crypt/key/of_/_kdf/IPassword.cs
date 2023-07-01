using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.crypt_._sym._key
{
	/// <summary>
	/// a human friendly password.
	/// As human might use insecure passwords, we may need:
	///		1) require the user to use number, capital letters, lowerletters, and puncuations;
	///		2) we would then derive a key from the password, by  hasing and salting;
	/// </summary>
	/// <remarks>
	/// passwords, keys, and other crypt inputs shall not be logged into system.
	/// and they should not be saved plainly, instead they shall be hashed and salted before being saved. A passtip may be provided to help the user to retrieve the pass with fewer attempts;
	/// </remarks>
	/// alias:
	///		passphase
	///		,	often longer than password. eg: a paragraph of words, or, less commonly, an article with a few paragraphs.
	internal class IPassword
	{
	}
}
