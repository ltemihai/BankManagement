using System;
using System.Data;
using BusinessLayer.Model;

namespace BusinessLayer.DataAccesLayer
{
    public abstract class GenericDataGateway<TEntity> where TEntity : Entity
    {
        public abstract TEntity Insert(TEntity entity);

        public abstract TEntity Select(TEntity entity);

        public abstract TEntity Update(TEntity entity);

        public abstract TEntity Delete(TEntity entity);

        public abstract DataTable Find(TEntity entity);
       
    }
}
