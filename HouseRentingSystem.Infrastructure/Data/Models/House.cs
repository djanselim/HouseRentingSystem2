using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants;

namespace HouseRentingSystem.Infrastructure.Data.Models
{
	[Comment("House to rent")]
	public class House
	{
		[Key]
		[Comment("House Identifier")]
		public int Id { get; set; }

		[Required]
		[MaxLength(HouseTitleMaxLength)]
		[Comment("Title")]
		public string Title { get; set; } = string.Empty;

		[Required]
		[MaxLength()]
		[Comment("House address")]
		public string Address { get; set; } = string.Empty;

		[Required]
		[MaxLength(HouseDescriptionMaxLength)]
		[Comment("House description")]
		public string Description { get; set; } = string.Empty;

		[Required]
		[Comment("House image url")]
		public string ImageUrl { get; set; } = string.Empty;

		[Required]
		[Comment("Monthly Price")]
		//[Range(typeof(decimal), HouseRentingPriceMin, HouseRentingPriceMax, ConvertValueInInvariantCulture = true)]
		[Column(TypeName = "decimal(18, 2)")]
		public decimal PricePerMonth { get; set; }

		[Required]
		[Comment("Category identifier")]
		public int CategoryId { get; set; }

		[Required]
		[Comment("Agent identifier")]
		public int AgentId { get; set; }

		[Comment("User id of the renterer")]
		public string? RenterId { get; set; } = string.Empty;

		public Category Category { get; set; } = null!;

		public Agent Agent { get; set; } = null!;
	}
}
