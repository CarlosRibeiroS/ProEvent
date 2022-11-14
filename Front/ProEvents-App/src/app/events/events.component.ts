import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.scss']
})
export class EventsComponent implements OnInit {

  public events: any = [];
  public filteredevents: any = [];

  widthImg:  number = 150;
  marginImg: number = 2;
  showImage: boolean = true;
  private _listfilter: string = "";

  public get listfilter() : string{
    return this._listfilter;
  }

  public set listfilter(value: string){
     this._listfilter = value;
     this.filteredevents = this.listfilter ? this.eventsFilter(this.listfilter) : this.events;
  }

  eventsFilter(filterBy: string) : any{
    filterBy = filterBy.toLocaleLowerCase();

     return this.events.filter(
       (e:{ theme: string; local: string; }) => e.theme.toLocaleLowerCase()
       .indexOf(filterBy) !== -1
      || e.local.toLocaleLowerCase().indexOf(filterBy) !== -1);
  }


  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEvents();

  }


showImageBtn(){
  this.showImage = !this.showImage
}

  public getEvents(): void{
    this.http.get('https://localhost:5001/api/Event').subscribe(
      response => {this.events = response,
      this.filteredevents = this.events}
    );
    console.log(this.events);

  }

}
