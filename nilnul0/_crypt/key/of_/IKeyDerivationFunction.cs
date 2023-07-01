using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul._crypt.key.of_
{
	/// <summary>
	/// generate a key from password, such that the password would be shielded from hacking;
	/// </summary>
	/// alias:
	///		hkdf
	/// alias:
	///		kdf
	public interface IKeyDerivationFunction
		:IHash
	{
	}
}
