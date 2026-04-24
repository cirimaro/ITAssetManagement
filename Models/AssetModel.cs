using System;

namespace ITAssetManagement.Models
{
    public class AssetModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime AcquisitionDate { get; set; }
        public string Status { get; set; }
    }
}