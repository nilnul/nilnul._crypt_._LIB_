﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.comm_.pub.pass.concile_
{
	/*
	 * https://blog.csdn.net/fw0124/article/details/8462373
	 * by fw0124
	迪菲－赫尔曼密钥交换（Diffie–Hellman key exchange，简称“D–H”） 是一种安全协议。
它可以让双方在完全没有对方任何预先信息的条件下通过不安全信道建立起一个密钥。这个密钥可以在后续的通讯中作为对称密钥来加密通讯内容。


(1)、算法描述
离散对数的概念：

原根：如果a是素数p的一个原根，那么数值：

            amodp，a^2 modp，…，a^(p-1) modp

 是各不相同的整数，且以某种排列方式组成了从1到p-1的所有整数。

离散对数：如果对于一个整数b和素数p的一个原根a，可以找到一个唯一的指数 i，使得：

          b =（a的i次方） modp               其中0≦i ≦p-1

                     那么指数i称为b的以a为基数的模p的离散对数。

Diffie-Hellman 算法的有效性依赖于计算离散对数的难度，其含义是：当已知大素数p和它的一个原根a后，对给定的 b，要计算 i ，被认为是很困难的，而给定 i 计算b 却相对容易。

Diffie-Hellman算法：

假如用户A和用户B希望交换一个密钥。

取素数p和整数a，a是p的一个原根，公开a和p。

A选择随机数XA<p，并计算YA=a^XA mod p。

B选择随机数XB<p，并计算YB=a^XB mod p。

每一方都将X保密而将Y公开让另一方得到。

A计算密钥的方式是：K=(YB) ^XA modp

B计算密钥的方式是：K=(YA) ^XB modp

证明：

                     (YB)^ XA mod p = (a^XB modp)^ XA mod p

                         = (a^XB)^ XA mod p = (a^XA) ^XB mod p    (<-- 密钥即为 a^(XA*XB) mod p)

                         =(a^XA modp)^ XB mod p= (YA) ^XB mod p

由于XA和XB是保密的，而第三方只有p、a、YB、YA可以利用，只有通过取离散对数来确定密钥，但对于大的素数p，计算离散对数是十分困难的。

例子：

假如用户Alice和用户Bob希望交换一个密钥。

取一个素数p =97和97的一个原根a=5。

Alice和Bob分别选择秘密密钥XA=36和XB=58，并计算各自的公开密钥：

YA=a^XA mod p=5^36 mod 97=50

YB=a^XB mod p=5^58 mod 97=44

Alice和Bob交换了公开密钥之后，计算共享密钥如下：

Alice：K=(YB) ^XA mod p=44^36 mod 97=75

Bob：K=(YA) ^XB mod p=50^58 mod 97=75 

(2)、安全性
当然，为了使这个例子变得安全，必须使用非常大的XA, XB 以及p， 否则可以实验所有的可能取值。(总共有最多97个这样的值, 就算XA和XB很大也无济于事)。
如果 p 是一个至少 300 位的质数，并且XA和XB至少有100位长， 那么即使使用全人类所有的计算资源和当今最好的算法也不可能从a, p和a^(XA*XB) mod p 中计算出 XA*XB。
这个问题就是著名的离散对数问题。注意g则不需要很大, 并且在一般的实践中通常是2或者5。
在最初的描述中，迪菲－赫尔曼密钥交换本身并没有提供通讯双方的身份验证服务，因此它很容易受到中间人攻击。
一个中间人在信道的中央进行两次迪菲－赫尔曼密钥交换，一次和Alice另一次和Bob，就能够成功的向Alice假装自己是Bob，反之亦然。
而攻击者可以解密（读取和存储）任何一个人的信息并重新加密信息，然后传递给另一个人。因此通常都需要一个能够验证通讯双方身份的机制来防止这类攻击。
有很多种安全身份验证解决方案使用到了迪菲－赫尔曼密钥交换。例如当Alice和Bob共有一个公钥基础设施时，他们可以将他们的返回密钥进行签名。
	 */

	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		dhke
	///			,dh key exchange
	class DiffieHellman
	{
	}
}
