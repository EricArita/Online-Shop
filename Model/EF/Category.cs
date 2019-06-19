using System;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.Xml.Serialization;

namespace Model.EF
{

    [Table("Category")]
    public partial class Category
    {
        public long ID { get; set; }

        [StringLength(250)]
        [Display(Name = "Category_Name", ResourceType = typeof(StaticResources.Resources))]
        [Required(ErrorMessageResourceName = "Category_RequiredName", ErrorMessageResourceType = typeof(StaticResources.Resources))]
        public string Name { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(250)]
        [Display(Name = "Category_MetaTitle", ResourceType = typeof(StaticResources.Resources))]
        public string MetaTitle { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        [XmlAttribute]
        public string MoreImages { get; set; }

        public decimal Price { get; set; }

        public decimal PromotionPrice { get; set; }

        public bool IncludedVAT { get; set; }

        public int Quantity { get; set; }

        [Display(Name = "Category_ParentId", ResourceType = typeof(StaticResources.Resources))]
        public long? CategoryParentID { get; set; }

        public string Detail { get; set; }

        [StringLength(250)]
        [Display(Name = "Category_SeoTitle", ResourceType = typeof(StaticResources.Resources))]
        public string SeoTitle { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        [StringLength(250)]
        [Display(Name = "Category_Metakeyword", ResourceType = typeof(StaticResources.Resources))]
        public string MetaKeywords { get; set; }

        [StringLength(250)]
        [Display(Name = "Category_MetaDescription", ResourceType = typeof(StaticResources.Resources))]
        public string MetaDescriptions { get; set; }

        [Display(Name = "Category_Status", ResourceType = typeof(StaticResources.Resources))]
        public bool Status { get; set; }

        [Display(Name = "Category_ShowOnHome", ResourceType = typeof(StaticResources.Resources))]
        public bool? ShowOnHome { get; set; }

        public DateTime? TopHot { set; get; }

        public int? ViewCount { get; set; }
    }
}
