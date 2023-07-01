namespace nilnul.crypt
{
	/// <summary>
	/// a seal is like a public key; and the holder would keep and protect it, acting like a private key.
	/// </summary>
	/// <remarks>
	///Typically, public-key cryptosystems can encrypt messages of limited length only and are slower than symmetric ciphers. (cryptobook.nakov.com/encryption-symmetric-and-asymmetric)
	/// </remarks>
	interface ICertificate :crypt_.asym.ICertificate { }
}
