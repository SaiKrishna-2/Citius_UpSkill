import { Component, OnChanges, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { flashCards } from 'src/models/dbModels';
import { EditCardComponent } from '../edit-card/edit-card.component';
import { FlashcardService } from 'src/services/flashcard.service';
import { Router } from '@angular/router';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-tableview',
  templateUrl: './tableview.component.html',
  styleUrls: ['./tableview.component.css']
})
export class TableviewComponent implements OnInit,OnChanges {
  
  constructor(private dialogbox: MatDialog,private cardservice:FlashcardService,
    private router:Router,private snackbar:MatSnackBar) {}
  ngOnInit(): void {
    this.cardservice.getAllCards().subscribe({
      next:(response)=>{
        this.dataSource=response
       
      }
    })
  }
  ngOnChanges():void{
    this.cardservice.getAllCards().subscribe({
      next:(response)=>{
        this.dataSource=response
       
      }
    })
  }
  cards:flashCards[]=[];
  displayedColumns: string[] = [ 'Question', 'Answer','options'];
  dataSource = this.cards;
  edit(element:any)
  {
    this.dialogbox.open(EditCardComponent,{
      height:'500px',
      width:'650px',
      data:{
        key:element
      }
  })
  }
  delete(element:any)
  {
    this.cardservice.deleteCard(element.id).subscribe({
      next:(response)=>{
        this.snackbar.open("Deleted!!",'',{
          duration:3000
        })
        this.router.navigateByUrl('',{skipLocationChange:false}).then(()=>{
          this.router.navigate(['/tableview'])
        })
      }
    })
  }
}
