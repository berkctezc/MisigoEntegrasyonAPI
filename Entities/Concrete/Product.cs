﻿using Core.Entities;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public int ModelType { get; set; }
        public byte ItemTypeCode { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public byte ItemDimTypeCode { get; set; }
        public string UnitOfMeasureCode1 { get; set; }
        public string ItemTaxGrCode { get; set; }
        public int ProductHierarchyID { get; set; }
        public bool UsePOS { get; set; }
        public bool UseStore { get; set; }
        public bool UseInternet { get; set; }
        public int AttributesId { get; set; }
        public int VariantsId { get; set; }
    }
}
