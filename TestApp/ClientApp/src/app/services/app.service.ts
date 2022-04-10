import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class AppService {
  constructor(private http: HttpClient) {}

  private baseUrl = 'https://localhost:44397/';
  private header = new HttpHeaders({
    'Content-Type': 'application/json',
    'Access-Control-Allow-Origin': '*',
  });

  public getCategories() {
    return this.http.get(this.baseUrl + 'category', {
      headers: this.header,
    });
  }
}
