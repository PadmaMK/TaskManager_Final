import { Component, OnInit } from '@angular/core';
import {Router,ActivatedRoute,Params} from '@angular/router';
import { TaskServiceService } from 'src/app/Service/task-service.service';
import { Taskcls } from 'src/app/Model/taskcls'; 
import { Parent } from 'src/app/Model/parent'; 
import { Options} from 'ng5-slider';
import { ViewTask } from 'src/app/Model/view-task'; 
import 'rxjs/add/operator/filter';
@Component({
  selector: 'app-add-task',
  templateUrl: './add-task.component.html',
  styleUrls: ['./add-task.component.scss']
})
export class AddTaskComponent implements OnInit {
public param1:string;
taskid:string;
public _taskSrvice!: TaskServiceService;
public addTask:Taskcls=new Taskcls();
public start: string=new Date().toISOString().split('T')[0];
public end: string=new Date().toISOString().split('T')[0];
public addTaskButtonName: string="Add Task";
public availableParentTasks!:Parent[];
options:Options={
  floor:0,
  ceil:30
}
  constructor(private router:Router,private route: ActivatedRoute,private taskservice:TaskServiceService) { 
   
    this._taskSrvice=taskservice;
    this.getAllParentTasks();
  }

  ngOnInit() {
  
  this.route.queryParams
  .filter(params => params.Task_Id)
  .subscribe(params => {
    console.log("parameter id=" + params.Task_Id);
    this.taskid=params.Task_Id;
    
  });
    this.getAllParentTasks();
    this.getTaskDetails();
    

    
  }
  getAllParentTasks()
  {
    this._taskSrvice.getALLParentTasks().subscribe(
    lstResults=>{this.availableParentTasks=lstResults});
  }
  getTaskDetails()
  {
    
    //let id=window.top.location.href.split("?Task_id=")[1];
  
    if (this.taskid==="0" || this.taskid === undefined)
    {
      this.addTaskButtonName="Add Task";
      this.param1="Add Task"
      return;
    }
    this._taskSrvice.ViewTask(parseInt(this.taskid)).subscribe
    (result=>{
      this.setTaskDetails(result);
      this.addTaskButtonName="Update Task"
      this.param1="Update Task";
    });
  }
private setTaskDetails(result:ViewTask)
{
  this.addTask.Task_Id=result.TASK_ID;
  this.addTask.TaskName=result.TaskName;
  this.addTask.ParentId=result.parent_id;
  this.addTask.EndDate=result.Enddate;
  this.addTask.StartDate=result.Startdate;
  this.addTask.task_priority=result.task_priority;
  this.start=result.Startdate;
  this.end=result.Enddate;
}
saveTask(){
  console.log(this.addTask);
  this._taskSrvice.addTask(this.addTask).subscribe(
    result=>{
      alert('Task saved successfully..');
      this.router.navigate(['/ViewTask']);
    }
  );
}
reset(){}
}
