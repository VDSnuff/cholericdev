import { Component, OnInit } from '@angular/core';
import { DataService } from '../shared/dataService';

@Component({
  selector: 'app-post-list',
  templateUrl: './post-list.component.html',
  styleUrls: []
})
export class PostListComponent implements OnInit {

  constructor(private data: DataService) {
  }

  public posts = [];

  ngOnInit(): void {
    this.data.loadPosts()
      .subscribe(success => {
        if (success) {
          this.posts = this.data.posts;
        }
      });
  }

}
