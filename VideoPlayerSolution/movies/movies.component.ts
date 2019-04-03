import { Component, OnInit } from '@angular/core';

import { MoviesService } from '../services/movies.service';
import { Movies } from '../services/movies';
import { Observable } from "rxjs";


@Component({ selector: 'app-movies', templateUrl: '', styles: '' })
export class MovieComponent implements OnInit {
  allMovies: Observable<Movies[]>;
  constructor(private movieservice: MoviesService) { }
  ngOnInit() {
    this.loadAllMovies();
  }

  loadAllMovies() {
    this.allMovies = this.movieservice.getAllMovies();
  }
}
