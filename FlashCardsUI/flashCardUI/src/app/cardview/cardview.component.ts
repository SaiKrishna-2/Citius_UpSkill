import { Component, OnInit } from '@angular/core';
import { flashCards } from 'src/models/dbModels';
import { FlashcardService } from 'src/services/flashcard.service';

@Component({
  selector: 'app-cardview',
  templateUrl: './cardview.component.html',
  styleUrls: ['./cardview.component.css']
})
export class CardviewComponent implements OnInit {
  
  cards:flashCards[]=[]
  constructor(private cardsService:FlashcardService) {   }
  ngOnInit(): void {
    this.cardsService.getAllCards().subscribe({
      next:(response)=>{
      for(let i=0;i<response.length;i++)
        {
          this.visibility[i]='hidden'
        }
        console.log(response);
        this.cards=response;
        
      }
    })
    
  }
  
  visibility:string[]=[];
  questions=["What is 2+2?","What is tha Capital of India?"]
  answers=["4","New Delhi"]
  
  showAnswer(i:number)
  {
    this.visibility[i]=this.visibility[i]=='visible'?'hidden':'visible'
  }
  
}
