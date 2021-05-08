import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public orders: Order[];

  constructor(http: HttpClient) {
    http.get<Order[]>('https://localhost:44317/api/webapi').subscribe(result => {
      this.orders = result;
    }, error => console.error(error));
  }
}

interface Order {
  id: number;
  name: string;
  type: string;
  madeby: string;
}
