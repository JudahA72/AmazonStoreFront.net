using System;
using System.Net.Http.Headers;
using Library.eCommerce.Models;
using Library.eCommerce.Services;

namespace Maui.eCommerce.ViewModels;

public class InventoryManagementViewModel
{
    public List<Product?> Products
    {
        get
        {
            return ProductServiceProxy.Current.Products;
        }
    }
     
}
