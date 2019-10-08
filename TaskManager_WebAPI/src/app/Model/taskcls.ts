export class Taskcls {
    Task_Id:number=0;
    ParentId!:number;    
    TaskName:string="";            
    StartDate:string=new Date().toISOString().split('T')[0];
    EndDate:string=new Date().toISOString().split('T')[0];
    task_priority:number=0;        
}
export class DropdownList
{
    value: number;
    label: string;
}
