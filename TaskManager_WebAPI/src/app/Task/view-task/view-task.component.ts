import { Component, OnInit } from '@angular/core';
import { ViewTask } from 'src/app/Model/view-task'; 
import {Router} from '@angular/router';
import { TaskServiceService } from 'src/app/Service/task-service.service';
@Component({
  selector: 'app-view-task',
  templateUrl: './view-task.component.html',
  styleUrls: ['./view-task.component.scss']
})
export class ViewTaskComponent implements OnInit {
  public _taskService!: TaskServiceService;
  public availableTasks!:ViewTask[];
  public taskSearch:TaskSearch=new TaskSearch();


  constructor(private taskService:TaskServiceService,private router:Router) {
    this._taskService=taskService;
   }

  ngOnInit() {
    this.callService();
  }
  callService()
  {
    this._taskService.ViewAllTasks().subscribe(
      lstResults=> {
        let result:ViewTask[]=lstResults;
        console.log(this.taskSearch.TaskName);
        if (this.taskSearch.TaskName!="")
        {
          console.log('Insideif');
          result=result.filter(t=>t.TaskName.includes(this.taskSearch.TaskName));
        }
     
        result=result.filter(t =>t.task_priority >= this.taskSearch.PriorityFrom && t.task_priority <= this.taskSearch.PriorityTo);
        console.log('outsideif');
     this._taskService.ViewAllTasks().subscribe(
       lstResults =>{this.availableTasks=lstResults}
     );
        this.availableTasks=result;
        
      }

      
   
    );


    console.log('All Task ' + this.availableTasks);
  }

  endTask(taskcls: ViewTask)
  {
    this._taskService.endTask(taskcls.TASK_ID).subscribe(
      result => {
        alert('Task ended successfully...');
        for (var i=0;i<this.availableTasks.length;i++){
          if(this.availableTasks[i]=== taskcls){
          this.availableTasks.splice(i,1)  ;
          }
        }
      }
    )
  }
updateTask(task: ViewTask){
  console.log("Taskid from view" + task.TASK_ID);
  this.router.navigate(['/AddTask']  ,{queryParams: {Task_Id:task.TASK_ID } });
}
}
export class TaskSearch
{
  TaskName:string="";
  ParentName:string="";
  PriorityFrom:number=0;
  PriorityTo:number=30;
  StartDate: string=new Date().toISOString().split('T')[0];
  EndDate: string=new Date().toISOString().split('T')[0];
}