export class Model {
    user;
    items;
    constructor() {
    this.user = "David";
    this.items = [new TodoItem("Go to office", false),
    new TodoItem("Go to meeting", false),
    new TodoItem("Deliver my wife to psychologist", false),
    new TodoItem("Go to baseball with my son", false)]
    }
   }
   export class TodoItem {
    action;
    done;
    constructor(action, done) {
    this.action = action;
    this.done = done;
    }
   }