using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.crypt_
{

	/*同态加密 Homomorphic Encryption 简介
                
                    
                                            首先，同态加密不是某种特定的加密算法，而是一种加密形式。
同态加密允许人们对密文进行特定形式的代数运算得到仍然是加密的结果，将其解密所得到的结果与对明文进行同样的运算结果一样。
换言之，这项技术令人们可以在加密的数据中进行诸如检索、比较等操作，得出正确的结果，而在整个处理过程中无需对数据进行解密。其意义在于，真正从根本上解决将数据及其操作委托给第三方时的保密问题，例如对于各种云计算的应用。这一直是密码学领域的一个重要课题。
同态分类
a) 如果满足 f(A)+f(B)=f(A+B)， 我们将这种加密函数叫做加法同态
b) 如果满足 f(A)×f(B)=f(A×B)， 我们将这种加密函数叫做乘法同态。
如果一个加密函数f只满足加法同态，就只能进行加减法运算；
如果一个加密函数f只满足乘法同态，就只能进行乘除法运算;
全同态加密算法 Full Homomorphic Encryption
如果一个加密函数同时满足加法同态和乘法同态，称为全同态加密。那么可以使用这个加密函数完成各种加密后的运算(加减乘除、多项式求值、指数、对数、三角函数)。
第一个满足加法和乘法同态的同态加密方法：2009年9月克雷格·金特里（Craig Gentry）的论文Fully Homomorphic Encryption Using Ideal Lattices从数学上提出了“全同态加密”的可行方法，即可以在不解密的条件下对加密数据进行任何可以在明文上进行的运算，使这项技术获取了决定性的突破。
同态加密举例
RSA 算法——乘法同态。
Elgamal 算法——乘法同态。
Paillier 算法——加法同态。
Gentry算法——全同态。
————————————————
版权声明：本文为CSDN博主「Loy_Fan」的原创文章，遵循CC 4.0 BY-SA版权协议，转载请附上原文出处链接及本声明。
原文链接：https://blog.csdn.net/weixin_43318626/java/article/details/89977202*/
	class Homomorphic
	{
	}
}
