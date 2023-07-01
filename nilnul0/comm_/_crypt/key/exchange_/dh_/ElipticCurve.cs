using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.comm_.pub.pass.concile_
{
	/*
	 * 
该方法主要采用Diffie-Hellman密钥交换算法，使用非对称密钥进行对称加解密。下面是获取共享对称密钥的过程：

（1）Alice向Bob发送点G。点G被Eve知道也没关系。

（2）Alice生成随机数a。这个数没有必要告诉Bob，也不能让Eve知道。将a称为Alice的私钥。

（3）Bob生成随机数b。这个数没有必要告诉Alice，也不能让Eve知道。将b称为Bob的私钥。

（4）Alice向Bob发送aG。点aG被Eve知道也没有关系，他是Alice的公钥。

（5）Bob向Alice发送bG。点bG被Eve知道也没有关系，他是Bob的公钥。

（6）Alice对Bob发送的点bG计算其在椭圆曲线上a倍的点。Alice在椭圆曲线上计算a(bG)=abG，它就是Alice和Bob的共享密钥。

（7）Bob对Alice发送的点aG计算其在椭圆曲线上b倍的点。Bob在椭圆曲线上计算b(aG)=abG，它就是Alice和Bob的共享密钥。	 */
	class EliptiCurve
	{
	}


}
