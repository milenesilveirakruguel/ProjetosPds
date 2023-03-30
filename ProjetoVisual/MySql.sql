CREATE DATABASE app_contato_bd;
Use app_contato_bd;

create table contato (
id_con int not null auto_increment primary key,
nome_con varchar(100) not null,
data_nas_con date not null,
sexo_con varchar(30) not null,
email_con varchar(100) not null,
telefone_con varchar(20) not null
);

insert into contato (id_con, nome_con, data_nas_con, sexo_con, email_con, telefone_con) values (1, 'Judy Willmetts', '2022-11-30', 'Female', 'jwillmetts0@360.cn', '932-300-8684');
insert into contato (id_con, nome_con, data_nas_con, sexo_con, email_con, telefone_con) values (2, 'Axel Trayford', '2022-07-18', 'Male', 'atrayford1@gizmodo.com', '381-594-4939');
insert into contato (id_con, nome_con, data_nas_con, sexo_con, email_con, telefone_con) values (3, 'Gregor Roycraft', '2022-12-10', 'Male', 'groycraft2@so-net.ne.jp', '153-292-1158');
insert into contato (id_con, nome_con, data_nas_con, sexo_con, email_con, telefone_con) values (4, 'Jake Dumblton', '2022-06-13', 'Male', 'jdumblton3@dedecms.com', '581-601-0024');
insert into contato (id_con, nome_con, data_nas_con, sexo_con, email_con, telefone_con) values (5, 'Gunter Sprosson', '2022-06-30', 'Male', 'gsprosson4@youtube.com', '898-824-6663');
insert into contato (id_con, nome_con, data_nas_con, sexo_con, email_con, telefone_con) values (6, 'Alysa Costellow', '2022-08-25', 'Female', 'acostellow5@businessinsider.com', '725-394-2030');
insert into contato (id_con, nome_con, data_nas_con, sexo_con, email_con, telefone_con) values (7, 'Sydney Grelik', '2022-09-17', 'Male', 'sgrelik6@archive.org', '239-488-6159');
insert into contato (id_con, nome_con, data_nas_con, sexo_con, email_con, telefone_con) values (8, 'Pedro Sweeting', '2022-06-26', 'Male', 'psweeting7@arstechnica.com', '986-513-9014');
insert into contato (id_con, nome_con, data_nas_con, sexo_con, email_con, telefone_con) values (9, 'Elijah Doore', '2022-09-07', 'Male', 'edoore8@infoseek.co.jp', '701-484-2421');
insert into contato (id_con, nome_con, data_nas_con, sexo_con, email_con, telefone_con) values (10, 'Dirk Bulcock', '2023-02-15', 'Male', 'dbulcock9@bluehost.com', '424-809-7992');

select * from contato;