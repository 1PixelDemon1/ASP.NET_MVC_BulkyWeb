using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulky.Models
{
	public class Category
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[MaxLength(30)] // Max is 30 characters
		[DisplayName("Category Name")]
		public string Name { get; set; }
		[DisplayName("Display Order")]
		[Range(1,100, ErrorMessage = "Display order must be between 1 and 100")] // From 1 to 100 value
		public int DisplayOrder { get; set; }
	}
}

