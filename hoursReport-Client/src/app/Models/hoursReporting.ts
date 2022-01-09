import { Project } from "./project";
import { User } from "./user";

export class HoursReporting {
    hoursReportingId?: number;
    date?: Date;
    begingingTime?: string;
    endTime?: string;
    userId?: number;
    projectId?: number;

    user?: User;
     project?: Project;
}