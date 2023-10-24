INSERT INTO [dbo].[Musei] ([NomeM], [Citta]) VALUES (N'National Gallery', N'London')
INSERT INTO [dbo].[Musei] ([NomeM], [Citta]) VALUES (N'Galleria degli Uffizi', N'Firenze')
INSERT INTO [dbo].[Musei] ([NomeM], [Citta]) VALUES (N'British Museum', N'London')
INSERT INTO [dbo].[Musei] ([NomeM], [Citta]) VALUES (N'Tiziano Museum', N'London')

INSERT INTO [dbo].[Artisti] ([NomeA], [Nazionalita]) VALUES (N'Tiziano', N'Italiana')
INSERT INTO [dbo].[Artisti] ([NomeA], [Nazionalita]) VALUES (N'Caravaggio', N'Italiana')
INSERT INTO [dbo].[Artisti] ([NomeA], [Nazionalita]) VALUES (N'Andrea del Sarto', N'Italiana')
INSERT INTO [dbo].[Artisti] ([NomeA], [Nazionalita]) VALUES (N'Andrea d''Assisi', N'Italiana')

INSERT INTO [dbo].[Personaggi] ([Personaggio], [Codice]) VALUES (N'Madonna', 9)
INSERT INTO [dbo].[Personaggi] ([Personaggio], [Codice]) VALUES (N'Madonna', 10)

SET IDENTITY_INSERT [dbo].[Opere] ON
INSERT INTO [dbo].[Opere] ([Codice], [Titolo], [NomeM], [NomeA]) VALUES (1, N'Venere e Adone', N'National Gallery', N'Tiziano')
INSERT INTO [dbo].[Opere] ([Codice], [Titolo], [NomeM], [NomeA]) VALUES (2, N'Perseo e Andromeda', N'National Gallery', N'Tiziano')
INSERT INTO [dbo].[Opere] ([Codice], [Titolo], [NomeM], [NomeA]) VALUES (3, N'Diana e Atteone', N'National Gallery', N'Tiziano')
INSERT INTO [dbo].[Opere] ([Codice], [Titolo], [NomeM], [NomeA]) VALUES (4, N'CANESTRA DI FRUTTA', N'National Gallery', N'Caravaggio')
INSERT INTO [dbo].[Opere] ([Codice], [Titolo], [NomeM], [NomeA]) VALUES (5, N'BUONA VENTURA', N'Galleria degli Uffizi', N'Caravaggio')
INSERT INTO [dbo].[Opere] ([Codice], [Titolo], [NomeM], [NomeA]) VALUES (9, N'Madonna col Bambino', N'National Gallery', N'Andrea d''Assisi')
INSERT INTO [dbo].[Opere] ([Codice], [Titolo], [NomeM], [NomeA]) VALUES (10, N'Madonna col Bambino, sant''Elisabetta e il Battista', N'National Gallery', N'Andrea Del Sarto')
INSERT INTO [dbo].[Opere] ([Codice], [Titolo], [NomeM], [NomeA]) VALUES (12, N'Partenone', N'British Museum', N'Andrea d''Assisi')
INSERT INTO [dbo].[Opere] ([Codice], [Titolo], [NomeM], [NomeA]) VALUES (13, N'Venere', N'British Museum', N'Caravaggio')
INSERT INTO [dbo].[Opere] ([Codice], [Titolo], [NomeM], [NomeA]) VALUES (14, N'BACCO', N'National Gallery', N'Caravaggio')
INSERT INTO [dbo].[Opere] ([Codice], [Titolo], [NomeM], [NomeA]) VALUES (15, N'RAGAZZO MORSO DA UN RAMARRO', N'National Gallery', N'Caravaggio')
INSERT INTO [dbo].[Opere] ([Codice], [Titolo], [NomeM], [NomeA]) VALUES (16, N'CENA IN EMMAUS', N'National Gallery', N'Andrea Del Sarto')
INSERT INTO [dbo].[Opere] ([Codice], [Titolo], [NomeM], [NomeA]) VALUES (17, N'Venere e Adone', N'Tiziano Museum', N'Tiziano')
INSERT INTO [dbo].[Opere] ([Codice], [Titolo], [NomeM], [NomeA]) VALUES (18, N'Perseo e Andromeda', N'Tiziano Museum', N'Tiziano')
SET IDENTITY_INSERT [dbo].[Opere] OFF
