namespace nilnul._crypt
{
	/// <summary>
	/// a one way lock. it would not be unlocked. but we can lock it again.
	/// given a constant natual number:n
	///		convert a txt to a txt of length n; the result can be taken as an address of memory/stroage
	///	a hash is good if it is:
	///		-) nonreversable
	///		-) the result is randomly|evenly distributed to avoid conflict.
	///			each char of input is converted to the result in a random manner
	///		-) independent; a bit change will change the result drastically.
	///		-) fast
	///		
	/// </summary>
	/// <remarks>
	/// hash is used for:
	///		signature
	/// </remarks>
	/// alias:
	///		digest
	///		hash
	public interface IHash { }
}
