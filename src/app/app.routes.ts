import { Routes } from '@angular/router';
 import { HomeComponent } from './pages/home/home.component';// adapte le chemin si besoin


export const routes: Routes = [
   { path: '', component: HomeComponent },   // affiche Home par défaut
     { path: 'home', component: HomeComponent }  // route vers Home

];
