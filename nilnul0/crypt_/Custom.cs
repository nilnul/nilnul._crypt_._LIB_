using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.crypt_
{
/*
 * with reference to: https://www.zhihu.com/question/25539382
 一个好的加密算法真的应该是公开的——它可以接受更多人的检验。
一个好的密码系统不一定是公开的——但是它应该按照可以公开除了密码之外的一切而依旧安全来设计。
 */
/*很多时候，安全手段不是为了彻底解决安全问题，而是通过增加破坏成本的方式，将安全风险降到可控范围。*/

/// <summary>
	/// on top of well-recognized crypt, use one of our own private crytion to increase the security.
	/// the difference between Custom and Wellknown cryption algorithm is:
	///		1) the algorithm of Custom is not made public; while the algorithm of Wellknown cryption is made public, with the passwork kept secret.
	/// </summary>
	/// <remarks>
	///	any in-development algorithm, before being mature(secure) enough (but must be correct, or in other words, decryptable) for publishing, can be used as in-house algorithm;
	///	not made public, due to "security through obscurity"
	/// </remarks>
	///
	/// 
	/// alias:
	///		in house
	///		on premise
	///		vendor
	///		vnd
	/// 
	public interface ICustom
	{
		//todo: 
	}
}
