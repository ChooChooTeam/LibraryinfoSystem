use Library;


-- ��������
INSERT INTO readerType(typeName,borrowDuration,reBorrowNum) VALUES ('������',30,1)
INSERT INTO readerType(typeName,borrowDuration,reBorrowNum) VALUES ('�о���',45,1)
INSERT INTO readerType(typeName,borrowDuration,reBorrowNum) VALUES ('��ְ��',60,1)


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
INSERT INTO circuBookClass(isbn,bookName,mainAuthor,otherAuthor,publicationYear,CDName,price,bookNum)
VALUES ('9787040406641','���ݿ�ϵͳ����(�����)','��ɺ','��ʦ��','2014/9/1',null,39.6,5);
INSERT INTO circuBookClass(isbn,bookName,mainAuthor,otherAuthor,publicationYear,CDName,price,bookNum)
VALUES ('9787302330981','������̵���(������)','�ź���','Ĳ����','2013/8/1',null,39.5,3);
INSERT INTO circuBookClass(isbn,bookName,mainAuthor,otherAuthor,publicationYear,CDName,price,bookNum)
VALUES ('9787121155352','C++ Primer(�����)','Stanley','Josee Lajoie, Barbara E. Moo','2013/9/1',null,128.00,2);
INSERT INTO circuBookClass(isbn,bookName,mainAuthor,otherAuthor,publicationYear,CDName,price,bookNum)
VALUES ('9780387202488','PARSING TECHNIQUES A Practical Guide','Dick Grune','Geriel J.H. Jacobs','2074/9/1',null,1250,1);

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
INSERT INTO libraryCard(name,regTime,dueTime) VALUES ('liren','2017/7/7','2019/9/9')
INSERT INTO libraryCard(name,regTime,dueTime) VALUES ('qq','2017/7/7','2019/9/9')
INSERT INTO libraryCard(name,regTime,dueTime) VALUES ('liuzheng','2017/7/7','2019/9/9')


-- ����
INSERT INTO reader(ID,libraryCardID,typeID,sex) VALUES ('431012199601012831',null,1,'��')
INSERT INTO reader(ID,libraryCardID,typeID,sex) VALUES ('431012199601012832',null,2,'��')
INSERT INTO reader(ID,libraryCardID,typeID,sex) VALUES ('431012199601012833',null,3,'��')
INSERT INTO reader(ID,libraryCardID,typeID,sex) VALUES ('431012199601012834',null,1,'Ů')
INSERT INTO reader(ID,libraryCardID,typeID,sex) VALUES ('431012199601012835',null,2,'Ů')
INSERT INTO reader(ID,libraryCardID,typeID,sex) VALUES ('431012199601012836',null,3,'Ů')







