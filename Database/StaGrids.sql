USE [ExpeditionMapper]
GO

/****** Object:  View [dbo].[StaGrids]    Script Date: 12/19/2013 17:49:45 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[StaGrids]'))
DROP VIEW [dbo].[StaGrids]
GO

USE [ExpeditionMapper]
GO

/****** Object:  View [dbo].[StaGrids]    Script Date: 12/19/2013 17:49:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[StaGrids]
as

select
	cast(ROW_NUMBER() OVER(ORDER BY a.id) as int) AS Id,
	a.id as StaCollectionId,
	c.id as CaseStudyId,
	substring((select (', ' + rtrim(s.name)) from standards s where s.stacollectionid = a.id
		order by s.name for xml path('')),3,500) as Standards,
	substring((select (', ' + rtrim(s.name)) from longtermtargets s where s.stacollectionid = a.id
		order by s.name for xml path('')),3,500) as LongTermTargets,
	substring((select (', ' + rtrim(s.name)) from shorttermtargets s where s.stacollectionid = a.id
		order by s.name for xml path('')),3,500) as ShortTermTargets,
	substring((select (', ' + rtrim(s.name)) from assessments s where s.stacollectionid = a.id
		order by s.name for xml path('')),3,500) as Assessments
from StaCollections a
join CaseStudies c on c.id = a.CaseStudyId

GO