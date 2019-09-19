using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using taskApi.Services.Interface;
using taskApi.ViewModel;

namespace taskApi.Controllers
{
    [Route("api/[controller]")]
    public class TaskController: Controller
    {

        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet("[action]")]
        public Task<IEnumerable<TaskViewModel>> GetAll()
        {
            var list = _taskService.getAll();
            return Task.FromResult(list);
        }

        [HttpGet("[action]/{id}")]
        public Task<TaskViewModel> FindById(int id)
        {
            var viewModel = _taskService.findViewModelById(id);
            return Task.FromResult(viewModel);
        }

        [HttpPost("[action]")]
        public Task<HttpResponseMessage> Save([FromBody]TaskViewModel model)
        {
            if (model.Id == 0)
            {
                _taskService.Create(model);
            }
            else
            {
                _taskService.Update(model);
            }
            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK));
        }

        [HttpDelete("[action]/{id}")]
        public Task<HttpResponseMessage> Delete(int id)
        {
            _taskService.Delete(id);
            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK));;
        }
    }
}