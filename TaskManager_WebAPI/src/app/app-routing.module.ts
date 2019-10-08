import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AddTaskComponent } from './Task/add-task/add-task.component';
import { ViewTaskComponent } from './Task/view-task/view-task.component';
import { EditTaskComponent } from './Task/edit-task/edit-task.component';

const routes: Routes = [
  //Default path will redirect to Add Component
  
  {path:'AddTask', component:AddTaskComponent},
  {path:'ViewTask', component:ViewTaskComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
