use Library;


-- 读者类型
INSERT INTO readerType(typeName,borrowDuration,reBorrowNum) VALUES ('本科生',30,1)
INSERT INTO readerType(typeName,borrowDuration,reBorrowNum) VALUES ('研究生',45,1)
INSERT INTO readerType(typeName,borrowDuration,reBorrowNum) VALUES ('教职工',60,1)


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
INSERT INTO circuBookClass(isbn,bookName,mainAuthor,otherAuthor,publicationYear,CDName,price,bookNum)
VALUES ('9787040406641','数据库系统概论(第五版)','王珊','萨师煊','2014/9/1',null,39.6,5);
INSERT INTO circuBookClass(isbn,bookName,mainAuthor,otherAuthor,publicationYear,CDName,price,bookNum)
VALUES ('9787302330981','软件工程导论(第六版)','张海潘','牟永敏','2013/8/1',null,39.5,3);
INSERT INTO circuBookClass(isbn,bookName,mainAuthor,otherAuthor,publicationYear,CDName,price,bookNum)
VALUES ('9787121155352','C++ Primer(第五版)','Stanley','Josee Lajoie, Barbara E. Moo','2013/9/1',null,128.00,2);
INSERT INTO circuBookClass(isbn,bookName,mainAuthor,otherAuthor,publicationYear,CDName,price,bookNum)
VALUES ('9780387202488','PARSING TECHNIQUES A Practical Guide','Dick Grune','Geriel J.H. Jacobs','2074/9/1',null,1250,1);

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
INSERT INTO libraryCard(name,regTime,dueTime) VALUES ('liren','2017/7/7','2019/9/9')
INSERT INTO libraryCard(name,regTime,dueTime) VALUES ('qq','2017/7/7','2019/9/9')
INSERT INTO libraryCard(name,regTime,dueTime) VALUES ('liuzheng','2017/7/7','2019/9/9')


-- 读者
INSERT INTO reader(ID,libraryCardID,typeID,sex) VALUES ('431012199601012831',null,1,'男')
INSERT INTO reader(ID,libraryCardID,typeID,sex) VALUES ('431012199601012832',null,2,'男')
INSERT INTO reader(ID,libraryCardID,typeID,sex) VALUES ('431012199601012833',null,3,'男')
INSERT INTO reader(ID,libraryCardID,typeID,sex) VALUES ('431012199601012834',null,1,'女')
INSERT INTO reader(ID,libraryCardID,typeID,sex) VALUES ('431012199601012835',null,2,'女')
INSERT INTO reader(ID,libraryCardID,typeID,sex) VALUES ('431012199601012836',null,3,'女')







