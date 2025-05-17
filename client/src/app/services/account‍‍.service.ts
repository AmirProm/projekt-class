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

  register(user: AppUser): Observable<AppUser> {
    // return this.http.post<AppUser>(this._baseApiUrl + 'account/register', user);
    let userResponse$: Observable<AppUser> = this.http.post<AppUser>(this._baseApiUrl + 'account/register', user);

    return userResponse$;
  }

  getAllMember(): Observable<AppUser[]>  {

    // return this.http.get<Member[]>(this._baseApiUrl + 'account');

    let memberResponse$: Observable<AppUser[]> = this.http.get<AppUser[]>
    (this._baseApiUrl + 'account/get-all');

    return memberResponse$;
  
  }

  }
