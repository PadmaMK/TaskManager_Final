export class ViewTask {
    Enddate:string=new Date().toISOString().split('T')[0];
    Startdate:string=new Date().toISOString().split('T')[0];
    TASK_ID:number=0;
    TaskName:string="";            
    parentName:string="";
    parent_id !:number;      
    task_priority:number=0;        
}
