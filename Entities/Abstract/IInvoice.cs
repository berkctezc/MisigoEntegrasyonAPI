﻿using System;
using Core.Entities;

namespace Entities.Abstract
{
    public interface IInvoice:IEntity
    {
        public int Id { get; set; }
        public int ModelType { get; set; }
        public string CustomerCode { get; set; }
        public string OfficeCode { get; set; }
        public string WareHouseCode { get; set; }
        public string DeliveryCompanyCode { get; set; }
        public string ShipmentMethodCode { get; set; }
        public DateTime InvoiceDate { set; get; }
        public string Series { get; set; }
        public int SeriesNumber { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsReturn { get; set; }
        public bool IsSalesViaInternet { get; set; }
        public string Description { get; set; }
        public int LinesId { get; set; }
        public int SumLinesId { get; set; }
        public int SalesViaInternetInfoId { get; set; }
        public int DiscountsId { set; get; }
        public int PaymentsId { set; get; }
    }
}
