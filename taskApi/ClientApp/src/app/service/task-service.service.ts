import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Task } from '../models/task';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class TaskService {

  private _baseUrl: string;
  private headersJson: HttpHeaders;

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this._baseUrl = baseUrl;
    this.headersJson = new HttpHeaders({ 'Content-Type': 'application/json' });
  }

  getAll() {
    return this.http.get<Task[]>(this._baseUrl + 'api/Task/GetAll')
      .pipe(map(res => res));
  }

  create(task: Task) {
    return this.http.post(this._baseUrl + 'api/Task/Save', JSON.stringify(task), { headers: this.headersJson })
      .pipe(map(res => res));
  }

  findTask(id: number) {
    return this.http.get<Task>(this._baseUrl + 'api/Task/FindById/' + id)
      .pipe(map(res => res));
  }

  delete(id: number) {
    return this.http.delete(this._baseUrl + 'api/Task/Delete/' + id)
      .pipe(map(res => res));
  }
}
