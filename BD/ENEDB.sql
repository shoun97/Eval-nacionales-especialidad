create database if not exists ENEDB;
#drop database ENEDB;
use ENEDB;

create table if not exists users(

	/*userID int auto_increment not null primary key, */
    userName varchar(100) not null primary key,
    /*userLastName varchar(10) not null,*/
    userPassEncripted varchar(100) not null,
    userAdminMode boolean default false

);

create table if not exists requirements(

	reqID int auto_increment not null primary key,
    typeReq varchar(50) not null,
    desReq varchar(255) not null,
    userReqFK varchar(20) not null,
    priorityReq varchar(20) not null,
    dateReqInit date not null,
    estado varchar(20) not null
    #dateReqEnd date not null
   

);



