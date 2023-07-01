using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.comm_.pub.pass.concile_.dh
{
	/*
	 * 
	 * https://www.mysmth.net/nForum/#!article/Programming/193382?p=6
	 * by gloop:
	 * 
假设Alice拿的数是i，Bob拿的数是j。公开一个大素数p和其一个元根g。Alice生成一个随机数a不公开，Bob生成一个随机数b不公开。Alice计算
x = g^(ia) mod p
给Bob。Bob计算
y = x^b mod p = g^(iab) mod p 以及 z = g^(jb) mod p
给Alice。 Alice验算 z^a mod p 是否等于 y。等于则说明 i=j。
  
这里利用了幂运算可交换，即先做a次方再做b次方和先做b次方再做a次方是一回事。其他可交换的加密算法同样可行。



	but, by @leadu

	此题0知识证明的方法可能性有很多，dh变种这个方向是可以的，但你这个方法不对
Alice计算k=z^ia  mod p = g^(ijab) mod p
已知y = g^(iab) mod p，j取值0-9，根据k枚举一下就能算出j来
  
dh有抗攻击的带psk的变种，都是带hash的
	 */
	class YaoMillionairProblem
	{
	}
}
