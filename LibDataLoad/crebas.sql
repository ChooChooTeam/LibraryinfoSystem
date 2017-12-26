/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     2017/12/26 17:46:46                          */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('borrowRecord') and o.name = 'FK_BORROWRE_RELATIONS_CIRCUBOO')
alter table borrowRecord
   drop constraint FK_BORROWRE_RELATIONS_CIRCUBOO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('borrowRecord') and o.name = 'FK_BORROWRE_RELATIONS_LIBRARYC')
alter table borrowRecord
   drop constraint FK_BORROWRE_RELATIONS_LIBRARYC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('circuBook') and o.name = 'FK_CIRCUBOO_RELATIONS_CIRCUBOO')
alter table circuBook
   drop constraint FK_CIRCUBOO_RELATIONS_CIRCUBOO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('circuBook') and o.name = 'FK_CIRCUBOO_RELATIONS_LIBRARY')
alter table circuBook
   drop constraint FK_CIRCUBOO_RELATIONS_LIBRARY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('damageRecord') and o.name = 'FK_DAMAGERE_RELATIONS_CIRCUBOO')
alter table damageRecord
   drop constraint FK_DAMAGERE_RELATIONS_CIRCUBOO
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('damageRecord') and o.name = 'FK_DAMAGERE_RELATIONS_LIBRARYC')
alter table damageRecord
   drop constraint FK_DAMAGERE_RELATIONS_LIBRARYC
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('damageRecord') and o.name = 'FK_DAMAGERE_RELATIONS_DAMAGERE')
alter table damageRecord
   drop constraint FK_DAMAGERE_RELATIONS_DAMAGERE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('libraryCard') and o.name = 'FK_LIBRARYC_RELATIONS_READERTY')
alter table libraryCard
   drop constraint FK_LIBRARYC_RELATIONS_READERTY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('reservedBook') and o.name = 'FK_RESERVED_RELATIONS_LIBRARY')
alter table reservedBook
   drop constraint FK_RESERVED_RELATIONS_LIBRARY
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('reservedBook') and o.name = 'FK_RESERVED_RELATIONS_RSERVEDB')
alter table reservedBook
   drop constraint FK_RESERVED_RELATIONS_RSERVEDB
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('borrowRecord')
            and   name  = 'Relationship_3_FK'
            and   indid > 0
            and   indid < 255)
   drop index borrowRecord.Relationship_3_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('borrowRecord')
            and   name  = 'Relationship_4_FK'
            and   indid > 0
            and   indid < 255)
   drop index borrowRecord.Relationship_4_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('borrowRecord')
            and   type = 'U')
   drop table borrowRecord
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('circuBook')
            and   name  = 'Relationship_8_FK'
            and   indid > 0
            and   indid < 255)
   drop index circuBook.Relationship_8_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('circuBook')
            and   name  = 'Relationship_1_FK'
            and   indid > 0
            and   indid < 255)
   drop index circuBook.Relationship_1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('circuBook')
            and   type = 'U')
   drop table circuBook
go

if exists (select 1
            from  sysobjects
           where  id = object_id('circuBookClass')
            and   type = 'U')
   drop table circuBookClass
go

if exists (select 1
            from  sysobjects
           where  id = object_id('damageReason')
            and   type = 'U')
   drop table damageReason
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('damageRecord')
            and   name  = 'Relationship_7_FK'
            and   indid > 0
            and   indid < 255)
   drop index damageRecord.Relationship_7_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('damageRecord')
            and   name  = 'Relationship_6_FK'
            and   indid > 0
            and   indid < 255)
   drop index damageRecord.Relationship_6_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('damageRecord')
            and   name  = 'Relationship_5_FK'
            and   indid > 0
            and   indid < 255)
   drop index damageRecord.Relationship_5_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('damageRecord')
            and   type = 'U')
   drop table damageRecord
go

if exists (select 1
            from  sysobjects
           where  id = object_id('library')
            and   type = 'U')
   drop table library
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('libraryCard')
            and   name  = 'Relationship_11_FK'
            and   indid > 0
            and   indid < 255)
   drop index libraryCard.Relationship_11_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('libraryCard')
            and   type = 'U')
   drop table libraryCard
go

if exists (select 1
            from  sysobjects
           where  id = object_id('readerType')
            and   type = 'U')
   drop table readerType
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('reservedBook')
            and   name  = 'Relationship_10_FK'
            and   indid > 0
            and   indid < 255)
   drop index reservedBook.Relationship_10_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('reservedBook')
            and   name  = 'Relationship_9_FK'
            and   indid > 0
            and   indid < 255)
   drop index reservedBook.Relationship_9_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('reservedBook')
            and   type = 'U')
   drop table reservedBook
go

if exists (select 1
            from  sysobjects
           where  id = object_id('rservedBookClass')
            and   type = 'U')
   drop table rservedBookClass
go

/*==============================================================*/
/* Table: borrowRecord                                          */
/*==============================================================*/
create table borrowRecord (
   borrowIndex          int                  identity,
   libraryCardID        int                  not null,
   circuBookNo          int                  not null,
   borrowDuration       datetime             not null,
   returnTime           datetime             null,
   dateToReturn         datetime             not null,
   renewNum             smallint             not null,
   constraint PK_BORROWRECORD primary key nonclustered (borrowIndex)
)
go

/*==============================================================*/
/* Index: Relationship_4_FK                                     */
/*==============================================================*/
create index Relationship_4_FK on borrowRecord (
libraryCardID ASC
)
go

/*==============================================================*/
/* Index: Relationship_3_FK                                     */
/*==============================================================*/
create index Relationship_3_FK on borrowRecord (
circuBookNo ASC
)
go

/*==============================================================*/
/* Table: circuBook                                             */
/*==============================================================*/
create table circuBook (
   circuBookNo          int                  identity,
   libaryID             int                  not null,
   isbn                 char(13)             not null,
   constraint PK_CIRCUBOOK primary key nonclustered (circuBookNo)
)
go

/*==============================================================*/
/* Index: Relationship_1_FK                                     */
/*==============================================================*/
create index Relationship_1_FK on circuBook (
isbn ASC
)
go

/*==============================================================*/
/* Index: Relationship_8_FK                                     */
/*==============================================================*/
create index Relationship_8_FK on circuBook (
libaryID ASC
)
go

/*==============================================================*/
/* Table: circuBookClass                                        */
/*==============================================================*/
create table circuBookClass (
   isbn                 char(13)             not null,
   bookName             char(50)             not null,
   mainAuthor           char(25)             not null,
   otherAuthor          char(30)             null,
   publicationYear      datetime             not null,
   publishingHouse      char(20)             not null,
   price                money                not null,
   bookNum              smallint             not null,
   constraint PK_CIRCUBOOKCLASS primary key (isbn)
)
go

/*==============================================================*/
/* Table: damageReason                                          */
/*==============================================================*/
create table damageReason (
   damgeReasonIndex     smallint             identity,
   damageExplain        text                 not null,
   constraint PK_DAMAGEREASON primary key nonclustered (damgeReasonIndex)
)
go

/*==============================================================*/
/* Table: damageRecord                                          */
/*==============================================================*/
create table damageRecord (
   damageIndex          int                  identity,
   damgeReasonIndex     smallint             not null,
   libraryCardID        int                  not null,
   circuBookNo          int                  not null,
   damageTime           datetime             not null,
   damageRtnTIme        datetime             null,
   damageMoney          money                not null,
   damageRemark         text                 null,
   constraint PK_DAMAGERECORD primary key nonclustered (damageIndex)
)
go

/*==============================================================*/
/* Index: Relationship_5_FK                                     */
/*==============================================================*/
create index Relationship_5_FK on damageRecord (
circuBookNo ASC
)
go

/*==============================================================*/
/* Index: Relationship_6_FK                                     */
/*==============================================================*/
create index Relationship_6_FK on damageRecord (
libraryCardID ASC
)
go

/*==============================================================*/
/* Index: Relationship_7_FK                                     */
/*==============================================================*/
create index Relationship_7_FK on damageRecord (
damgeReasonIndex ASC
)
go

/*==============================================================*/
/* Table: library                                               */
/*==============================================================*/
create table library (
   libaryID             int                  not null,
   libraryName          char(30)             not null,
   libraryLocation      char(90)             not null,
   constraint PK_LIBRARY primary key nonclustered (libaryID)
)
go

/*==============================================================*/
/* Table: libraryCard                                           */
/*==============================================================*/
create table libraryCard (
   libraryCardID        int                  identity(100000,1) not for replication,
   typeID               smallint             not null,
   name                 char(20)             not null,
   sex                  char(2)              not null,
   ID                   char(18)             not null,
   regTime              datetime             not null,
   dueTime              datetime             not null,
   constraint PK_LIBRARYCARD primary key nonclustered (libraryCardID)
)
go

/*==============================================================*/
/* Index: Relationship_11_FK                                    */
/*==============================================================*/
create index Relationship_11_FK on libraryCard (
typeID ASC
)
go

/*==============================================================*/
/* Table: readerType                                            */
/*==============================================================*/
create table readerType (
   typeID               smallint             identity,
   typeName             char(20)             not null,
   borrowDuration       datetime             not null,
   reBorrowNum          smallint             not null,
   constraint PK_READERTYPE primary key nonclustered (typeID)
)
go

/*==============================================================*/
/* Table: reservedBook                                          */
/*==============================================================*/
create table reservedBook (
   reservedBookNO       int                  identity,
   libaryID             int                  not null,
   isbn                 char(13)             not null,
   constraint PK_RESERVEDBOOK primary key nonclustered (reservedBookNO)
)
go

/*==============================================================*/
/* Index: Relationship_9_FK                                     */
/*==============================================================*/
create index Relationship_9_FK on reservedBook (
isbn ASC
)
go

/*==============================================================*/
/* Index: Relationship_10_FK                                    */
/*==============================================================*/
create index Relationship_10_FK on reservedBook (
libaryID ASC
)
go

/*==============================================================*/
/* Table: rservedBookClass                                      */
/*==============================================================*/
create table rservedBookClass (
   isbn                 char(13)             not null,
   bookName             char(50)             not null,
   mainAuthor           char(25)             not null,
   otherAuthor          char(30)             null,
   publicationYear      datetime             not null,
   publishingHouse      char(20)             not null,
   price                money                not null,
   bookNum              smallint             not null,
   constraint PK_RSERVEDBOOKCLASS primary key (isbn)
)
go

alter table borrowRecord
   add constraint FK_BORROWRE_RELATIONS_CIRCUBOO foreign key (circuBookNo)
      references circuBook (circuBookNo)
go

alter table borrowRecord
   add constraint FK_BORROWRE_RELATIONS_LIBRARYC foreign key (libraryCardID)
      references libraryCard (libraryCardID)
go

alter table circuBook
   add constraint FK_CIRCUBOO_RELATIONS_CIRCUBOO foreign key (isbn)
      references circuBookClass (isbn)
go

alter table circuBook
   add constraint FK_CIRCUBOO_RELATIONS_LIBRARY foreign key (libaryID)
      references library (libaryID)
go

alter table damageRecord
   add constraint FK_DAMAGERE_RELATIONS_CIRCUBOO foreign key (circuBookNo)
      references circuBook (circuBookNo)
go

alter table damageRecord
   add constraint FK_DAMAGERE_RELATIONS_LIBRARYC foreign key (libraryCardID)
      references libraryCard (libraryCardID)
go

alter table damageRecord
   add constraint FK_DAMAGERE_RELATIONS_DAMAGERE foreign key (damgeReasonIndex)
      references damageReason (damgeReasonIndex)
go

alter table libraryCard
   add constraint FK_LIBRARYC_RELATIONS_READERTY foreign key (typeID)
      references readerType (typeID)
go

alter table reservedBook
   add constraint FK_RESERVED_RELATIONS_LIBRARY foreign key (libaryID)
      references library (libaryID)
go

alter table reservedBook
   add constraint FK_RESERVED_RELATIONS_RSERVEDB foreign key (isbn)
      references rservedBookClass (isbn)
go

