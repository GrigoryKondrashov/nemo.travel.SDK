﻿using System.Runtime.Serialization;

namespace AviaEntities.v1_1.BookFlight.ResponseElements
{
	/// <summary>
	/// Информация о забронированном месте
	/// </summary>
	[DataContract(Namespace = "http://nemo-ibe.com/Avia")]
	public class BookedSeat
	{
		/// <summary>
		/// Номер места
		/// </summary>
		[DataMember(IsRequired = true, Order = 0)]
		public string Number { get; set; }

		/// <summary>
		/// Характеристика места
		/// </summary>
		[DataMember(IsRequired = false, Order = 1)]
		public string Characteristic { get; set; }

		/// <summary>
		/// Индикатор места для курящих
		/// </summary>
		[DataMember(IsRequired = false, Order = 2)]
		public string SmokingPreference { get; set; }

		/// <summary>
		/// Номер сегмента, для которого забронированно данное место
		/// </summary>
		[DataMember(IsRequired = true, Order = 3)]
		public int SegmentNumber { get; set; }
	}
}