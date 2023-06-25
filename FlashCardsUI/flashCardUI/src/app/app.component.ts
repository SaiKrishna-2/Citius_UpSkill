import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { AddCardComponent } from './add-card/add-card.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  constructor(private router:Router,private dialogbox: MatDialog) {
    
    
  }
  title = 'flashCardUI';
  swap:boolean=true;
  toggle()
  {
    if(this.swap==true)
    {
        this.swap=false;
        this.router.navigate(['/cardview']);
    }
    else{
      this.swap=true;
      this.router.navigate(['/tableview']);
    }
  }
  Add()
  {
    this.dialogbox.open(AddCardComponent,{
      height:'420px',
      width:'650px',
  })
    
  }
}
