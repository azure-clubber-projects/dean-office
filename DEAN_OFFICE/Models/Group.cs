using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DEAN_OFFICE.Models
{
	public class Group : Entity
	{
		[Required]
		[StringLength(10)]
		public string Name { get; set; }
		public int FacultyId { get; set; }

		public ICollection<Student> Students { get; set; }
		
	}
}
