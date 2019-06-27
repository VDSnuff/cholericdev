import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Post } from './post';

@Injectable()
export class DataService {
  constructor(private http: HttpClient) { }
  public posts: Post[] = [];

  loadPosts(): Observable<boolean>{
    return this.http.get('/api/post')
      .pipe(map((data: any[]) => {
        this.posts = data;
        return true;
      }));
  }
}
