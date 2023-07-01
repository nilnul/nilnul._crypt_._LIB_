namespace nilnul._crypt.key.of_.kdf_
{
	/// <summary>
	/// Password based Kdf, where kdf means <see cref="IKeyDerivationFunction"/>;
	/// It derives key material by applying a function such as HMAC to the input password along with some salt, and repeating this process many times.
	/// </summary>
	/// <remarks>
	///It's designed to derive key material from some relatively low-entropy input, such as a password.
	///The more times the process is repeated, the more computationally expensive key derivation is: this makes it harder for an attacker to use brute-force to discover the key using a dictionary attack.
	///PBKDF2 is specified in RFC 2898.
	/// </remarks>
	interface IPbKdf2 { }
}
