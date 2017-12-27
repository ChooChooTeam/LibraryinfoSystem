use Library;


-- ��������
INSERT INTO readerType(typeName,borrowDuration,reBorrowNum,maxBorrowNum) VALUES ('������',30,1,30)
INSERT INTO readerType(typeName,borrowDuration,reBorrowNum,maxBorrowNum) VALUES ('�о���',45,1,40)
INSERT INTO readerType(typeName,borrowDuration,reBorrowNum,maxBorrowNum) VALUES ('��ְ��',60,1,50)


-- ��ԭ��
INSERT INTO damageReason(damageExplain) VALUES ('��Ϳ�һ�')
INSERT INTO damageReason(damageExplain) VALUES ('�鼮С�������')
INSERT INTO damageReason(damageExplain) VALUES ('�鼮���������')
INSERT INTO damageReason(damageExplain) VALUES ('�鼮��ʧ')

-- ͼ���
INSERT INTO library(libaryID,libraryName,libraryLocation) VALUES (1,'����ͼ���','����')
INSERT INTO library(libaryID,libraryName,libraryLocation) VALUES (2,'�Ϻ�ͼ���','�Ϻ�')
INSERT INTO library(libaryID,libraryName,libraryLocation) VALUES (3,'��Ժͼ���','��Ժ')


-- ��ͨ�鼮��
INSERT INTO circuBookClass(isbn,bookName,mainAuthor,otherAuthor,publicationYear,publishingHouse,price,bookNum)
VALUES ('9787040406641','���ݿ�ϵͳ����(�����)','��ɺ','��ʦ��','2014/9/1','�ߵȽ���������',39.6,5);
INSERT INTO circuBookClass(isbn,bookName,mainAuthor,otherAuthor,publicationYear,publishingHouse,price,bookNum)
VALUES ('9787302330981','������̵���(������)','�ź���','Ĳ����','2013/8/1','�廪��ѧ������',39.5,3);
INSERT INTO circuBookClass(isbn,bookName,mainAuthor,otherAuthor,publicationYear,publishingHouse,price,bookNum)
VALUES ('9787121155352','C++ Primer(�����)','Stanley','Josee Lajoie, Barbara E. Moo','2013/9/1','���ӹ�ҵ������',128.00,2);
INSERT INTO circuBookClass(isbn,bookName,mainAuthor,otherAuthor,publicationYear,publishingHouse,price,bookNum)
VALUES ('9780387202488','PARSING TECHNIQUES A Practical Guide','Dick Grune','Geriel J.H. Jacobs','2074/9/1','Springer Science',1250,1);

-- ʵ����ͨ�鼮

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

--���鿨
INSERT INTO libraryCard(typeID,name,sex,ID,regTime,dueTime) VALUES (1,'����','��','431012199601012831','2017/7/7','2019/9/9')
INSERT INTO libraryCard(typeID,name,sex,ID,regTime,dueTime) VALUES (1,'�����','��','431012199601012832','2017/7/7','2019/9/9')
INSERT INTO libraryCard(typeID,name,sex,ID,regTime,dueTime) VALUES (1,'�ߺ��','��','431012199601012833','2017/7/7','2019/9/9')
INSERT INTO libraryCard(typeID,name,sex,ID,regTime,dueTime) VALUES (1,'���׳','��','431012199601012834','2015/2/7','2035/9/1')
INSERT INTO libraryCard(typeID,name,sex,ID,regTime,dueTime) VALUES (2,'�Ŵ���','Ů','431012199601012835','2017/2/9','2020/9/1')
INSERT INTO libraryCard(typeID,name,sex,ID,regTime,dueTime) VALUES (3,'��С','Ů','431012199601012836','2010/1/1','2035/9/1')






--�����¼
insert into borrowRecord values(100001,1,'2017/3/4',null,'2017/4/8',1);
insert into borrowRecord values(100001,2,'2017/7/2',null,'2017/9/8',0);
insert into borrowRecord values(100004,3,'2017/2/9',null,'2017/2/19',1);
insert into borrowRecord values(100005,4,'2017/7/2',null,'2017/8/7',0);