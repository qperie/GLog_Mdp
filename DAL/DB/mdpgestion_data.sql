insert into compte values (1, 'titre', 'login', 'mdp', '2017-11-23', '2015-11-23');
insert into compte values (2, 'gmail', 'qperie@ensc.fr', 'monMdp', '2017-11-23', '2017-11-23');
insert into compte values (3, 'youtube', 'monMail', 'monAutreMdp', '2017-11-23', '2017-11-23');

insert into wifi values (1, 'SSID', 'mdp');
insert into wifi values (2, 'Bordeaux-inp', 'CAS');
insert into wifi values (3, 'SFR Wifi FON', 'unMdp');

insert into utilisateur values (1, 'login', 'mdp');
insert into utilisateur values (2, 'Quentin', 'mdpDeQuentin');
insert into utilisateur values (3, 'Juliette', 'mdpDeJuliette');

insert into liaisonUtilWifi values (1, 2, 1);
insert into liaisonUtilWifi values (2, 2, 2);
insert into liaisonUtilWifi values (3, 2, 3);
insert into liaisonUtilWifi values (4, 3, 2);
insert into liaisonUtilWifi values (5, 1, 1);

insert into liaisonUtilCompte values (1, 2, 1);
insert into liaisonUtilCompte values (2, 2, 2);
insert into liaisonUtilCompte values (3, 2, 3);
insert into liaisonUtilCompte values (4, 3, 3);
insert into liaisonUtilCompte values (5, 1, 1);