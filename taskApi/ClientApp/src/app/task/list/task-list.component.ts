import { Component, OnInit } from '@angular/core';
import { TaskService } from "../../service/task-service.service";
import { Task } from '../../models/task';
import { Router } from '@angular/router';

@Component({
  selector: 'app-task',
  templateUrl: './task-list.component.html'
})
export class TaskListComponent implements OnInit {

  public tasks: Task[];

  constructor(private taskService: TaskService,
    private router: Router) {

  }

  ngOnInit() {
    this.taskService.getAll().subscribe(res => {
      this.tasks = res;
    });
  }

  create() {
    this.router.navigate(['./task/create']);
  }

  edit(id: number) {
    this.router.navigate(['./task/edit', id]);
  }

  delete(task: Task) {
    let index = this.tasks.indexOf(task);
    this.taskService.delete(task.id).subscribe(() => {
      this.tasks.splice(index);
    });
  }

  changeDone(task: Task) {
    task.done = !task.done;
    this.taskService.create(task).subscribe(() => {
      this.ngOnInit();
    });
  }

}
