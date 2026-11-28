create database if not exists Hospital;
use Hospital;

create table if not exists Medico
(
 idMedico int auto_increment primary key,
 crmMedico char (6) unique not null,
 nomeMedico varchar (50) not null,
 especialidade varchar (50) not null,
 celularMedico varchar (11) not null, -- padronizado no codigo do formulario
 emailMedico varchar (150) not null,
 nascMedico date not null
) Engine = "InnoDB";

create table if not exists Paciente 
(
 idPaciente int auto_increment primary key,
 cpfPaciente varchar (11) unique not null,
 nomePaciente varchar (50) not null,
 nascPaciente date not null,
 fotoPaciente longblob,
 generoPaciente varchar (9) not null
) Engine = "InnoDB";

create table if not exists Agendamento 
(
 idAgend int auto_increment primary key,
 codAgend int not null,
 DataAgend datetime not null,
 StatusAgend varchar(20) not null default 'Agendado',
 idMedico_Agend int null,
 idPaciente_Agend int not null,
 foreign key (idMedico_Agend) REFERENCES Medico (idMedico),
 foreign key (idPaciente_Agend) REFERENCES Paciente (idPaciente)
) Engine = "InnoDB";

create table if not exists Atendimento
(
 idAtend int auto_increment primary key,
 DataAtend datetime default current_timestamp,
 CodAgend int not null,
 descAtend varchar (500) not null,
 idMedico_Atend int not null,
 idPaciente_Atend int not null,
 idAgend_Atend int not null,
 foreign key (idMedico_Atend) REFERENCES Medico (idMedico),
 foreign key (idPaciente_Atend) REFERENCES Paciente (idPaciente),
 foreign key (idAgend_Atend) REFERENCES Agendamento (idAgend)
)  Engine = "InnoDB";

Select
   a.idAgend,
   a.dataAgend,
   p.cpfPaciente,
   p.nomePaciente,
   p.nascPaciente,
   p.generoPaciente,
   p.fotoPaciente,
   m.nomeMedico,
   m.especialidade,
   m.celularMedico
From Agendamento a
Inner Join Paciente p on a.idPaciente_Agend = p.idPaciente
Inner Join Medico m on a.idMedico_Agend = m.idMedico;

