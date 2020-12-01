﻿namespace ComputerPartsCatalog.Web.ViewModels.Products
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ComputerPartsCatalog.Web.Infrastructure.ValidatorAttributes;
    using Microsoft.AspNetCore.Http;

    public class AddProductInputModel
    {
        [Required]
        [MinLength(5)]
        public string Name { get; set; }

        [Required]
        [MinLength(2)]
        public string Brand { get; set; }

        [Range(typeof(decimal), "0", "79228162514264337593543950335")]
        public decimal Price { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [AllowedExtensions(new string[] { ".jpg", ".png" })]
        [MaxFileSize(5 * 1024 * 1024)]
        public IFormFile Image { get; set; }

        public IEnumerable<ProductFeatureInputModel> Features { get; set; }

        public virtual IEnumerable<KeyValuePair<string, string>> Categories { get; set; }
    }
}
