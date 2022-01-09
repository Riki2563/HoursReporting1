import { HoursReporting } from "./hoursReporting";
import { Project } from "./project";

export class User{
      userId? :number;
      userName? :string;
      email ?:string;
      password? :string;

      role? :number;

     hoursReportings?:HoursReporting[];
      projects ?:Project[];
}