import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-tourlist',
  templateUrl: './tourlist.component.html',
  styleUrls: ['./tourlist.component.css']
})
export class TourlistComponent {
  public tourlist: Tour[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Tour[]>(baseUrl + '/api/tourlist/tourlistinit').subscribe(result => {
      this.tourlist = result;
    }, error => console.error(error));
   }
  }


  
  interface Tour {
    id: number;
    hotel: string;
    price: number;
    isTransferInclude: boolean;
  }