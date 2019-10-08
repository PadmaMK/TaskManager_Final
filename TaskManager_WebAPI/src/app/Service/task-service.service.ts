import { Injectable } from '@angular/core';
import { HttpClient,HttpResponse } from '@angular/common/http';
import {observable, Observable} from 'rxjs';
import { Taskcls } from '../Model/taskcls';
import { ViewTask } from '../Model/view-task';
import {Parent} from '../Model/parent';

@Injectable({
  providedIn: 'root'
})
export class TaskServiceService {
  
BasrUrl="http://localhost:51962/api/TaskManager";
  constructor(private http:HttpClient) { }
  public ViewAllTasks():Observable<ViewTask[]>{
    return this.http.get<ViewTask[]>(this.BasrUrl+'/ReadAllTasks');
  }
  public ViewTask(taskId):Observable<ViewTask>{
    return this.http.get<ViewTask>(this.BasrUrl+'/ReadTask?taskid='+taskId);
  }
  public getALLParentTasks():Observable<Parent[]>
  {
    return this.http.get<Parent[]>(this.BasrUrl+'/GetAllParentTasks');

  }
  public addTask(task: Taskcls):Observable<any>{
    return this.http.post<any>(this.BasrUrl+'/AddTask',task);    
  }
  public updateTask(task: Taskcls):Observable<any>{
    return this.http.post<any>(this.BasrUrl+'/updateTask',task);    
  }
  public endTask(taskId:number):Observable<any>{
    return this.http.get<Taskcls[]>(this.BasrUrl+'/EndTask'+taskId);
  }
  

}
