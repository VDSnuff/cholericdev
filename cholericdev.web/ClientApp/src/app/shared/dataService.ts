import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';

@Injectable()
export class DataService {
  constructor(private http: HttpClient) { }
  public posts = [];

  loadPosts() {
    return this.http.get('/api/post')
      .pipe(map((data: any[]) => {
        this.posts = data;
        return true;
      }));
  }
}
