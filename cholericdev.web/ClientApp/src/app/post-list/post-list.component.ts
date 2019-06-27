import { Component, OnInit } from '@angular/core';
import { DataService } from '../shared/dataService';
import { Post } from '../shared/post';

@Component({
  selector: 'app-post-list',
  templateUrl: './post-list.component.html',
  styleUrls: []
})
export class PostListComponent implements OnInit {

  constructor(private data: DataService) {
  }

  public posts: Post[] = [];

  ngOnInit(): void {
    this.data.loadPosts()
      .subscribe(success => {
        if (success) {
          this.posts = this.data.posts;
        }
      });
  }

}
