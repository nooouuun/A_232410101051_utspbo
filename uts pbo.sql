create table etmin(
	pass_word varchar(255) not null,
	username varchar(255) not null,
	etmin_id serial primary key);	
alter table etmin add constraint  etmin_username_un unique (username);

create table pengguna(
	pass_word varchar(255) not null,
	username varchar(255) not null,
	pengguna_id serial primary key);	
alter table etmin add constraint  pengguna_username_un unique (username);

create table kontak(
	nama varchar(255) not null,
	email varchar(255) not null,
	NoHp varchar(15) not null,
	kontak_id serial primary key,
	pengguna_id integer not null);	
alter table kontak add constraint kontak_email_NoHp_un unique (email, NoHp);

alter table kontak
add constraint kontak_pengguna_fk foreign key (pengguna_id )
references pengguna (pengguna_id );
