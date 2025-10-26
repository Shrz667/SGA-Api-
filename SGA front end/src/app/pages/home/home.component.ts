import { Component } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { FormsModule } from '@angular/forms'
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-home',
  imports: [FormsModule,CommonModule],
  templateUrl: './home.html',
  styleUrl: './home.css'
})
export class HomeComponent {
latitude: number = 0;
  longitude: number = 0;
  result: any;
  constructor(private http: HttpClient) { }

   submitCoordinates() {
      const token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6InNoeXJheiIsInJvbGUiOiJBZG1pbiIsIm5iZiI6MTc1NjIyMTMzMiwiZXhwIjoxNzU2MjIzMTMyLCJpYXQiOjE3NTYyMjEzMzJ9.1TUNcpOkYNAWrQzZRiLHunMdvjbygyXyjlWMw6C-VZI"; // Remplace par un vrai JWT
      const headers = new HttpHeaders().set('Authorization', `Bearer ${token}`);

      const url = `http://localhost:5033/Agenceslists/GetClosestAgence?Latt=${this.latitude}&Long=${this.longitude}`;

      this.http.get(url, { headers }).subscribe(
        res => this.result = res,
        err => console.error(err)
      );
    }
  }

