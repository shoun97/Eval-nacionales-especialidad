/* Requerimientos */
use ENEDB;
delimiter $$
create procedure addReq(

	in _typeReq varchar(50),
    in _desReq varchar(255),
    in _userReq varchar(25),
    in _priorityReq varchar (20)

)

begin
	
	insert into requirements(
		typeReq,
        desReq,
        userReqFK,
        priorityReq,
        dateReqInit,
        estado)
        values(
        _typereq,
        _desReq,
        _userReq,
        _priorityReq,
        curdate(),
        'Pendiente'
        );

end $$

delimiter $$
create procedure delReq(
	in _reqID int(100)
    )
begin
	delete from requirements where reqID = _reqID;
end $$

delimiter $$

create procedure editTypeReq(
	in _reqID int(100),
    in _typeReq varchar(50)
    )
    
begin
	
    update requeriments set typeReq = _typeReq where reqID = _reqID;

end$$

delimiter $$

create procedure editDesReq(
	in _reqID int(100),
    in _desReq varchar(250)
    )
begin

	update requeriments set desReq = _desReq where reqID = _reqID;

end $$

create procedure editUserReq(
	in _reqID int(100),
    in _userReq varchar(25))

begin
	update requeriments set userReq = _userReq where reqID = _reqID;
end $$

delimiter $$
create procedure editPriorityReq(
	in _reqID int(100),
    in _priorityReq int(1)
    )
begin
	update requirements set userReq = _userReq where reqID = _reqID;
end$$

/* datereqend será hecho con un if según los plazos pre definidos en la pauta*/
delimiter $$
create procedure showReqAll()
begin
	select reqID as ID, estado as "Estado", typeReq as "Tipo", desReq as "Descripción", userReqFK as Usuario, priorityReq as Prioridad, dateReqInit as "Fecha Inicio" from
    requirements;
end $$

delimiter $$
create procedure showReq(
	in _typeReq varchar(100),
    in _priorityReq varchar(20),
    in _estado varchar(20)
    )
begin
	select reqID as ID, estado as "Estado", typeReq as "Tipo", desReq as "Descripción", userReqFK as Usuario, priorityReq as Prioridad, dateReqInit as "Fecha Inicio" from
    requirements where estado = _estado and typeReq = _typeReq and priorityReq = _priorityReq;

end $$

delimiter $$
create procedure editEstadoReq(
	in _reqID int(100)
)
begin
	
    update requirements set estado = 'Resuelto' where reqID = _reqID;
    
end$$


/* Registros para empezar */
call addReq('Base De Datos','Creación de tablas','Manuel Urra','Alta');
call addReq('Base De Datos','Vistas de gestion','Kathleen Pitchkeen','Alta');
call addReq('Base De Datos','Creacion de Sepes','Aitor Schummann','Alta');
call addReq('Base De Datos','Mineria de datos','Manuel Urra','Media');
call addReq('Base De Datos','Vistas de gestión','Kathleen Pitschkeen','Media');
call addReq('Base De Datos','Creación de tablas','Aitor Schumann','Media');
call addReq('Base De Datos','Creacion de Sps','Manuel Urra','Baja');
call addReq('Base De Datos','Vistas de gestión','Kathleen Pitchkeen','Baja');
call addReq('Base De Datos','Creación de tablas','Aitor Schumann','Baja');

/*servidores*/

call addReq('Servidores','Crear servidores en Linux','Manuel Urra','Alta');
call addReq('Servidores','Optimizar Servidores','Kathleen Pitchkeen','Alta');
call addReq('Servidores','Cambiar puerto de los protocolos vulnerables','Aitor Schumann','Alta');
call addReq('Servidores','Optimizar Servidores','Manuel Urra','Media');
call addReq('Servidores','Cambiar puerto de los protocolos vulnerables','Kathleen Pitchkeen','Media');
call addReq('Servidores','Crear servidores en Linux','Aitor Schumann','Baja');

/* SIstemas */

call addReq('Sistemas','Hola, Buenas Tardes','Manuel Urra','Alta');
call addReq('Sistemas','Hallo, Guten Tag','Kathleen Pitchkeen','Media');
call addReq('Sistemas','Ich bin ein Mann','Aitor Schumann','Baja');
call addReq('Sistemas','Ich habe eine Deutsche Freundin','Manuel Urra','Alta');
call addReq('Sistemas','Ja, aber...','Kathleen Pitchkeen','Media');
call addReq('Sistemas','Du bist einen untermann Ja!','Aitor Schumann','Baja');