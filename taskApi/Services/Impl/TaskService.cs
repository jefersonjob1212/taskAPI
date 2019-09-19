using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using taskApi.Models;
using taskApi.Repository.Interface;
using taskApi.Services.Interface;
using taskApi.ViewModel;

namespace taskApi.Services.Impl
{
    public class TaskService: ITaskService
    {
        private ITaskRepository _taskRepository;
        public TaskService(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public void Create(TaskViewModel viewModel)
        {
            var entity = new Task();
            entity.Descript = viewModel.Descript;
            entity.Done = viewModel.Done;
            _taskRepository.Create(entity);
            _taskRepository.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = findById(id);
            _taskRepository.Delete(entity);
            _taskRepository.SaveChanges();
        }

        public TaskViewModel findViewModelById(int id)
        {
            var entity = _taskRepository.findByPredicate(x => x.Id == id).SingleOrDefault();
            var viewModel = new TaskViewModel();
            viewModel.Id = entity.Id;
            viewModel.Descript = entity.Descript;
            viewModel.Done = entity.Done;
            return viewModel;
        }

        public Task findById(int id)
        {
            return _taskRepository.findByPredicate(x => x.Id == id).SingleOrDefault();
        }

        public IEnumerable<TaskViewModel> findByPredicate(Expression<Func<Task, bool>> predicate)
        {
            return _taskRepository
                    .findByPredicate(predicate)
                    .Select(task => new TaskViewModel{
                        Id = task.Id,
                        Descript = task.Descript,
                        Done = task.Done
                    })
                    .AsEnumerable();
        }

        public IEnumerable<TaskViewModel> getAll()
        {
            return _taskRepository.getAll().Select(task => new TaskViewModel{
                        Id = task.Id,
                        Descript = task.Descript,
                        Done = task.Done
                    }).AsEnumerable();
        }

        public void Update(TaskViewModel viewModel)
        {
            var entity = findById(viewModel.Id);
            entity.Descript = viewModel.Descript;
            entity.Done = viewModel.Done;
            _taskRepository.Update(entity);
            _taskRepository.SaveChanges();
        }
    }
}