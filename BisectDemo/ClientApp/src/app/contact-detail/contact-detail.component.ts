import { Component, OnInit } from '@angular/core';
import {ActivatedRoute} from "@angular/router";

@Component({
  selector: 'app-contact-detail',
  templateUrl: './contact-detail.component.html',
  styleUrls: ['./contact-detail.component.css']
})
export class ContactDetailComponent implements OnInit {
  public id: string;

  constructor(private route: ActivatedRoute) { this.id = ""; }

  ngOnInit(): void {
    this.id = this.route.snapshot.paramMap.get('id')!;
  }

}
