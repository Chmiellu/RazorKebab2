using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace RazorKebab.Models
{

	public class KebabOrder
	{
        //public int Id { get; set; }
        [Key]
		public string KebabName { get; set; }
		public float BasePrice { get; set; }

	}
}
