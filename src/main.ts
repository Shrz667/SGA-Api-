import { importProvidersFrom } from '@angular/core';
import { bootstrapApplication } from '@angular/platform-browser';
import {  HttpClientModule} from '@angular/common/http';
import { provideRouter } from '@angular/router';
import { App } from './app/app';  // On créera ce fichier juste après
import { routes } from './app/app.routes';

bootstrapApplication(App, {
  providers: [
    provideRouter(routes ),  // on créera ce fichier juste après
  importProvidersFrom( HttpClientModule)],
//
});
