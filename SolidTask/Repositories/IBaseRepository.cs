﻿namespace SolidTask.Repositories;

public interface IBaseRepository<TEntity> where TEntity : class
{
    public void Add(TEntity entity);
    public IEnumerable<TEntity> All { get; }
}
