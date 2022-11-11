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

        //Örneğin  ID'si 5 olan yazar dediğimiz zaman aşağıda ki gibi List Metodunu kullanmamıza gerek yok aşağıda ki metodu kullanırız.
        //Tek değer gönderir.
        T Get(Expression<Func<T, bool>> filter);

        //Silme işlemi
        void Delete(T p);
        //Güncelleme işlemi
        void Update(T p);

        //Şartlı listeleme
        //yazarlar içerisinde ismi Sefa olan yazarları bu metotla buluruz.
        List<T> List(Expression<Func<T, bool>> filter);
    }
}
