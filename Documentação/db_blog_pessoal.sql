CREATE TABLE [tb_temas] (
	id bigint NOT NULL,
	Descricao varchar(500) NOT NULL,
  CONSTRAINT [PK_TB_TEMAS] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [tb_postagens] (
	id bigint NOT NULL,
	Titulo varchar(255) NOT NULL,
	Texto varchar(2000) NOT NULL,
	Data datetimeoffset NOT NULL,
	TemaId bigint NOT NULL,
	UsuarioID bigint NOT NULL,
  CONSTRAINT [PK_TB_POSTAGENS] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [tb_usuarios] (
	id bigint NOT NULL,
	Nome varchar(70) NOT NULL,
	Usuario integer(70) NOT NULL,
	Senha integer(25) NOT NULL,
	Foto integer(5000) NOT NULL DEFAULT 'https://w7.pngwing.com/pngs/81/570/png-transparent-profile-logo-computer-icons-user-user-blue-heroes-logo-thumbnail.png',
  CONSTRAINT [PK_TB_USUARIOS] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO

ALTER TABLE [tb_postagens] WITH CHECK ADD CONSTRAINT [tb_postagens_fk0] FOREIGN KEY ([TemaId]) REFERENCES [tb_temas]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [tb_postagens] CHECK CONSTRAINT [tb_postagens_fk0]
GO
ALTER TABLE [tb_postagens] WITH CHECK ADD CONSTRAINT [tb_postagens_fk1] FOREIGN KEY ([UsuarioID]) REFERENCES [tb_usuarios]([id])
ON UPDATE CASCADE
GO
ALTER TABLE [tb_postagens] CHECK CONSTRAINT [tb_postagens_fk1]
GO


