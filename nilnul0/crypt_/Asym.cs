using nilnul.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.crypt_
{
	/*
	 public key= lock, priviate key = key.

	Asymmetric encryption is like a padlock with a key. You could give the unlocked lock to someone (the public key), they could put a message in a box and then put the lock on, and after that, only you could open the lock because you kept the key (the private key).

		Asymmetric-key cryptography is wonderful, but it has a big challenge of distributing public keys / mapping public keys to real-world identities. There are many solutions to this problem. Signal has one simple solution: trust on first use, and support out-of-band public key exchange (you verify your friends’ “safety numbers” in person). PGP has a different solution, which is web of trust. Keybase has yet another solution of social proof (along with other neat ideas). Each model has its merits; we (the instructors) like Keybase’s model.
		 */

	/// <summary>
	/// If the lock and unlock are two different things;
	/// </summary>
	/// <remarks>
	/// this is the default of <see cref="ICypher"/>;
	/// 
	/// when the encypher and decypher are the same, it's called <see cref="ISym"/>
	/// </remarks>
	/// alias:
	///		<see cref="crypt.ICerti"/>
	///			,whileas <see cref="ISym"/> is called cypher;
	public interface IAsym
		:ICrypt
	{
	}
}
