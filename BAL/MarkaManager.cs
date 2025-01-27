using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class MarkaManager
    {
        DatabaseContext context =new DatabaseContext();

        public List<Marka> GetAll()//veritabanında ki tüm markaları listleler döndürür.
        {
            return context.Markalar.ToList();
        }

        public Marka Get(int id)//sadece id si gösterilen markayı döndürür
        {
            return context.Markalar.Find(id);
                
        }
        /// <summary>
        /// MARKA EKLEME METHODU
        /// </summary>
        /// <param name="marka"></param>
        /// <returns></returns>
        public int Add(Marka marka)
        {
            context.Markalar.Add(marka);
            return context.SaveChanges();

        }
        /// <summary>
        /// MARKA GÜNCELLEME METHODU
        /// </summary>
        /// <param name="marka"></param>
        /// <returns></returns>
        public int Update(Marka marka)
        {
            context.Markalar.AddOrUpdate(marka);
            return context.SaveChanges();

        }
        /// <summary>
        /// MARKA SİLME METHODU
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int Delete(int id)
        {
            context.Markalar.Remove(Get(id));
            return context.SaveChanges();

        }
    }
}
