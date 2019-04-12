import { Component, OnInit } from '@angular/core';
import { Observable } from "rxjs";
import { MoviesService } from '../services/movies.service';
import { Movie } from '../services/movie';


@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html'
})

export class MovieComponent implements OnInit {
  //  moviesList: Observable<Movies[]>;
  private moviesList: any = [];
  private title: string = "Movies...";
  private movieN: string;
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

  getMovie(movieName: string)
  {
   // this.movieservice.getMovie(movieName).subscribe(res= )
  }

}
