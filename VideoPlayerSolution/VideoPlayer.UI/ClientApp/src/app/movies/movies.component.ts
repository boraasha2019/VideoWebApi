import { Component, OnInit } from '@angular/core';
import { NgModule } from '@angular/core';
import { DomSanitizer } from '@angular/platform-browser';
import { Observable } from "rxjs";
import { MoviesService } from '../services/movies.service';
import { Movie } from '../services/movie';



@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html'
})

export class MoviesComponent implements OnInit {
  private moviesList: any = [];
  private title: string = "Enjoy Movies...";
  private selectedMovie: Movie = new Movie();
  private moviePath: any;
  private imgPath: any;
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
    debugger;
    this.movieservice.getMovie(movie["name"]).subscribe(resp => {
      debugger;
      this.selectedMovie.Id = resp["id"];
      this.selectedMovie.Name = resp["name"];
      this.selectedMovie.MoviePath = resp["moviePath"]  + resp["name"];//+ "" + resp["language"] + 
      this.selectedMovie.Format = resp["format"];
      this.selectedMovie.Language = resp["Language"];
      console.log("as  " + this.selectedMovie.MoviePath);
    });
  }

}
