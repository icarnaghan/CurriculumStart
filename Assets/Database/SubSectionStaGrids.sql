USE [Mapper21]
GO

/****** Object:  View [dbo].[StaGrids]    Script Date: 12/19/2013 17:49:45 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[SubSectionStaGrids]'))
DROP VIEW [dbo].[SubSectionStaGrids]
GO

USE [Mapper21]
GO

/****** Object:  View [dbo].[StaGrids]    Script Date: 12/19/2013 17:49:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[SubSectionStaGrids]
as

select
	newid() AS Id,
	a.id as SubSectionStaId,
	c.id as SubSectionId,
	substring((select (', ' + rtrim(c.subject) + (c.code)) from CommonCoreStandards c join SubSectionStandards s on c.Id = s.CommonCoreStandardId where s.subSectionStaid = a.id
		order by c.code for xml path('')),3,500) as Standards,
	substring((select (', ' + rtrim(s.name)) from SubSectionLongTermTargets s where s.subSectionStaid = a.id
		order by s.name for xml path('')),3,500) as LongTermTargets,
	substring((select (', ' + rtrim(s.name)) from SubSectionShortTermTargets s where s.subSectionStaid = a.id
		order by s.name for xml path('')),3,500) as ShortTermTargets,
	substring((select (', ' + rtrim(s.name)) from SubSectionAssessments s where s.subSectionStaid = a.id
		order by s.name for xml path('')),3,500) as Assessments
from SubSectionStas a
join SubSections c on c.id = a.SubSectionId

GO
