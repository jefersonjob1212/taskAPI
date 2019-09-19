using taskApi.Generics.Repository.Impl;
using taskApi.Models;
using taskApi.Repository.Interface;

namespace taskApi.Repository.Impl
{
    public class TaskRepository : Repository<Task>, ITaskRepository
    {
        public TaskRepository(SUPERO_INTELBRASContext Context)
            : base(Context)
        {
        }
    }
}