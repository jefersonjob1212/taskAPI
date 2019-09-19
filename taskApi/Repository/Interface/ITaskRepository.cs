using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using taskApi.Generics.Repository.Interface;
using taskApi.Models;

namespace taskApi.Repository.Interface
{
    public interface ITaskRepository : IRepository<Task>
    {
    }
}