﻿using Core.Entities;

namespace Entities.Types
{
    public class Payment:IEntity
    {
        public int Id { get; set; }
        public byte PaymentType { get; set; }
        public string Code { get; set; }
        public string CreditCardTypeCode { get; set; }
        public byte InstallmentCount { get; set; }
        public decimal Amount { get; set; }
    }
}