﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GeneralEntities.OrderContent
{
	[CollectionDataContract(Namespace = "http://nemo-ibe.com/STL", ItemName = "Transaction")]
	public class PaymentTransactionList : List<PaymentTransaction>
	{
	}
}