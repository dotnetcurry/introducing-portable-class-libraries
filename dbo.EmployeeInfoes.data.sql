﻿SET IDENTITY_INSERT [dbo].[EmployeeInfoes] ON
INSERT INTO [dbo].[EmployeeInfoes] ([EmpNo], [EmpName], [Salary], [DeptName], [Designation]) VALUES (1, N'Sumit', CAST(1000 AS Decimal(18, 0)), N'Development', N'Developer')
INSERT INTO [dbo].[EmployeeInfoes] ([EmpNo], [EmpName], [Salary], [DeptName], [Designation]) VALUES (2, N'Mahesh', CAST(10000 AS Decimal(18, 0)), N'Development', N'Architect')
SET IDENTITY_INSERT [dbo].[EmployeeInfoes] OFF
