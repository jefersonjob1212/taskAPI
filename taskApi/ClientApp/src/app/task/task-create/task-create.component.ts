import { Component, OnInit } from '@angular/core';
import { Task } from 'src/app/models/task';
import { TaskService } from 'src/app/service/task-service.service';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-task-create',
  templateUrl: './task-create.component.html'
})
export class TaskCreateComponent implements OnInit {

  task: Task = new Task();
  title: string;

  constructor(private taskService: TaskService,
              private router: Router,
              private activatedRoute: ActivatedRoute) { }

  ngOnInit() {
    this.activatedRoute.params.subscribe(parametro=>{
      if(!parametro['id'])
      {
          this.title = 'New Task';
      }
      else
      {
          this.title = 'Edit Task';
          this.taskService.findTask(Number(parametro['id']))
            .subscribe(res => {
              this.task = <Task>res;
              console.log(this.task);
            });
      }
  });
  }

  post(){
    console.log(JSON.stringify(this.task));
    this.taskService.create(this.task).subscribe(res => {
      this.router.navigate(['./task/list']);
    });
  }

}
