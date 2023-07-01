using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.crypt._cert
{
	/// <summary>
	/// well known, often built-in self-signed certificate of an entity. Every client knows the public key, which then cannot be forged, and knows the pub key belongs to a trusted well known entity;
	/// </summary>
	/// <remarks>
	/// Then this CA can issue certificate to others which the CA has to verify;
	/// </remarks>
	internal class IAuthorityProvider
	{
	}
}
