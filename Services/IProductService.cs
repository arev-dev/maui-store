using MauiStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiStore.Services
{
    internal interface IProductService
    {
        public Task<List<Product>> Get();
    }
}
