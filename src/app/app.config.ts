import { ApplicationConfig, provideBrowserGlobalErrorListeners, provideZoneChangeDetection } from '@angular/core';
import { provideRouter } from '@angular/router';
import {  HttpClientModule} from '@angular/common/http';
import { routes } from './app.routes';
import { bootstrapApplication } from '@angular/platform-browser';


export const appConfig: ApplicationConfig = {
  providers: [
    provideBrowserGlobalErrorListeners(),
    provideZoneChangeDetection({ eventCoalescing: true }),
    provideRouter(routes)
  ]
};
//bootstrapApplication(AppComponent, {
//  providers: [
  //  provideRouter(routes ),  // on créera ce fichier juste après
    //importProvidersFrom( HttpClientModule)
  //],
//
//});

function importProvidersFrom(module: any): import("@angular/core").Provider | import("@angular/core").EnvironmentProviders {
  throw new Error('Function not implemented.');
}
