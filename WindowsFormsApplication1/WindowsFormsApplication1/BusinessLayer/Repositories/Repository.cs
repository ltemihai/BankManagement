using System;
using System.Data;
using BusinessLayer.DataAccesLayer;
using BusinessLayer.Model;

namespace BusinessLayer.Repositories
{
    public class Repository<TDataGateway, TEntity> where TDataGateway : GenericDataGateway<TEntity>, new() where TEntity : Entity
    {

        private TDataGateway dataGateway;

        public Repository()
        {
            this.dataGateway = new TDataGateway();
        }

        public TEntity Insert(TEntity entity)
        {
            return dataGateway.Insert(entity);
        }

        public TEntity Select(TEntity entity)
        {
             return dataGateway.Select(entity);
        }

        public TEntity Delete(TEntity entity)
        {
            return dataGateway.Delete(entity);
        }

        public DataTable Find(TEntity entity)
        {
            return dataGateway.Find(entity);
        }

        public TEntity Update(TEntity entity)
        {
            return dataGateway.Update(entity);
        }
    }
}
