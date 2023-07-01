using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.crypt_
{
	/// <summary>
	/// hash is a  cryption that is:
	///		1) lossy, as range is narrower than domain
	///		2) one-way, as it's not invertible due to its lossiness and its enegmatic algorithm.
	/// </summary>
	/// <remarks>
	/// hash is:
	///		1) a function, which is:
	///			1.1) hard to invert
	///			1.2) fast
	///			1.3) fixed lenght of output; varied length of input
	///			1.4) evenly random. ie, given an input, the output is evenly distributed across all the range. So confliction is practically impossible.
	///			1.5) indepently random. ie, the output of one value gives no hint/info of the output of the other value. Specificly, even change only one bit, the outputs are still indepent and are not correlated, and share no adacency that is that small implied by one bit. In fact, changes all bits, or change 1 bit, the new output's distance from the original output is statistically the same.
	///	alias:
	///		hash
	///		digest
	/// </remarks>
	interface IHash
	{
	}
}
