import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Router } from '@angular/router';
import { Category } from '../models/category';

@Component({
  selector: 'app-category-card',
  templateUrl: './category-card.component.html',
  styleUrls: ['./category-card.component.scss'],
})
export class CategoryCardComponent implements OnInit {
  @Input() categoryInput: Category;

  @Output() categoryOutput: EventEmitter<void> = new EventEmitter<void>();
  constructor(private router: Router) {}

  ngOnInit(): void {}

  public navigateToCategory(category: Category) {
    this.router.navigate(['category', category.id]);
  }

  public emitClick() {
    this.categoryOutput.emit();
  }
}
