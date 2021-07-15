using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IBaseRepository <Entity> where Entity: class
    {
        Task<Entity> Add(Entity entity);
        Task<bool> Update(Entity entity);
        Entity Get(int id);
        Task<bool> Delete(int id);
        IEnumerable<Entity> GetAll();

    }
}
