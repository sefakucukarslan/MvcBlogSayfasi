using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    //where T : class
    //T bir class olmalı diye şart koşar
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        Context c = new Context();

        //T değerine karşılık gelecek sınıfı nasıl bulacaz ?
        DbSet<T> _object;

        //Burada Constructor kullanarak T değerine gelecek sınıfı göndericez.
        //Context'e bağlı olarak gönderilen T değeri
        public GenericRepository()
        {
            _object = c.Set<T>();
        }
        public void Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        //SingleOrDefault = bir dizi de veya liste de sadece 1 tane değer geriye döndürmek için kullanılan Entitify Framework
        //LINQ metodu'dur.
        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public void Insert(T p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            //filter'dan gelen değere göre bize listeleme yapacak.
            //Where EntityFramework'ün komutudur. Şart koşulmasını sağlar.
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            c.SaveChanges();
        }
    }
}
