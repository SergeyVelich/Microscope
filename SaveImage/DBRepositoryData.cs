using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveImage
{
    class DBRepositoryData : IRepository
    {
        // Получить элемент таблицы
        public Data Get(int id)
        {
            using (DBContext dbContext = new DBContext())
            {
                return dbContext.Data.Where(d => d.Id == id).Single();
            }
        }

        // Получить таблицу
        public IQueryable<Data> GetList()
        {
            using (DBContext dbContext = new DBContext())
            {
                return dbContext.Data;
            }
        }

        // Добавление одного поля в БД
        public void Create(Data entity)
        {
            using (DBContext dbContext = new DBContext())
            {
                dbContext.Data.Add(entity);

                dbContext.Entry(entity.User).State = EntityState.Unchanged;
                dbContext.Entry(entity.WorkCenter).State = EntityState.Unchanged;
                dbContext.Entry(entity.Pressform).State = EntityState.Unchanged;
                dbContext.Entry(entity.Color).State = EntityState.Unchanged;
                if (entity.Defect != null)
                    dbContext.Entry(entity.Defect).State = EntityState.Unchanged;

                dbContext.SaveChanges();
            }
        }

        // Изменение одного поля в БД
        public void Update(Data entity)
        {

        }

        // Удаление одного поля в БД
        public void Delete(int id)
        {
            using (DBContext dbContext = new DBContext())
            {
                Data dataRow = dbContext.Data.Where(d => d.Id == id).Single();
                dbContext.Data.Remove(dataRow);
                dbContext.SaveChanges();
            }
        }
    }
}
