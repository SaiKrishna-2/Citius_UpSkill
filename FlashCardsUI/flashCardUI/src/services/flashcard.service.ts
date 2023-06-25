import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { environment } from 'src/environments/environment.development';
import { flashCards } from 'src/models/dbModels';

@Injectable({
  providedIn: 'root'
})
export class FlashcardService {
  baseapiurl:string=environment.baseApiUrl;
  constructor(private hhtp:HttpClient) { }

  getAllCards():Observable<flashCards[]>
  {
    return this.hhtp.get<flashCards[]>(this.baseapiurl+"getAll");
  }
  addCards(newCard:flashCards):Observable<flashCards>
  {
    return this.hhtp.post<flashCards>(this.baseapiurl+"add",newCard)
  }
  editCard(card:flashCards,id:string):Observable<flashCards>
  {
    let headers=new HttpHeaders({
      'Content-Type':'application/json',
      'resposneType':'json',
      'id':id
    });
    return this.hhtp.put<flashCards>(this.baseapiurl+"edit",card,{headers:headers});
  }
  deleteCard(id:string):Observable<flashCards>
  {
    let headers=new HttpHeaders({
      'Content-Type':'application/json',
      'resposneType':'json',
      'id':id
    });
    return this.hhtp.delete<flashCards>(this.baseapiurl+"delete",{headers:headers});
    
  }
}
