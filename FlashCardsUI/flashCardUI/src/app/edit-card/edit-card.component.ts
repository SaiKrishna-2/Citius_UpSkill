import { Component,Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialog } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Router } from '@angular/router';
import { flashCards } from 'src/models/dbModels';
import { FlashcardService } from 'src/services/flashcard.service';

@Component({
  selector: 'app-edit-card',
  templateUrl: './edit-card.component.html',
  styleUrls: ['./edit-card.component.css']
})
export class EditCardComponent {
  
  excard:flashCards={
    question:'',
    answer:'',
    id:''
  }
  constructor(@Inject(MAT_DIALOG_DATA) public data: any,private cardService:FlashcardService,
  private router:Router, public dialog: MatDialog,private snackbar:MatSnackBar) {
    this.excard=this.data.key
    console.log(this.excard);
  }
  
  editCard(item:flashCards)
  {
    this.cardService.editCard(item,item.id).subscribe({
      next:(response)=>{
        this.snackbar.open(" Card Updated!!",'',{
          duration:3000
        })
        this.dialog.closeAll();
        this.router.navigateByUrl('',{skipLocationChange:false}).then(()=>{
          this.router.navigate(['/tableview'])
        })
      }
    })
    
  }
}
