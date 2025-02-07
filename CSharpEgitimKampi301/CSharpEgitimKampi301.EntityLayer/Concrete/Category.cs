using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }
    }
}




// Class içine doğrudan tanımlanan Field
// int x;
// Class içine {get; set;} şeklinde tanımlanırsa Property
// public int y { get; set; }
// Method içinde tanımlanırsa değişken
/*
  void test(){
    int z;
  }
 */

