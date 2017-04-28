USE [collectorManager]
GO

INSERT INTO [dbo].[Joueur]
           ([idJoueur]
           ,[nom]
           ,[note]
           ,[valeur]
           ,[poste]
           ,[photo]
           ,[idEqp])
     VALUES
 (0,'Pele',76,10000000,'G',null,0),
 (1,'Fanni',78,12000000,'D',null,0)
,(2,'Rolando',76,10000000,'D',null,0)
,(3,'Thauvin',81,20000000,'M',null,0)
,(4,'Payet',86,45000000,'M',null,0)
,(5,'Cabella',79,15000000,'M',null,0)
,(6,'Gomis',79,15000000,'A',null,0)
,(7,'Matuidi',83,25000000,'M',null,1)
,(8,'Cavani',84,29500000,'A',null,1)
,(9,'Thiago Silva',85,35000000,'D',null,1)
,(10,'Trapp',83,20000000,'G',null,1)
,(11,'Kurzawa',82,19000000,'D',null,1)
,(12,'Lemar',81,20000000,'M',null,2)
,(13,'Mbappe',82,23000000,'A',null,2)
,(14,'Falcao',84,31000000,'A',null,2)
,(15,'Sidibe',79,15000000,'D',null,2)
,(16,'Subasic',78,15000000,'G',null,2)
,(17,'Mendy',80,19000000,'D',null,2)
,(18,'Silva',80,20000000,'M',null,2)
,(19,'Pique',85,46000000,'D',null,3)
,(20,'Umtiti',82,23500000,'D',null,3)
,(21,'Neymar',89,90000000,'M',null,3)
,(22,'Messi',95,125000000,'M',null,3)
,(23,'Suarez',89,85000000,'A',null,3)
,(24,'Gomes',83,20000000,'M',null,3)
,(25,'Ter Stegen',84,30000000,'G',null,3)
,(26,'Cristiano Ronaldo',92,100000000,'M',null,4)
,(27,'James Rodriguez',84,23400000,'M',null,4)
,(28,'Pepe',86,40000000,'D',null,4)
,(29,'Varane',84,25000000,'D',null,4)
,(30,'Morata',85,40000000,'A',null,4)
,(31,'Benzema',85,40000000,'A',null,4)
,(32,'Casilla',85,40000000,'G',null,4);

GO


