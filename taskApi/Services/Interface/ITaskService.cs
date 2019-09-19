using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using taskApi.Models;
using taskApi.ViewModel;

namespace taskApi.Services.Interface
{
    public interface ITaskService
    {
        IEnumerable<TaskViewModel> getAll();
        IEnumerable<TaskViewModel> findByPredicate(Expression<Func<Task, bool>> predicate);
        TaskViewModel findViewModelById(int id);
        Task findById(int id);
        void Create(TaskViewModel viewModel);
        void Update(TaskViewModel viewModel);
        void Delete(int id);
    }
}