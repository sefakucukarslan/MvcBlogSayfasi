using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        //CRUD operasyonlarını bir metot olarak tanımlayacaz.

        //Listeleme işlemi
        List<T> List();
        //Ekleme işlemi
        void Insert(T p);
        //Silme işlemi
        void Delete(T p);
        //Güncelleme işlemi
        void Update(T p);

        //Şartlı listeleme
        List<T> List(Expression<Func<T, bool>> filter);
    }
}
