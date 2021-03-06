USE [HoursReportingDB1]
GO
SET IDENTITY_INSERT [dbo].[HoursReporting] ON 

INSERT [dbo].[HoursReporting] ([HoursReportingId], [Date], [BegingingTime], [EndTime], [UserId], [ProjectId]) VALUES (1, CAST(N'2022-01-09T01:28:49.5930000' AS DateTime2), N'08:00', N'16:00', 2, 20)
INSERT [dbo].[HoursReporting] ([HoursReportingId], [Date], [BegingingTime], [EndTime], [UserId], [ProjectId]) VALUES (2, CAST(N'2022-01-09T01:30:46.5400000' AS DateTime2), N'09:00', N'17:00', 3, 30)
INSERT [dbo].[HoursReporting] ([HoursReportingId], [Date], [BegingingTime], [EndTime], [UserId], [ProjectId]) VALUES (3, CAST(N'2022-01-09T08:06:45.1970000' AS DateTime2), N'08:00', N'16:00', 3, 30)
INSERT [dbo].[HoursReporting] ([HoursReportingId], [Date], [BegingingTime], [EndTime], [UserId], [ProjectId]) VALUES (4, CAST(N'2022-01-09T09:58:16.0240000' AS DateTime2), N'08:40', N'16:51', 1, 10)
INSERT [dbo].[HoursReporting] ([HoursReportingId], [Date], [BegingingTime], [EndTime], [UserId], [ProjectId]) VALUES (5, CAST(N'2022-01-09T10:08:13.0180000' AS DateTime2), N'08:00', N'17:00', 1, 20)
INSERT [dbo].[HoursReporting] ([HoursReportingId], [Date], [BegingingTime], [EndTime], [UserId], [ProjectId]) VALUES (6, CAST(N'2022-01-09T10:38:23.9270000' AS DateTime2), N'12:00', N'20:00', 3, 30)
SET IDENTITY_INSERT [dbo].[HoursReporting] OFF
GO
