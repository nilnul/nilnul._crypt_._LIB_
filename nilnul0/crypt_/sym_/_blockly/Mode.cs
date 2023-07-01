using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.crypt_.sym_._blockly
{
	///cryptobook.nakov.com/symmetric-key-ciphers/cipher-block-modes
	/// <summary>
	/// Commonly used secure block modes are CBC (Cipher Block Chaining), CTR (Counter) and GCM (Galois/Counter Mode), which require a random (unpredictable) initialization vector (IV), known also as nonce or salt at the start.
	/// </summary>
	public enum Mode
	{
		/// <summary>
		/// (Galois/Counter Mode)
		/// </summary>
		/// <remarks>
		/// The CTR and GCM encryption modes have many advantages: they are secure (no significant flaws are currently known), can encrypt data of arbitrary length without padding, can encrypt and decrypt the blocks in parallel (in multi-core CPUs) and provide random (unordered) access to the encrypted blocks, so they are suitable for encrypting crypto-wallets, documents and streaming video (where users can seek by time). GCM provides also message authentication and is the recommended choice for cipher block mode in the general case.
		/// </remarks>
		/// Note that the GCM, CTR and other block modes reveal the length of the original message. The length of the plaintext message is the same as the ciphertext length. If you want to avoid revealing the original plaintext length, you can add some random bytes to the plaintext before the encryption and remove them after decryption (this will be some kind of padding).
		Gcm
			,
		/// <summary>
		/// counter
		/// </summary>
		/// alias:
		///		ctr
		///			,counter
		Ctr
			,
		/// <summary>
		/// cipher block chaining;
		/// In some scenarios the CBC block mode might be vulnerable to the attack , so its is better to avoid the CBC mode.
		/// </summary>
		Cbc

			,

		/// <summary>
		/// cipher feedback
		/// </summary>
		Cfb
			,
		///cryptobook.nakov.com/symmetric-key-ciphers/cipher-block-modes
		/// <summary>
		/// Well-known insecure block mode is  (Electronic Codebook), which encrypts equal input blocks as equal output blocks (does not provide ). Don't use it! It may compromise the entire encryption.
		/// </summary>
		///
		[Obsolete(" Well-known insecure block mode is  (Electronic Codebook), which encrypts equal input blocks as equal output blocks (does not provide ). Don't use it! It may compromise the entire encryption.",true)]
		Ecb
	}
}
