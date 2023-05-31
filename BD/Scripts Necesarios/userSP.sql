/* ENEDB spes */
use ENEDB;

#call addUser('admin','123',1);
delimiter $$
create procedure addUser( 
in _userName varchar(100), 
#in _userLastName varchar(10), 
in _userPassEncripted varchar(100), 
in _userAdminMode boolean)
begin

	insert into users(
		userName,
        #userLastName,
        userPassEncripted,
        userAdminMode) 
	values( 
		_userName,
        #_userLastName,
        _userPassEncripted,
        _userAdminMode);
		

end $$

delimiter $$
create procedure delUser(
	in _userID int(100)
    )
    
begin
	delete from users where userID = _userID;
	
end$$
delimiter $$
create procedure editUserName( 
	in _userID int(100),
    in _userNewName varchar(15))
begin
	update users set userName = _userNewName where _userID = userID;
end$$
/*delimiter $$
create procedure editUserLastName(
	in _userID int(100),
    in _userNewLastName varchar(10)
    )
begin
	update users set userLastName = _userNewLastName where _userID = userID;
end $$ */
delimiter $$
create procedure editUserPasswd(
	in _userID int(100),
    in _userNewPasswd varchar(100)
    )
begin
	update users set userPassEncripted = _userNewPasswd where _userID = userID;
end $$
delimiter $$
create procedure editUserAdminMode(
	in _userID int(100),
    in _userAdminMode bool
    )
begin
	update users set userAdminMode = _userAdminMode where _userID = userID;
end $$

drop procedure check_user();
delimiter $$
create procedure check_user(
	in _userName varchar(100),
    in _userPass varchar(100)
    )
    
begin
	select * from users where userName = _userName and userPassEncripted = _userPass;
end $$

delimiter $$
create procedure list_user()
begin
	select username from users;
end $$

call addUser('Manuel Urra','123',1);
call addUser('Diego Alarcón','123',1);
call addUser('Lelouch','123',1);
call addUser('Kathleen Pitchkeen','123',1);
call addUser('Aitor Schumann','123',1);
call addUser('Schneider','123',1);
call addUser('Newton','123',1);
call addUser('Müller','123',1);

