using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueOnion.APPLICATION.Repositories;
using TrueOnion.DOMAIN.Entities.Common;

namespace TrueOnion.APPLICATION.UnitOfWork
{
    /// <summary>
    /// Oluşturacağımız UnitofWork sınıfının içermesi gereken metotlara ait imzaları bu kısımda tanımlayacağız.
    /// UnitofWork sınıfını türetirken doğrudan değil bu interface'i kullanarak türeteceğiz Böylece dependency injection yaparak
    /// kodumuza esneklik kazandırmış olacağız.
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Gerektiğinde repository instance oluşturmak için kullanılacak.
        /// </summary>
        /// <typeparam name="T">Hangi entity miz için repository oluşmasını istiyorsak o sınıfı gönderiyoruz</typeparam>
        /// <returns></returns>
        IGenericRepository<T> GetRepository<T>() where T : BaseEntity;

        bool BeginNewTransaction();

        bool RollBackTransaction();

        /// <summary>
        /// Veritabanında işlemlerin yapılması emrini veren kısım olacak
        /// Repository içerisinde kuyruğa aldığımız tüm işlemler bu metot çalıştırıldığı anda sırası ile veritabanında değişikliğe uğrayacak
        /// </summary>
        /// <returns></returns>
        int SaveChanges(bool ensureAutoHistory);
    }
}
