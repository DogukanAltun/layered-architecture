using Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    internal interface IProductService
    {
        List<Product>GetAll();
    }
}
