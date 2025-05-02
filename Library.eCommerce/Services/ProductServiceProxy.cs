using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.eCommerce.Models;



namespace Library.eCommerce.Services;

     public class ProductServiceProxy
    {
        private ProductServiceProxy()
        {
<<<<<<< Updated upstream

        }
        private static ProductServiceProxy? instance = null;
=======
            Products = new List<Product?>
            {
                new Product { Id = 1, Name = "Product 1" },
                new Product { Id = 2, Name = "Product 2" },
                new Product { Id = 3, Name = "Product 3" },
            };
        }
        private int lastKey
        {
            get
            {
                if(!Products.Any())
                {
                    return 0;
                }
                return Products.Select(p => p?.Id ?? 0 ).Max();
            }
        }
        private static ProductServiceProxy? instance;
>>>>>>> Stashed changes
        private static object instanceLock = new object();
        public static ProductServiceProxy Current
        {
            get
            {
                lock(instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductServiceProxy();
                    }
                }
                
                return instance;
            }
        }
<<<<<<< Updated upstream
        private List<Product?> list = new List<Product?>();
        
        public List<Product?> Products => list;
      
    } 
=======
        public List<Product?> Products { get;  private set; }
        
  

        public Product AddorUpdate(Product product)
        {
            if(product.Id==0)
            {
                product.Id = lastKey +1;
                Products.Add(product);
            }
            
            return product;
        } 

        public Product Delete(int id)
        {
            if(id == 0)
            {
                return null;
            }
            Product? product= Products.FirstOrDefault(p => p?.Id == id);
            Products.Remove(product);

            return product;
        }
        
    }
>>>>>>> Stashed changes

    


    
    
