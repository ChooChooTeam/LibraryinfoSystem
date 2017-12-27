use Library;


-- 读者类型
INSERT INTO readerType(typeName,borrowDuration,reBorrowNum,maxBorrowNum) VALUES ('本科生',30,1,30)
INSERT INTO readerType(typeName,borrowDuration,reBorrowNum,maxBorrowNum) VALUES ('研究生',45,1,40)
INSERT INTO readerType(typeName,borrowDuration,reBorrowNum,maxBorrowNum) VALUES ('教职工',60,1,50)


-- 损坏原因
INSERT INTO damageReason(damageExplain) VALUES ('乱涂乱画')
INSERT INTO damageReason(damageExplain) VALUES ('书籍小面积破损')
INSERT INTO damageReason(damageExplain) VALUES ('书籍大面积破损')
INSERT INTO damageReason(damageExplain) VALUES ('书籍丢失')

-- 图书馆
INSERT INTO library(libaryID,libraryName,libraryLocation) VALUES (1,'余区图书馆','余区')
INSERT INTO library(libaryID,libraryName,libraryLocation) VALUES (2,'南湖图书馆','南湖')
INSERT INTO library(libaryID,libraryName,libraryLocation) VALUES (3,'东院图书馆','东院')


-- 流通书籍类
INSERT INTO circuBookClass(isbn,bookName,mainAuthor,otherAuthor,publicationYear,publishingHouse,price,bookNum)
VALUES ('9787040406641','数据库系统概论(第五版)','王珊','萨师煊','2014/9/1','高等教育出版社',39.6,5);
INSERT INTO circuBookClass(isbn,bookName,mainAuthor,otherAuthor,publicationYear,publishingHouse,price,bookNum)
VALUES ('9787302330981','软件工程导论(第六版)','张海潘','牟永敏','2013/8/1','清华大学出版社',39.5,3);
INSERT INTO circuBookClass(isbn,bookName,mainAuthor,otherAuthor,publicationYear,publishingHouse,price,bookNum)
VALUES ('9787121155352','C++ Primer(第五版)','Stanley','Josee Lajoie, Barbara E. Moo','2013/9/1','电子工业出版社',128.00,2);
INSERT INTO circuBookClass(isbn,bookName,mainAuthor,otherAuthor,publicationYear,publishingHouse,price,bookNum)
VALUES ('9780387202488','PARSING TECHNIQUES A Practical Guide','Dick Grune','Geriel J.H. Jacobs','2074/9/1','Springer Science',1250,1);

-- 实际流通书籍

INSERT INTO circuBook(libaryID,isbn) VALUES (1,'9787040406641')
INSERT INTO circuBook(libaryID,isbn) VALUES (1,'9787040406641')
INSERT INTO circuBook(libaryID,isbn) VALUES (2,'9787040406641')
INSERT INTO circuBook(libaryID,isbn) VALUES (2,'9787040406641')
INSERT INTO circuBook(libaryID,isbn) VALUES (3,'9787040406641')
INSERT INTO circuBook(libaryID,isbn) VALUES (1,'9787302330981')
INSERT INTO circuBook(libaryID,isbn) VALUES (2,'9787302330981')
INSERT INTO circuBook(libaryID,isbn) VALUES (3,'9787302330981')
INSERT INTO circuBook(libaryID,isbn) VALUES (1,'9787121155352')
INSERT INTO circuBook(libaryID,isbn) VALUES (2,'9787121155352')
INSERT INTO circuBook(libaryID,isbn) VALUES (1,'9780387202488')

--读书卡
INSERT INTO libraryCard(typeID,name,sex,ID,regTime,dueTime) VALUES (1,'李韧','男','431012199601012831','2017/7/7','2019/9/9')
INSERT INTO libraryCard(typeID,name,sex,ID,regTime,dueTime) VALUES (1,'李慧庆','男','431012199601012832','2017/7/7','2019/9/9')
INSERT INTO libraryCard(typeID,name,sex,ID,regTime,dueTime) VALUES (1,'边洪佳','男','431012199601012833','2017/7/7','2019/9/9')
INSERT INTO libraryCard(typeID,name,sex,ID,regTime,dueTime) VALUES (1,'李大壮','男','431012199601012834','2015/2/7','2035/9/1')
INSERT INTO libraryCard(typeID,name,sex,ID,regTime,dueTime) VALUES (2,'张春花','女','431012199601012835','2017/2/9','2020/9/1')
INSERT INTO libraryCard(typeID,name,sex,ID,regTime,dueTime) VALUES (3,'陈小','女','431012199601012836','2010/1/1','2035/9/1')






--借书记录
insert into borrowRecord values(100001,1,'2017/3/4',null,'2017/4/8',1);
insert into borrowRecord values(100001,2,'2017/7/2',null,'2017/9/8',0);
insert into borrowRecord values(100004,3,'2017/2/9',null,'2017/2/19',1);
insert into borrowRecord values(100005,4,'2017/7/2',null,'2017/8/7',0);