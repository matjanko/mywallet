import { Component, Input, OnInit } from '@angular/core';
import { Loan } from '../../models/loan.model';

@Component({
  selector: 'app-loan-item[loan]',
  templateUrl: './loan-item.component.html',
  styleUrls: ['./loan-item.component.less'],
})
export class LoanItemComponent implements OnInit {
  @Input() loan!: Loan;

  constructor() {}

  ngOnInit(): void {}
}
