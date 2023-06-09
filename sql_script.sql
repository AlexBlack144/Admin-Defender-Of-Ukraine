USE [Kursak]
GO
SET IDENTITY_INSERT [dbo].[Spent_ammo] ON 

INSERT [dbo].[Spent_ammo] ([ID], [Ammo_picked_up], [Fired_bullets]) VALUES (1008, 5, 35)
INSERT [dbo].[Spent_ammo] ([ID], [Ammo_picked_up], [Fired_bullets]) VALUES (1009, 6, 38)
INSERT [dbo].[Spent_ammo] ([ID], [Ammo_picked_up], [Fired_bullets]) VALUES (1010, 0, 0)
INSERT [dbo].[Spent_ammo] ([ID], [Ammo_picked_up], [Fired_bullets]) VALUES (1011, 26, 173)
INSERT [dbo].[Spent_ammo] ([ID], [Ammo_picked_up], [Fired_bullets]) VALUES (1012, 3, 24)
INSERT [dbo].[Spent_ammo] ([ID], [Ammo_picked_up], [Fired_bullets]) VALUES (1013, 4, 30)
INSERT [dbo].[Spent_ammo] ([ID], [Ammo_picked_up], [Fired_bullets]) VALUES (1014, 5, 33)
INSERT [dbo].[Spent_ammo] ([ID], [Ammo_picked_up], [Fired_bullets]) VALUES (1015, 6, 35)
INSERT [dbo].[Spent_ammo] ([ID], [Ammo_picked_up], [Fired_bullets]) VALUES (1016, 10, 68)
INSERT [dbo].[Spent_ammo] ([ID], [Ammo_picked_up], [Fired_bullets]) VALUES (1017, 10, 57)
INSERT [dbo].[Spent_ammo] ([ID], [Ammo_picked_up], [Fired_bullets]) VALUES (1018, 1, 10)
INSERT [dbo].[Spent_ammo] ([ID], [Ammo_picked_up], [Fired_bullets]) VALUES (1019, 1, 15)
INSERT [dbo].[Spent_ammo] ([ID], [Ammo_picked_up], [Fired_bullets]) VALUES (1020, 2, 18)
INSERT [dbo].[Spent_ammo] ([ID], [Ammo_picked_up], [Fired_bullets]) VALUES (1021, 2, 20)
INSERT [dbo].[Spent_ammo] ([ID], [Ammo_picked_up], [Fired_bullets]) VALUES (1022, 3, 23)
INSERT [dbo].[Spent_ammo] ([ID], [Ammo_picked_up], [Fired_bullets]) VALUES (1023, 4, 26)
INSERT [dbo].[Spent_ammo] ([ID], [Ammo_picked_up], [Fired_bullets]) VALUES (1024, 4, 28)
INSERT [dbo].[Spent_ammo] ([ID], [Ammo_picked_up], [Fired_bullets]) VALUES (1025, 0, 1)
INSERT [dbo].[Spent_ammo] ([ID], [Ammo_picked_up], [Fired_bullets]) VALUES (1026, 0, 4)
INSERT [dbo].[Spent_ammo] ([ID], [Ammo_picked_up], [Fired_bullets]) VALUES (1027, 0, 6)
INSERT [dbo].[Spent_ammo] ([ID], [Ammo_picked_up], [Fired_bullets]) VALUES (1028, 0, 8)
INSERT [dbo].[Spent_ammo] ([ID], [Ammo_picked_up], [Fired_bullets]) VALUES (1029, 2, 19)
INSERT [dbo].[Spent_ammo] ([ID], [Ammo_picked_up], [Fired_bullets]) VALUES (1030, 0, 2)
INSERT [dbo].[Spent_ammo] ([ID], [Ammo_picked_up], [Fired_bullets]) VALUES (1031, 0, 9)
INSERT [dbo].[Spent_ammo] ([ID], [Ammo_picked_up], [Fired_bullets]) VALUES (1032, 6, 36)
SET IDENTITY_INSERT [dbo].[Spent_ammo] OFF
GO
SET IDENTITY_INSERT [dbo].[Med_kit] ON 

INSERT [dbo].[Med_kit] ([ID], [Med_kit_picked_up], [HP_replenishment_amount]) VALUES (1007, 1, 30)
INSERT [dbo].[Med_kit] ([ID], [Med_kit_picked_up], [HP_replenishment_amount]) VALUES (1008, 0, 0)
INSERT [dbo].[Med_kit] ([ID], [Med_kit_picked_up], [HP_replenishment_amount]) VALUES (1009, 4, 120)
INSERT [dbo].[Med_kit] ([ID], [Med_kit_picked_up], [HP_replenishment_amount]) VALUES (1010, 2, 60)
SET IDENTITY_INSERT [dbo].[Med_kit] OFF
GO
SET IDENTITY_INSERT [dbo].[Weapon] ON 

INSERT [dbo].[Weapon] ([ID], [Name], [Damage]) VALUES (1, N'default', 0)
INSERT [dbo].[Weapon] ([ID], [Name], [Damage]) VALUES (2, N'default', 1)
SET IDENTITY_INSERT [dbo].[Weapon] OFF
GO
SET IDENTITY_INSERT [dbo].[PC_Name_And_ID] ON 

INSERT [dbo].[PC_Name_And_ID] ([Id], [Name_PC], [Id_PC]) VALUES (1059, N'Alex', N'192.168.0.110')
INSERT [dbo].[PC_Name_And_ID] ([Id], [Name_PC], [Id_PC]) VALUES (1060, N'Alex', N'192.168.31.111')
INSERT [dbo].[PC_Name_And_ID] ([Id], [Name_PC], [Id_PC]) VALUES (1061, N'Alex', N'192.168.0.102')
INSERT [dbo].[PC_Name_And_ID] ([Id], [Name_PC], [Id_PC]) VALUES (1062, N'Alex', N'192.168.0.103')
SET IDENTITY_INSERT [dbo].[PC_Name_And_ID] OFF
GO
SET IDENTITY_INSERT [dbo].[Player_statistics] ON 

INSERT [dbo].[Player_statistics] ([Id], [PC_ID_And_Name_Id], [Nick_name], [Kills], [Spent_ammo_id], [Med_kit_id], [Weapon_id], [Game_time]) VALUES (1067, 1059, N'Alex', 33, 1032, 1007, 2, N'Time: 00:01:17')
SET IDENTITY_INSERT [dbo].[Player_statistics] OFF
GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([ID], [Login], [Password]) VALUES (1, N'Alex', N'omlet44')
SET IDENTITY_INSERT [dbo].[Admin] OFF
GO
