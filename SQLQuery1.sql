CREATE TABLE [dbo].[TelefonRehberi](
[KisiId] INT IDENTITY(1,1) NOT NULL,
[KisiAd] NVARCHAR(50) NOT NULL,
[KisiSoyadi] NVARCHAR(50) NOT NULL,
[KisiTelefon] NVARCHAR(15) NOT NULL,
PRIMARY KEY CLUSTERED ([KisiId] ASC)
)

INSERT INTO [dbo].[TelefonRehberi] ([KisiAd], [KisiSoyadi], [KisiTelefon]) VALUES
('Ali', 'Yılmaz', '555-1234'),
('Ayşe', 'Demir', '555-5678'),
('Mehmet', 'Öztürk', '555-8765'),
('Fatma', 'Kaya', '555-4321'),
('Ahmet', 'Çelik', '555-6789')

