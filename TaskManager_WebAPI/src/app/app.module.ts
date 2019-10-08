import { BrowserModule } from '@angular/platform-browser';
import { NgSelectModule } from '@ng-select/ng-select';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AddTaskComponent } from './Task/add-task/add-task.component';
import { ViewTaskComponent } from './Task/view-task/view-task.component';
import { EditTaskComponent } from './Task/edit-task/edit-task.component';
import { HttpClientModule } from "@angular/common/http";
import { TaskMenuComponent } from './task-menu/task-menu.component';
import { MenuComponent } from './Task/menu/menu.component';
import { MDBBootstrapModule } from 'angular-bootstrap-md';
import { NgModule, NO_ERRORS_SCHEMA } from '@angular/core';
import { Ng5SliderModule } from 'ng5-slider'

@NgModule({
  declarations: [
    AppComponent,
    AddTaskComponent,
    ViewTaskComponent,
    EditTaskComponent,
    TaskMenuComponent,

    MenuComponent
  ],
  imports: [
    BrowserModule,
    [NgSelectModule, FormsModule],
    MDBBootstrapModule.forRoot(),
    Ng5SliderModule,
    HttpClientModule,
    AppRoutingModule
    
  ],
  schemas: [ NO_ERRORS_SCHEMA ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
