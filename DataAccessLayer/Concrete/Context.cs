using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    //Context sınıfı veritabanına tabloları yansıtır.
    public class Context : DbContext //
    {
        public DbSet<About> Abouts { get; set; } 
        //DbSet<>İçerisinde ki About Entity katmanında onu buraya eklemek için Entity katmanını bu katmana yani DataAccessLayer'a 
        //Referans etmemiz gerek Bunuda DataAccessLayer'a sağ tık Add e tıkla.Reference tıkla Projects sekmesinden EntityLayer'ı seç
        //About ve Abouts arasında ki fark = About benim projemin içinde yer alan sınıfın ismi,Abouts ise Sql de veritabanımızda tablomuzda ki ismi
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Message> Messages { get; set; }

    }
}
