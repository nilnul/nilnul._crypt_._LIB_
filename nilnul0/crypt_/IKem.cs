namespace nilnul.crypt_
{
	///cryptobook.nakov.com/encryption-symmetric-and-asymmetric
	/// <summary>
	/// For encrypting longer messages (e.g. PDF documents) usually a public-key encryption scheme (also known as hybrid encryption scheme) is used, which combines symmetric and asymmetric encryption like this:
	/// For the encryption a random symmetric key sk is generated, the message is symmetrically encrypted by sk, then sk is asymmetrically encrypted using the recipient's public key.
	/// For decryption, first the sk key is asymmetrically decrypted using the recipient's private key, then the ciphertext is decrypted symmetrically using sk.
	/// The above process is known as : encapsulate an asymmetrically-encrypted random (ephemeral) symmetric key and use symmetric algorithm for the data encryption.
	/// </summary>
	interface IKyeEncapsulationMechanism { }
}
