import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { PostListComponent } from './post-list/post-list.component';
import { DataService } from './shared/dataService';
import { ContactComponent } from './contact/contact.component'
import { AboutMeComponent } from './about-me/about-me.component'
import { ProjectListComponent } from './project-list/project-list.component'

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    CounterComponent,
    FetchDataComponent,
    PostListComponent,
    ContactComponent,
    AboutMeComponent,
    ProjectListComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: PostListComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'contact', component: ContactComponent },
      { path: 'about-me', component: AboutMeComponent },
      { path: 'project-list', component: AboutMeComponent }
    ])
  ],
  providers: [
    DataService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
