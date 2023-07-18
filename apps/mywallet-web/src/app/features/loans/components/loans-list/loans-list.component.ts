import { Component, OnInit, ViewEncapsulation } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Loan } from '../../models/loan.model';

@Component({
  selector: 'app-loans-list',
  templateUrl: './loans-list.component.html',
  styleUrls: ['./loans-list.component.less'],
  encapsulation: ViewEncapsulation.None,
})
export class LoansListComponent implements OnInit {
  loans$: Observable<Loan[]>;

  constructor() {
    this.loans$ = of([
      { summary: 'TV Samsung 50' },
      { summary: 'Laptop HP Pavilion' },
      { summary: 'Google VR' },
      { summary: 'Thermomix' },
      { summary: 'Bateria Grohe' },
      { summary: 'Odkurzacz Dyson' },
      { summary: 'Odkurzacz Roborock' },
    ] as Loan[]);
  }

  ngOnInit(): void {}
}
