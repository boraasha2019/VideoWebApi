import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Observable } from "rxjs";

import { Movie } from './movie';
import * as global from '../shared/global';
////import 'rxjs/Operator';





@Injectable({ providedIn: 'root' })

export class MoviesService {
  debugger;
  apiUrl = global.BASE_WEBAPI_URL; 

  constructor(private _http: HttpClient) { }

  public getMovies(): Observable<Movie[]> {
    return this._http.get<Movie[]>(this.apiUrl + "/movies");
  }

  getMovie(name: string): Observable<Movie> {
    let params = new HttpParams().set("name", name);
   // debugger;
   // console.log("SERVICE - " + this._http+"  " + this.apiUrl + "/movies/" + name);
    return this._http.get<Movie>(this.apiUrl + "/movies/" + name);
  //  return this._http.get<Movie>(this.apiUrl + "/movies/", { params: params });
    // // return this._http.get<Movie[]>(this.apiUrl + "/movies").find(movie => movie.movieName === name);
    //  return this._http.get<Movie[]>(this.apiUrl + "/movies").map(movies => movies.find(movie => movie.movieName === name));

  }
}
