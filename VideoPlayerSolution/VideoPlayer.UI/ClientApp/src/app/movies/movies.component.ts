import { Component, OnInit } from '@angular/core';
import { Observable } from "rxjs";
import { MoviesService } from '../services/movies.service';
import { Movie } from '../services/movie';


@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html'
})

export class MoviesComponent implements OnInit {
  //  moviesList: Observable<Movies[]>;
  private moviesList: any = [];
  private title: string = "Movies...";
  private selectedMovie: Movie = null;
  constructor(private movieservice: MoviesService) {
  }
  ngOnInit(): void {
    this.getMovies();

  }

  getMovies() {
    this.movieservice.getMovies().subscribe((res: any[]) => {
      this.moviesList = res["moviesList"];
      console.log(res["moviesList"]);
    });
  }

  getMovie(movie: string) {
    console.log(movie["name"]);
    debugger;
    this.movieservice.getMovie(movie["name"]).subscribe(resp => {
      console.log(this.selectedMovie + ">>>");
      debugger;
      this.selectedMovie = resp;

      console.log("move  " + resp.Format);
    });
  }

}
