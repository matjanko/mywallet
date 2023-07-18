import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-create-loan-form',
  templateUrl: './create-loan-form.component.html',
  styleUrls: ['./create-loan-form.component.less'],
})
export class CreateLoanFormComponent implements OnInit {
  loanForm: FormGroup;

  constructor() {
    this.loanForm = new FormGroup({
      summary: new FormControl('', Validators.required),
    });
  }

  ngOnInit(): void {}

  onSubmit(): void {
    console.log('Zapisz');
  }

  onCancel(): void {
    console.log('Anuluj');
  }
}
