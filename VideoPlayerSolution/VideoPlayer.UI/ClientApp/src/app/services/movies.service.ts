import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Observable} from "rxjs";

import { Movie } from './movie';
//import 'rxjs/Operator';




@Injectable({ providedIn: 'root' })
  
export class MoviesService {
  apiUrl: string = "http://localhost:2133/api";

  constructor(private _http: HttpClient) { }

  public getMovies(): Observable<Movie[]> {
    return this._http.get<Movie[]>(this.apiUrl + "/movies");
  }

  //getMovie(name: string): Observable<Movie> {
  // // return this._http.get<Movie[]>(this.apiUrl + "/movies").find(movie => movie.movieName === name);
  //  return this._http.get<Movie[]>(this.apiUrl + "/movies").map(movies => movies.find(movie => movie.movieName === name));

  //}
}
