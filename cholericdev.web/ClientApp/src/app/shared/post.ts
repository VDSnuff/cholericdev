import { Comment } from './comment';
import { User } from './user';
import { Category } from './category';

export interface Post {
  postId: number;
  title: string;
  category: Category;
  content: string;
  creationDay: Date;
  lastUpdate: Date;
  user: User;
  comments: Comment[];
}

