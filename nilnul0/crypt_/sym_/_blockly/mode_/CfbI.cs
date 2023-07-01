using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.crypt_.sym_._blockly.mode_
{
	/*with CFB mode, the encryption process is "take the most recent ciphertext block, pass it through the block cipher, and then exclusive-or that with the plaintext block to generate the next ciphertext block". As for the IV, that's used as "the most recent ciphertext block" when encrypting the first plaintext block (where you don't have a most recent ciphertext block yet).
	 * 
	 As to the relationship between CBC and CFB; well, they both perform the same general process, they both take iteratively exclusive-or in the next block of plaintext, and then run that through the block cipher. How they differ is where they pull the ciphertext from; 
		CBC pulls it after we run the internal state through the block cipher, 
		CFB pulls it after we compute the exclusive-or.
		 */
	/// <summary>
	/// cipher feedback mode
	/// </summary>
	public interface CfbI
	{
	}
}
