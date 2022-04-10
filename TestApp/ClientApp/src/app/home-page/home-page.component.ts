import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Category } from '../models/category';
import { AppService } from '../services/app.service';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.scss'],
})
export class HomePageComponent implements OnInit {
  public allCategories: Category[] = [];

  constructor(private appService: AppService, private router: Router) {}

  ngOnInit(): void {
    this.appService.getCategories().subscribe((categories: Category[]) => {
      this.allCategories = categories;
      // this.allCategories.forEach((category) => {
      //   category.image =
      //     'https://material.angular.io/assets/img/examples/shiba2.jpg';
      // });
    });
  }

  public receiveOutput() {
    console.log('s-a apasat');
  }
}
