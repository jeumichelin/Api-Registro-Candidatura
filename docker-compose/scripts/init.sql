create database registro_candidatura;

\c registro_candidatura

CREATE TABLE public."RegistroCandidatura" (
	"ID" uuid NOT NULL,
	"NOME" text NULL,
	"SOBRENOME" text NULL,
	"DATA_NASCIMENTO" timestamp NOT NULL,
	"VAGA" text NULL,
	"PRETENSAO_SALARIAL" numeric NOT NULL,
	CONSTRAINT "PK_RegistroCandidatura" PRIMARY KEY ("ID")
);