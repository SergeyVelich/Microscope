using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveImage
{
    interface IRepository
    {
        IQueryable<Data> GetList(); // получение всех объектов
        Data Get(int id); // получение одного объекта по id
        void Create(Data item); // создание одного объекта
        void Update(Data item); // обновление одного объекта
        void Delete(int item); // удаление одного объекта
    }
}
