﻿using System;
using Core.Entities;

namespace Entities.DTOs
{
    public class WholesaleInvoiceDto:IDto
    {
        public int Id { get; set; }
        public int ModelType { get; set; }
        public string CustomerCode { get; set; }
        public int CompanyCode { get; set; }
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
        public Guid SubCurrAccID { get; set; }
        public string Description { get; set; }
        //
        public int LinesId { get; set; }
        public string ColorCode { get; set; }
        public string ItemCode { get; set; }
        public string ItemDim1Code { get; set; }
        public string UsedBarcode { get; set; }
        public Double Qty1 { get; set; }
        public Double LDisRate1 { get; set; }
        public string LineDescription { get; set; }
        public decimal PriceVI { get; set; }
        //
        public int SumLinesId { get; set; }
        public string LotBarcode { get; set; }
        public Double SumLinesQty1 { get; set; }
        //
        public int SalesViaInternetInfoId { get; set; }
        public string SalesURL { get; set; }
        public byte PaymentTypeCode { get; set; }
        public string PaymentTypeDescription { get; set; }
        public string PaymentAgent { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime SendDate { get; set; }
        //
        public int DiscountsId { set; get; }
        public string DiscountTypeCode { get; set; }
        public Double Value { get; set; }
        public byte DiscountReasonCode { get; set; }
        public bool IsPercentage { get; set; }
        //
        public int PaymentsId { set; get; }
        public byte PaymentType { get; set; }
        public string Code { get; set; }
        public string CreditCardTypeCode { get; set; }
        public byte InstallmentCount { get; set; }
        public decimal Amount { get; set; }
    }
}