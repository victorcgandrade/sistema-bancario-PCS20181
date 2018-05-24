create table Estado(id serial, nome text, sigla text);
create table Pais(id serial, nome text);

create table Endereco (
	id serial,
	logradouro text,
	rua text,
	numero integer,
	bairro text,
	complemento text,
	cep text,
	cidade text,
	estado Estado
	pais Pais
);
create table Usuario (
	id serial,
	primeiroNome text,
	sobrenome text,
	cpf text, 
	rg	text
	);

create table Administrador(
	id integer,
	login text,
	senha text,
	constraint usuario_fk foreign key (id) references Usuario(id)
);

create type EstadoCliente as enum ('Ativo','Inativo','Bloqueado');
create type EstadoCivilCliente as enum ('Solteiro(a)','Casado(a)','Divorciado(a)','Viuvo(a)','Separado(a)');

create table Cliente(
	id integer,
	data_nascimento date,
	email text,
	telefone text,
	celular text,
	data_cadastro date,
	id_endereco integer,
	estadoCliente EstadoCliente,
	estadoCivil EstadoCivilCliente,	
	constraint usuario_fk foreign key (id) references Usuario(id),
	constraint endereco_fk foreign key (id_endereco) references Endereco(id)
);

create table Dependente(
	id integer,
	id_titular integer,
	constraint cliente_fk foreign key (id) references Cliente(id),
	constraint titular_fk foreign key (id_titular) references Cliente(id)
);

create table PessoaFisica(
	id integer,
	profissao text,
	rendaMensal decimal,
	constraint cliente_fk foreign key (id) references Cliente(id)
);

create type TipoPessoaJuridica as enum ('Sociedade_Ltda','Associacao','Fundacao');

create table PessoaJuridica(
	id integer,
	cnpj text,
	razaoSocial text,
	tipo TipoPessoaJuridica,
	constraint cliente_fk foreign key (id) references Cliente(id)
);

create type EstadoConta as enum ('Criada','Ativa','Com_pendencias','Inativa');

create table Conta(
	id serial,
	numero bigint,
	id_agencia integer,
	saldo decimal,
	senha integer,
	estado EstadoConta,
	id_cliente integer,
	constraint agencia_fk foreign key (id) references Agencia(id),
	constraint cliente_fk foreign key (id) references Cliente(id)
);

create table ContaCorrente(
	id integer,
	taxa decimal,
	limite decimal,
	constraint conta_fk foreign key (id) references Conta(id)
);

create table ContaPoupanca(
	id integer,
	variacao decimal,
	rendimento decimal,
	constraint conta_fk foreign key (id) references Conta(id)
);


	                                               