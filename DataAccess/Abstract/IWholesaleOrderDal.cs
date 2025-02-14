﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IWholesaleOrderDal:IEntityRepository<WholesaleOrder>
    {
        List<WholesaleOrderDto> GetWholesaleOrderDetails(Expression<Func<WholesaleOrder, bool>> filter = null);
        WholesaleOrderDto GetWholesaleOrderDetailsById(Expression<Func<WholesaleOrder, bool>> filter);
    }
}