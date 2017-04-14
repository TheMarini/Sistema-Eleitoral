DROP SCHEMA IF EXISTS Sistema_Eleitoral;
CREATE SCHEMA Sistema_Eleitoral;
USE Sistema_Eleitoral;

/* --- modulo de usuarios --- */
CREATE TABLE usuario(
	nm_login varchar(50) NOT NULL,
    nm_usuario varchar(150),
    nm_senha varchar(65) NOT NULL,
    constraint pk_nm_login primary key(nm_login)
);

CREATE TABLE modulo(
	cd_modulo int NOT NULL,
    nm_modulo varchar(150),
    nm_componente varchar(45),
    constraint pk_cd_modulo primary key(cd_modulo)
);

CREATE TABLE permissao_acesso(
	nm_login varchar(50),
    cd_modulo int NOT NULL,
    constraint pk_permissao_acesso primary key(nm_login, cd_modulo),
    constraint fk_nm_login foreign key (nm_login) references usuario(nm_login),
    constraint fk_cd_modulo foreign key (cd_modulo) references modulo(cd_modulo)
);

/* --- tabelas principais --- */
CREATE TABLE partido(
	sg_partido varchar(10) NOT NULL,
    nm_partido varchar(100) NOT NULL,
    cd_nr_partido int NOT NULL,
    constraint pk_sg_partido primary key (sg_partido)
);

CREATE TABLE candidato(
	cd_candidato int NOT NULL,
    nm_candidato varchar(150) NOT NULL,
    sg_partido varchar(10),
    constraint pk_cd_candidato primary key (cd_candidato),
    constraint fk_sg_partido foreign key (sg_partido) references partido(sg_partido)
);

CREATE TABLE cargo(
	cd_cargo int NOT NULL,
    nm_cargo varchar(150) NOT NULL,
    qt_digitos_cargo int,
    constraint pk_cd_cargo primary key(cd_cargo) 
);

CREATE TABLE eleicao(
	cd_eleicao int NOT NULL,
    nm_eleicao varchar(150) NOT NULL,
    dt_inicio_eleicao date,
    hr_inicio_eleicao time,
    dt_fim_eleicao date,
    hr_fim_eleicao time,
    qt_tempo_liberacao_urna int,
    constraint pk_cd_eleicao primary key(cd_eleicao)
);

CREATE TABLE cargo_eleicao(
	cd_cargo int NOT NULL,
    cd_eleicao int NOT NULL,
    cd_nr_ordem int,
    constraint pk_eleicao primary key(cd_cargo, cd_eleicao),
    constraint fk_cd_cargo foreign key(cd_cargo) references cargo(cd_cargo),
    constraint fk_cd_eleicao foreign key(cd_eleicao) references eleicao(cd_eleicao)
);

CREATE TABLE cargo_eleicao_candidato(
	cd_cargo int NOT NULL,
    cd_eleicao int NOT NULL,
    cd_candidato int NOT NULL,
    cd_nr_candidato int,
    constraint pk_cargo_eleicao_candidado primary key(cd_cargo, cd_eleicao, cd_candidato),
    constraint fk_cd_cargo_cargo_eleicao_candidato foreign key(cd_cargo) references cargo_eleicao(cd_cargo),
    constraint fk_cd_eleicao_cargo_eleicao_candidato foreign key(cd_eleicao) references cargo_eleicao(cd_eleicao),
    constraint fk_cd_candidato_cargo_eleicao_candidato foreign key(cd_candidato) references candidato(cd_candidato)
);

CREATE TABLE urna(
	cd_urna int NOT NULL,
    constraint pk_urna primary key(cd_urna)
);

CREATE TABLE eleicao_urna(
	cd_eleicao int NOT NULL,
    cd_urna int NOT NULL,
    ic_automatica bool,
    constraint pk_eleicao_urna primary key(cd_eleicao, cd_urna),
    constraint fk_cd_eleicao_eleicao_urna foreign key(cd_eleicao) references eleicao(cd_eleicao),
    constraint fk_cd_urna_eleicao_urna foreign key(cd_urna) references urna(cd_urna)
);

CREATE TABLE eleitor(
	cd_eleitor int NOT NULL,
    nm_eleitor varchar(150),
    cd_cpf_eleitor varchar(12),
    constraint pk_eleitor primary key(cd_eleitor)
);

CREATE TABLE eleitor_eleicao_urna(
	cd_eleitor int NOT NULL,
    cd_eleicao int NOT NULL,
    cd_urna int NOT NULL,
    ic_jaVotou bool,
    constraint pk_eleitor_eleicao_urna primary key(cd_eleitor, cd_eleicao, cd_urna),
    constraint fk_cd_eleicao_eleitor_eleicao_urna foreign key(cd_eleitor) references eleicao_urna(cd_eleicao),
    constraint fk_cd_urna_eleitor_eleicao_urna foreign key(cd_urna) references eleicao_urna(cd_urna)
);

CREATE TABLE votos(
	cd_urna int NOT NULL,
    cd_cargo int NOT NULL,
    cd_eleicao int NOT NULL,
    cd_candidato int NOT NULL,
    qt_votos int,
    constraint pk_votos primary key(cd_urna, cd_cargo, cd_eleicao, cd_candidato),
    constraint fk_cd_urna_votos foreign key(cd_urna) references urna(cd_urna),
    constraint fk_cd_cargo_votos foreign key(cd_cargo) references cargo_eleicao_candidato(cd_cargo),
    constraint fk_cd_eleicao_votos foreign key(cd_eleicao) references cargo_eleicao_candidato(cd_eleicao),
    constraint fk_cd_candidato_votos foreign key(cd_candidato) references cargo_eleicao_candidato(cd_candidato)
    
);

/* --- Massa de Testes --- */
INSERT INTO usuario values ('admin','Administrador',md5('admin'));
INSERT INTO usuario values ('leguth','Edson Leguth',md5('admin'));
INSERT INTO usuario values ('maristela','Maristela Carvalho Gamba',md5('admin'));
INSERT INTO usuario values ('tavares','Tavares',md5('admin'));

INSERT INTO modulo values (1,'Permissão de Acesso','mnuPermissao');
INSERT INTO modulo values (2,'Gerência de Usuários','mnuUsuarios');
INSERT INTO modulo values (3,'Gerência de Partidos','mnuPartidos');
INSERT INTO modulo values (4,'Gerência de Candidatos','mnuCandidatos');
INSERT INTO modulo values (5,'Gerência de Cargos','mnuCargo');
INSERT INTO modulo values (6,'Gerência de Urnas','mnuUrnas');
INSERT INTO modulo values (7,'Gerência de Eleitores','mnuEleitor');
INSERT INTO modulo values (8,'Gerência de Eleição','mnuEleicao');
INSERT INTO modulo values (9,'Gráfico de Votação','mnuGrafVotacao');

INSERT INTO `partido` (`sg_partido`,`nm_partido`,`cd_nr_partido`) VALUES 
 ('DEM','Democratas',25),
 ('NOVO','Partido Novo',30),
 ('PCB','Partido Comunista Brasileiro',21),
 ('PCdoB','Partido Comunista do Brasil',65),
 ('PCO','Partido da Causa Operária',29),
 ('PDT','Partido Democrático Trabalhista',12),
 ('PEN','Partido Ecológico Nacional',51),
 ('PHS','Partido Humanista da Solidariedade',31),
 ('PMB','Partido da Mulher Brasileira',35),
 ('PMDB','Partido do Movimento Democrático Brasileiro',15),
 ('PMN','Partido da Mobilização Nacional',33),
 ('PP','Partido Progressista',11),
 ('PPL','Partido Pátria Livre',54),
 ('PPS','Partido Popular Socialista',23),
 ('PR','Partido da República',22),
 ('PRB','Partido Republicano Brasileiro',10),
 ('PROS','Partido Republicano da Ordem Social',90),
 ('PRP','Partido Republicano Progressista',44),
 ('PRTB','Partido Renovador Trabalhista Brasileiro',28),
 ('PSB','Partido Socialista Brasileiro',40),
 ('PSC','Partido Social Cristão',20),
 ('PSD','Partido Social Democrático',55),
 ('PSDB','Partido da Social Democracia Brasileira',45),
 ('PSDC','Partido Social Democrata CRISTÃO',27),
 ('PSL','Partido Social Liberal',17),
 ('PSOL','Partido Socialismo e Liberdade',50),
 ('PSTU','Partido Socialista dos Trabalhadores Unificado',16),
 ('PT','Partido dos Trabalhadores',13),
 ('PTB','Partido Trabalhista Brasileiro',14),
 ('PTC','Partido Trabalhista Cristão',36),
 ('PTdoB','Partido Trabalhista do Brasil',70),
 ('PTN','Partido Trabalhaista Nacional',19),
 ('PV','Partido Verde',43),
 ('REDE','Rede Sustentabilidade',18),
 ('SD','Solidariedade',77);

INSERT INTO candidato values (1,'Geraldo Alckmin','PSDB');
INSERT INTO candidato values (2,'Skaf','PMDB');
INSERT INTO candidato values (3,'Padilha','PT');
INSERT INTO candidato values (4,'Gilberto Natalini','PV');
INSERT INTO candidato values (5,'Maringoni','PSOL');
INSERT INTO candidato values (6,'Laércio Benko','PHS');
INSERT INTO candidato values (7,'Walter Ciglioni','PRTB');
INSERT INTO candidato values (8,'Wagner Farias','PCB');
INSERT INTO candidato values (9,'Raimundo Sena','PCO');
INSERT INTO candidato values (10,'Dilma','PT');
INSERT INTO candidato values (11,'Aécio Neves','PSDB');
INSERT INTO candidato values (12,'Marina Silva','PSB');
INSERT INTO candidato values (13,'Luciana Genro','PSOL');
INSERT INTO candidato values (14,'Pastor Everaldo','PSC');
INSERT INTO candidato values (15,'Eduardo Jorge','PV');
INSERT INTO candidato values (16,'Levy Fidelix','PRTB');
INSERT INTO candidato values (17,'Zé Maria','PSTU');
INSERT INTO candidato values (18,'Eymael','PSDC');
INSERT INTO candidato values (19,'Mauro Iasi','PCB');
INSERT INTO candidato values (20,'Rui Costa Pimenta','PCO');

INSERT INTO `cargo` (`cd_cargo`,`nm_cargo`,`qt_digitos_cargo`) VALUES 
 (1,'Presidente da República',2),
 (2,'Deputado Federal',4),
 (3,'Senador',3),
 (4,'Governador',2),
 (5,'Deputado Estadual',5),
 (6,'Vereador',5),
 (7,' Prefeito',2);
 
INSERT INTO eleicao values (00001, 'Eleições 2016', current_date(),current_time(), current_date(),current_time(),10); 

INSERT INTO `cargo_eleicao` (`cd_cargo`,`cd_eleicao`,`cd_nr_ordem`) VALUES 
 (1,1,1),
 (4,1,2);

INSERT INTO `cargo_eleicao_candidato` (`cd_cargo`,`cd_eleicao`,`cd_candidato`,`cd_nr_candidato`) VALUES 
 (1,1,10,13),
 (1,1,11,45),
 (1,1,12,40),
 (1,1,13,50),
 (1,1,14,20),
 (1,1,15,43),
 (1,1,16,28),
 (1,1,17,16),
 (1,1,18,27),
 (1,1,19,21),
 (1,1,20,29),
 (4,1,1,45),
 (4,1,2,15),
 (4,1,3,13),
 (4,1,4,43),
 (4,1,5,50),
 (4,1,6,31),
 (4,1,7,28),
 (4,1,8,21),
 (4,1,9,29);

INSERT INTO `urna` (`cd_urna`) VALUES 
 (1),
 (2);

INSERT INTO `eleicao_urna` (`cd_eleicao`,`cd_urna`,`ic_automatica`) VALUES 
 (1,1,1),
 (1,2,1);