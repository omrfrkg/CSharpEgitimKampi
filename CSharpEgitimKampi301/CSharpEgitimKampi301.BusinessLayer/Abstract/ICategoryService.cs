using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampi301.EntityLayer.Concrete;

namespace CSharpEgitimKampi301.BusinessLayer.Abstract
{
    // Category üzerine gel -> ctrl + . -> Add reference to 'CSharpEgitimKampi301.EntityLayer'
    public interface ICategoryService : IGenericService<Category>
    {
    }
}
