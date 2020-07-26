import { Component,OnInit } from '@angular/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {

  title = 'AU-Angular-AfternoonSession';
  newUser = {first:'',last:'',age:"",empId:'',city:''};
  user1 = {first:'Khushbu',last:'Chauhan',age:"21",empId:'INT440',city:'Delhi'};
  user2 = {first:'Anushka',last:'Misra',age:"21",empId:'INT420',city:'Delhi'};
  name = [this.user1,this.user2];
  delkey = null;

  ngOnInit(){ 

  }
 
   
  addUser = () =>{
      let temp = {first:'',last:'',age:"",empId:'',city:''};
      temp.first = this.newUser.first;
      temp.last = this.newUser.last;
      temp.age = this.newUser.age;
      temp.empId = this.newUser.empId;
      temp.city = this.newUser.city;
      
      this.name.push(temp);
     // newUser = {first:'',last:'',age:"",empId:'',city:''};
      return ;
  } 
  
  sortUser1 = () =>{
     this.name.sort((a,b) => a.first.localeCompare(b.first));
     return ;
  }
  sortUser2 = () =>{
    this.name.sort((a,b) => a.last.localeCompare(b.last));
    return ;
 }
 sortUser3 = () =>{
  this.name.sort((a,b) => a.age.localeCompare(b.age));
  return ;
}
sortUser4 = () =>{
  this.name.sort((a,b) => a.empId.localeCompare(b.empId));
  return ;
}
sortUser5 = () =>{
  this.name.sort((a,b) => a.city.localeCompare(b.city));
  return ;
}

updateUser= () =>{
  let temp = {first:'',last:'',age:"",empId:'',city:''};
      temp.first = this.newUser.first;
      temp.last = this.newUser.last;
      temp.age = this.newUser.age;
      temp.empId = this.newUser.empId;
      temp.city = this.newUser.city;
  var num : Number = null;
  for(var i=0;i<this.name.length;i++){
    var obj = this.name[i];
    if(obj.empId == this.newUser.empId){
      this.name[i] = temp;
      break;
    }
  }
  
  
}

deleteUser=()=>{
  
  
  for(var i=0;i<this.name.length;i++){
    var obj = this.name[i];
    if(obj.empId == this.delkey){
      this.name.splice(i,1);
      break;
    }
  }
}

    
    
   username : 'khushbu';


}