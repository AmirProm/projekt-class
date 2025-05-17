import { Component, inject } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Account‍‍Service } from './services/account‍‍.service';
import { FormBuilder, FormControl, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { AppUser } from './model/ app-user.model';

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
}
