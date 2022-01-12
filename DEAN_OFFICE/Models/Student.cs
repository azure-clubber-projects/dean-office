using System;
using System.ComponentModel.DataAnnotations;

namespace DEAN_OFFICE.Models
{
	public class Student : Entity
	{
		[Required]
		[StringLength(60)]
		public string Firstname { get; set; }

		[Required]
		[StringLength(60)]
		public string Middlename { get; set; }

		[Required]
		[StringLength(60)]
		public string Lastname { get; set; }

		[Required]
		public DateTime BirthDate { get; set; }

		public int GroupId { get; set; }
	}
}
