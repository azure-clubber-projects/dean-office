using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEAN_OFFICE.Models
{
	public class Faculty : Entity
	{
		[Required]
		[StringLength(50)]
		public string Name { get; set; }

		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public DateTime EstatedAt { get; set; }

		public ICollection<Group> Groups { get; set; }
	}
}
