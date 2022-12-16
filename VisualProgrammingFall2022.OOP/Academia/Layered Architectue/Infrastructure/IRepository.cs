﻿namespace StudentPortal.Repository
{
    public interface IRepository<TEntity>
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }

}
