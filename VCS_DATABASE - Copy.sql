--------------------------------------------------------
--  File created - Friday-June-21-2019   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table VCS_DATABASE
--------------------------------------------------------

  CREATE TABLE "SYSTEM"."VCS_DATABASE" 
   (	"ID" VARCHAR2(90 BYTE), 
	"COMMIT" VARCHAR2(190 BYTE), 
	"FILESTORE" BLOB, 
	"VERSION_N" VARCHAR2(90 BYTE), 
	"FILENAME" VARCHAR2(90 BYTE), 
	"DIRECTORY_NAME" VARCHAR2(300 BYTE), 
	"RANDOM_NUMBER" VARCHAR2(90 BYTE), 
	"OWNER" VARCHAR2(90 BYTE), 
	"DATE_NOW" VARCHAR2(90 BYTE)
   ) PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" 
 LOB ("FILESTORE") STORE AS BASICFILE (
  TABLESPACE "SYSTEM" ENABLE STORAGE IN ROW CHUNK 8192 RETENTION 
  NOCACHE LOGGING 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)) ;
REM INSERTING into SYSTEM.VCS_DATABASE
SET DEFINE OFF;
Insert into SYSTEM.VCS_DATABASE (ID,COMMIT,VERSION_N,FILENAME,DIRECTORY_NAME,RANDOM_NUMBER,OWNER,DATE_NOW) values ('433','fist commit','V1','tables1 - Copy.html','E:\css project\tables1 - Copy.html','33323','user2@gmail.com','21-Jun-19 9:37:14 PM');
Insert into SYSTEM.VCS_DATABASE (ID,COMMIT,VERSION_N,FILENAME,DIRECTORY_NAME,RANDOM_NUMBER,OWNER,DATE_NOW) values ('434','fist commit','V1','css project.iml','E:\css project\.idea\css project.iml','95269','user2@gmail.com','21-Jun-19 9:37:14 PM');
Insert into SYSTEM.VCS_DATABASE (ID,COMMIT,VERSION_N,FILENAME,DIRECTORY_NAME,RANDOM_NUMBER,OWNER,DATE_NOW) values ('435','fist commit','V1','modules.xml','E:\css project\.idea\modules.xml','11649','user2@gmail.com','21-Jun-19 9:37:14 PM');
Insert into SYSTEM.VCS_DATABASE (ID,COMMIT,VERSION_N,FILENAME,DIRECTORY_NAME,RANDOM_NUMBER,OWNER,DATE_NOW) values ('436','fist commit','V1','workspace.xml','E:\css project\.idea\workspace.xml','5360','user2@gmail.com','21-Jun-19 9:37:14 PM');
Insert into SYSTEM.VCS_DATABASE (ID,COMMIT,VERSION_N,FILENAME,DIRECTORY_NAME,RANDOM_NUMBER,OWNER,DATE_NOW) values ('437','fist commit','V1','1.html','E:\css project\flexbox\1.html','49710','user2@gmail.com','21-Jun-19 9:37:14 PM');
Insert into SYSTEM.VCS_DATABASE (ID,COMMIT,VERSION_N,FILENAME,DIRECTORY_NAME,RANDOM_NUMBER,OWNER,DATE_NOW) values ('438','fist commit','V1','style.css','E:\css project\flexbox\style.css','84067','user2@gmail.com','21-Jun-19 9:37:14 PM');
Insert into SYSTEM.VCS_DATABASE (ID,COMMIT,VERSION_N,FILENAME,DIRECTORY_NAME,RANDOM_NUMBER,OWNER,DATE_NOW) values ('423','fist commit','V1','New Text Document (2).txt','E:\css project\New Text Document (2).txt','44529','user2@gmail.com','21-Jun-19 9:37:14 PM');
Insert into SYSTEM.VCS_DATABASE (ID,COMMIT,VERSION_N,FILENAME,DIRECTORY_NAME,RANDOM_NUMBER,OWNER,DATE_NOW) values ('424','fist commit','V1','New Text Document.txt','E:\css project\New Text Document.txt','39859','user2@gmail.com','21-Jun-19 9:37:14 PM');
Insert into SYSTEM.VCS_DATABASE (ID,COMMIT,VERSION_N,FILENAME,DIRECTORY_NAME,RANDOM_NUMBER,OWNER,DATE_NOW) values ('425','fist commit','V1','position_fixed.html','E:\css project\position_fixed.html','18960','user2@gmail.com','21-Jun-19 9:37:14 PM');
Insert into SYSTEM.VCS_DATABASE (ID,COMMIT,VERSION_N,FILENAME,DIRECTORY_NAME,RANDOM_NUMBER,OWNER,DATE_NOW) values ('426','fist commit','V1','position_relative.html','E:\css project\position_relative.html','76034','user2@gmail.com','21-Jun-19 9:37:14 PM');
Insert into SYSTEM.VCS_DATABASE (ID,COMMIT,VERSION_N,FILENAME,DIRECTORY_NAME,RANDOM_NUMBER,OWNER,DATE_NOW) values ('427','fist commit','V1','position_static.html','E:\css project\position_static.html','91125','user2@gmail.com','21-Jun-19 9:37:14 PM');
Insert into SYSTEM.VCS_DATABASE (ID,COMMIT,VERSION_N,FILENAME,DIRECTORY_NAME,RANDOM_NUMBER,OWNER,DATE_NOW) values ('428','fist commit','V1','table2.html','E:\css project\table2.html','93834','user2@gmail.com','21-Jun-19 9:37:14 PM');
Insert into SYSTEM.VCS_DATABASE (ID,COMMIT,VERSION_N,FILENAME,DIRECTORY_NAME,RANDOM_NUMBER,OWNER,DATE_NOW) values ('429','fist commit','V1','table3.html','E:\css project\table3.html','32580','user2@gmail.com','21-Jun-19 9:37:14 PM');
Insert into SYSTEM.VCS_DATABASE (ID,COMMIT,VERSION_N,FILENAME,DIRECTORY_NAME,RANDOM_NUMBER,OWNER,DATE_NOW) values ('421','fist commit','V1','nav1.html','E:\css project\nav1.html','19331','user2@gmail.com','21-Jun-19 9:37:13 PM');
Insert into SYSTEM.VCS_DATABASE (ID,COMMIT,VERSION_N,FILENAME,DIRECTORY_NAME,RANDOM_NUMBER,OWNER,DATE_NOW) values ('422','fist commit','V1','New Microsoft Excel Worksheet.xlsx','E:\css project\New Microsoft Excel Worksheet.xlsx','6812','user2@gmail.com','21-Jun-19 9:37:13 PM');
Insert into SYSTEM.VCS_DATABASE (ID,COMMIT,VERSION_N,FILENAME,DIRECTORY_NAME,RANDOM_NUMBER,OWNER,DATE_NOW) values ('430','fist commit','V1','tables1 - Copy - Copy (2).html','E:\css project\tables1 - Copy - Copy (2).html','89047','user2@gmail.com','21-Jun-19 9:37:14 PM');
Insert into SYSTEM.VCS_DATABASE (ID,COMMIT,VERSION_N,FILENAME,DIRECTORY_NAME,RANDOM_NUMBER,OWNER,DATE_NOW) values ('431','fist commit','V1','tables1 - Copy - Copy (4).html','E:\css project\tables1 - Copy - Copy (4).html','26421','user2@gmail.com','21-Jun-19 9:37:14 PM');
Insert into SYSTEM.VCS_DATABASE (ID,COMMIT,VERSION_N,FILENAME,DIRECTORY_NAME,RANDOM_NUMBER,OWNER,DATE_NOW) values ('432','fist commit','V1','tables1 - Copy - Copy.html','E:\css project\tables1 - Copy - Copy.html','50600','user2@gmail.com','21-Jun-19 9:37:14 PM');
--------------------------------------------------------
--  DDL for Index VCS_DATABASE_PK
--------------------------------------------------------

  CREATE UNIQUE INDEX "SYSTEM"."VCS_DATABASE_PK" ON "SYSTEM"."VCS_DATABASE" ("ID") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Trigger VCS_DATABASE_TRG
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "SYSTEM"."VCS_DATABASE_TRG" 
BEFORE INSERT ON VCS_DATABASE 
FOR EACH ROW 
BEGIN
  <<COLUMN_SEQUENCES>>
  BEGIN
    NULL;
  END COLUMN_SEQUENCES;
END;
/
ALTER TRIGGER "SYSTEM"."VCS_DATABASE_TRG" ENABLE;
--------------------------------------------------------
--  DDL for Trigger VCS_DATABASE_TRG1
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "SYSTEM"."VCS_DATABASE_TRG1" 
BEFORE INSERT ON VCS_DATABASE 
FOR EACH ROW 
BEGIN
  <<COLUMN_SEQUENCES>>
  BEGIN
    NULL;
  END COLUMN_SEQUENCES;
END;
/
ALTER TRIGGER "SYSTEM"."VCS_DATABASE_TRG1" ENABLE;
--------------------------------------------------------
--  DDL for Trigger VCS_DATABASE_TRG2
--------------------------------------------------------

  CREATE OR REPLACE TRIGGER "SYSTEM"."VCS_DATABASE_TRG2" 
BEFORE INSERT ON VCS_DATABASE 
FOR EACH ROW 
BEGIN
  <<COLUMN_SEQUENCES>>
  BEGIN
    IF INSERTING AND :NEW.ID IS NULL THEN
      SELECT VCS_DATABASE_SEQ2.NEXTVAL INTO :NEW.ID FROM SYS.DUAL;
    END IF;
  END COLUMN_SEQUENCES;
END;
/
ALTER TRIGGER "SYSTEM"."VCS_DATABASE_TRG2" ENABLE;
--------------------------------------------------------
--  Constraints for Table VCS_DATABASE
--------------------------------------------------------

  ALTER TABLE "SYSTEM"."VCS_DATABASE" ADD CONSTRAINT "VCS_DATABASE_PK" PRIMARY KEY ("ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
  ALTER TABLE "SYSTEM"."VCS_DATABASE" MODIFY ("ID" NOT NULL ENABLE);
