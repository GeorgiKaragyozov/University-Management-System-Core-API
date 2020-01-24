using System.Collections.Generic;

namespace University_Management_System_API.DataAccess.DataAccessObject.Common
{
    public interface IBaseDao<TEntity, TPK>
    {
        TEntity Save(TEntity entity);
        List<TEntity> Save(List<TEntity> entity);

        TEntity Update(TEntity entity);
        List<TEntity> Update(List<TEntity> entity);

        void Delete(TPK id);
        void Delete(TEntity entity);
        void Delete(List<TPK> idList);

        List<TEntity> Find();
        TEntity Find(TPK id);
        TEntity FindByName(string name);
        TEntity FindByCode(string code);
        List<TEntity> Find(string field, string value);
    }
}
