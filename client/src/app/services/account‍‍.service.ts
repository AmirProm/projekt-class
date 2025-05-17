import { HttpClient } from '@angular/common/http';
import { inject, Inject, Injectable } from '@angular/core';
import { AppUser } from '../model/ app-user.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class Account‍‍Service {
  http = inject(HttpClient);
  private readonly _baseApiUrl: string = 'http://localhost:5000/api/';

  }
