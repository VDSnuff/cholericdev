import { User } from './User';
export interface Comment {
    commentId: number;
    content: string;
    user: User;
}
