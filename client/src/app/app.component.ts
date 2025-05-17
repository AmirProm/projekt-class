import { Component, inject } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Account‍‍Service } from './services/account‍‍.service';
import { FormBuilder, FormControl, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { AppUser } from './model/ app-user.model';
import { Observable } from 'rxjs';
import { response } from 'express';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  accountService = inject(Account‍‍Service);
  fB = inject(FormBuilder);
  appUser: AppUser | undefined;
  member: AppUser[] | undefined;

  registerFg = this.fB.group({
    emailCtrl: ['', [Validators.required, Validators.email]],
    nameCtrl: ['', Validators.required, Validators.minLength(2), Validators.maxLength(15)],
  });

  get EmailCtrl(): FormControl {
    return this.registerFg.get('emailCtrl') as FormControl;
  }

  get NameCtrl(): FormControl {
    return this.registerFg.get('nameCtrl') as FormControl;
  }

  register(): void {
    let userIn: AppUser = {
      email: this.EmailCtrl.value,
      name: this.NameCtrl.value
    }

    let userResponse: Observable<AppUser>= this.accountService.register(userIn);

    userResponse.subscribe({
      next: (response => {
        this.appUser = response;
        console.log(this.appUser);
      })
    });
  }

}
