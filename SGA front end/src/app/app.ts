import { Component, signal,OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { CommonModule } from '@angular/common';


@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet ,CommonModule],
  templateUrl: './app.html',
  styleUrl: './app.css'
})

export class App implements OnInit {
  protected readonly title = signal('SGA-front');

  agencies: any[] = [];

   constructor(private http: HttpClient) {}

  ngOnInit(): void {

    this.http.get<any[]>('https://localhost:7244/Agenceslists/GetClosestAgence')  // 👉 ton backend
      .subscribe({
        next: (data: any) => this.agencies = data,
        error: (err :any) => console.error('Erreur API:', err)
      });
  }
}

//function inject(HttpClient: typeof HttpClient) {
  //throw new Error('Function not implemented.');
//}

