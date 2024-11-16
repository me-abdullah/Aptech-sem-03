import { Routes } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { ServicesComponent } from './services/services.component';
import { ContactComponent } from './contact/contact.component';
import { HomeComponent } from './home/home.component';

export const routes: Routes = [
    {path:'home',component:HomeComponent},
    {path:'about',component:AboutComponent},
    {path:'services',component:ServicesComponent},
    {path:'contact',component:ContactComponent},
];
