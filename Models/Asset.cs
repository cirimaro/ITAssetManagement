using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ITAssetManagement.Models
{
    public class AssetCategory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Asset> Assets { get; set; }
    }

    public class Asset
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AssetCategoryId { get; set; }
        public virtual AssetCategory AssetCategory { get; set; }
    }
}