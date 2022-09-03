import {Component, Inject, OnInit} from '@angular/core';
import { Router } from '@angular/router';
import {HttpClient} from "@angular/common/http";

@Component({
  selector: 'app-contact-list',
  templateUrl: './contact-list.component.html',
  styleUrls: ['./contact-list.component.css']
})
export class ContactListComponent implements OnInit {
  public contactList: Contact[] = [];
  constructor(private router: Router, http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Contact[]>(baseUrl + 'contacts').subscribe( result => {
      this.contactList = result;
    }, error => console.error(error));
  }

  ngOnInit() {
  }

  openClient(id: number) {
    this.router.navigate(["contactdetail", id.toString()]);
  }
}

interface Contact {
  firstName: string;
  lastName: string;
  address1: string;
  address2: string;
}
