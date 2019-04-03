import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Movies } from './movies';
import 'rxjs/Operator';
import { Observable } from "rxjs";
@Injectable({ providedIn: 'root' })

export class MoviesService {
  apiUrl = "http://localhost:2133/api";
  constructor(private _http: HttpClient) { }

  getAllMovies(): Observable<Movies[]> {
    return this._http.get<Movies>(this.apiUrl+"/movies");
  }

}
