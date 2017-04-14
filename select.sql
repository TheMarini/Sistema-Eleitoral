select * from cargo_eleicao_candidato
	where (cd_candidato = 10);
    
select * from cargo_eleicao_candidato;

Select E.nm_eleicao from eleicao E
	Join cargo_eleicao_candidato C on (C.cd_eleicao = E.cd_eleicao)
    where (cd_candidato = 10);
    
SELECT nm_candidato FROM candidato where (nm_candidato LIKE 'g%') order by nm_candidato;

SELECT nm_candidato FROM candidato where (sg_partido = 'PT') order by nm_candidato;

SELECT * FROM candidato where nm_candidato = 'Skaf';

select * from candidato;

Insert into candidato values ((select max(cd_candidato)+1 from candidato), 'Teste', 'PMDB');

select * from cargo_eleicao_candidato;

delete from cargo_eleicao_candidato where (cd_candidato = 10);

Select E.nm_eleicao from eleicao E
	Join eleicao_urna EU on (EU.cd_eleicao = E.cd_eleicao)
    Join urna U on (U.cd_urna = EU.cd_urna)
    where U.cd_urna = 1;