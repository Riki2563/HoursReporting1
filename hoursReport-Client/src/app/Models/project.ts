import { HoursReporting } from "./hoursReporting";
import { User } from "./user";

export class Project {
    projectId?: number;
    projectName?:string;

    hoursReportings?:HoursReporting[];
    users ?:User[];
}