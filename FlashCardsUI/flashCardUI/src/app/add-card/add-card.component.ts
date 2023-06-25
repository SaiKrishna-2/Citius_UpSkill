import { Component,Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialog } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Router } from '@angular/router';
import { FlashcardService } from 'src/services/flashcard.service';

@Component({
  selector: 'app-add-card',
  templateUrl: './add-card.component.html',
  styleUrls: ['./add-card.component.css']
})
export class AddCardComponent {
  constructor(private cardService:FlashcardService,private router:Router,@Inject(MAT_DIALOG_DATA) public data: any, 
  public dialog: MatDialog, private snackbar:MatSnackBar) {}
  
  addCard(item:any)
  {
    this.cardService.addCards(item).subscribe({
      next:(response)=>{
        console.log(response);
        this.snackbar.open("Added New Card Successfully!!",'',{
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
