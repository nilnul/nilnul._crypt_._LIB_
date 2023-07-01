using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.crypt.cash_.btc
{
	/*
	 The header of a block contains the Merkle tree which depends on the included transactions.
	 This includes the generation transaction, a transaction "out of nowhere" to our own address, which
		in addition to providing the miner with incentive to do the work,
		also ensures that every miner hashes a unique data set.
	*/
	class Block
	{
	}
}
