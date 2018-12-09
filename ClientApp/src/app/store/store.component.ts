import { Component } from '@angular/core';
import { Model, TodoItem } from './model';

@Component({
  selector: 'store',
  templateUrl: './store.component.html',
  styleUrls: ['./store.component.css']
})
export class StoreComponent {
  model = new Model();
  getName() {
    return this.model.user;
  }
  getTodoItems() {
    return this.model.items;
  }
  addItem(newItem) {
    if (newItem != "") {
      this.model.items.push(new TodoItem(newItem, false));
    }
  }
}
