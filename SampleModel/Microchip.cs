﻿using AO.DbSchema.Attributes;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Hs5.Models
{
	//[TrackChanges(IgnoreProperties = "DateModified,ModifiedBy")]
	//[TrackDeletions]
	public class Microchip : BaseTable
	{
		[Key]
		[References(typeof(Patient))]
		public int PatientId { get; set; }

		[References(typeof(MicrochipProvider))]
		public int ProviderId { get; set; }

		[MaxLength(50)]
		//[UniqueKey]
		public string Number { get; set; }

		public int? SourcePatientItemId { get; set; }
	}
}