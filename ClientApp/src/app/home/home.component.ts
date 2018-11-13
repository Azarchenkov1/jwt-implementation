import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { JwtHelper } from 'angular2-jwt';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: []
})
export class HomeComponent {
  private jwtHelper: JwtHelper;
constructor (private router: Router) { }

logOut() {
  localStorage.removeItem("jwt");
}

isUserAuthenticated() {
  let token: string = localStorage.getItem("jwt");
  if (token != null) {
    return true;
  }
  else {
    return false;
  }
}

}
