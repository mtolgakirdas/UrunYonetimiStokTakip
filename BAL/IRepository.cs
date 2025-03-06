using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public interface IRepository<T>//IRepository interface i Repository classmızının içinde olması gerekn metodları tanımlayacak
    {
        List<T> GetAll();//Bu Metot içerisine T parametresine Yerleştirecek class ın tüm verilerini listeleyecek
        List<T>GetAll (Expression<Func<T, bool>> expression);//where ile filtrelenebilen kayıtları getirir.
        T Get(int id);//T kısmına gönderilicek class için (urun.cs,kategori.cs..vb)aldığı Id e ait kaydı veritabanından getirecek. 
        T Find(Expression<Func<T,bool>>expression);//T kısmına gönderilecek class için bir expression yani linq filtreleme sorgusu alıp bir ya da
                                                   //daha fazla alanla filtrelenen kaydı getiri(x=>x.Id ==1)gibi
        int Add(T entity);//ekleme methodu
        int Update(T entity);//güncelleme metodu
        int Delete(int id);//silme metodu





    }
}
