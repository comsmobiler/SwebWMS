using System;
using System.Data.Entity.Migrations;
using SMOWMS.Domain.Entity;

namespace SMOWMS.Infrastructure.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<SMOWMSDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SMOWMSDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.coreUsers.AddOrUpdate(
                new coreUser { USER_ID = "13123456789", USER_ADDRESS = "����", USER_BIRTHDAY = DateTime.Now, USER_NAME = "����", USER_ROLE = "ADMIN", USER_PASSWORD = "123456", USER_LOCATIONID = "01", USER_SEX = 0 },
                new coreUser { USER_ID = "12345678912", USER_ADDRESS = "����", USER_BIRTHDAY = DateTime.Now, USER_NAME = "����", USER_ROLE = "ADMIN", USER_PASSWORD = "123456", USER_LOCATIONID = "01", USER_SEX = 0 },
                new coreUser { USER_ID = "12345678913", USER_ADDRESS = "�Ϻ�", USER_BIRTHDAY = DateTime.Now, USER_NAME = "����", USER_ROLE = "SMOWMSADMIN", USER_PASSWORD = "123456", USER_LOCATIONID = "02", USER_SEX = 0 },
                new coreUser { USER_ID = "12345678914", USER_ADDRESS = "֣��", USER_BIRTHDAY = DateTime.Now, USER_NAME = "����", USER_ROLE = "SMOWMSADMIN", USER_PASSWORD = "123456", USER_LOCATIONID = "03", USER_SEX = 0 },
                new coreUser { USER_ID = "12345678915", USER_ADDRESS = "����", USER_BIRTHDAY = DateTime.Now, USER_NAME = "�Զ�", USER_ROLE = "ADMIN", USER_PASSWORD = "123456", USER_LOCATIONID = "01", USER_SEX = 0 },
                new coreUser { USER_ID = "12345678916", USER_ADDRESS = "�Ϻ�", USER_BIRTHDAY = DateTime.Now, USER_NAME = "��Ǯ", USER_ROLE = "SMOWMSUSER", USER_PASSWORD = "123456", USER_LOCATIONID = "02", USER_SEX = 0 },
                new coreUser { USER_ID = "12345678917", USER_ADDRESS = "����", USER_BIRTHDAY = DateTime.Now, USER_NAME = "���", USER_ROLE = "SMOWMSUSER", USER_PASSWORD = "123456", USER_LOCATIONID = "01", USER_ISDEMO = 1, USER_SEX = 0 }
                );
            context.AssetsTypes.AddOrUpdate(
                new AssetsType { TYPEID = "01", EXPIRYDATE = 8, EXPIRYDATEUNIT = 1, ISENABLE = 1, NAME = "��������", TLEVEL = 1, CREATEUSER = "12345678912" },
                new AssetsType { TYPEID = "02", EXPIRYDATE = 8, EXPIRYDATEUNIT = 1, ISENABLE = 1, NAME = "�������", TLEVEL = 1, CREATEUSER = "12345678912" },
                new AssetsType { TYPEID = "03", EXPIRYDATE = 8, EXPIRYDATEUNIT = 1, ISENABLE = 1, NAME = "��������", TLEVEL = 1, CREATEUSER = "12345678912" },
                new AssetsType { TYPEID = "04", EXPIRYDATE = 8, EXPIRYDATEUNIT = 1, ISENABLE = 1, NAME = "����Ӳ��", TLEVEL = 1, CREATEUSER = "12345678912" },
                new AssetsType { TYPEID = "05", EXPIRYDATE = 9, EXPIRYDATEUNIT = 1, ISENABLE = 1, NAME = "�칫�豸", TLEVEL = 1, CREATEUSER = "12345678912" },
                new AssetsType { TYPEID = "06", EXPIRYDATE = 10, EXPIRYDATEUNIT = 1, ISENABLE = 1, NAME = "�ʼǱ�", TLEVEL = 2, PARENTTYPEID = "01", CREATEUSER = "12345678912" },
                new AssetsType { TYPEID = "07", EXPIRYDATE = 10, EXPIRYDATEUNIT = 1, ISENABLE = 1, NAME = "̨ʽ��", TLEVEL = 2, PARENTTYPEID = "01", CREATEUSER = "12345678912" },
                new AssetsType { TYPEID = "08", EXPIRYDATE = 10, EXPIRYDATEUNIT = 1, ISENABLE = 1, NAME = "ƽ��", TLEVEL = 2, PARENTTYPEID = "01", CREATEUSER = "12345678912" },
                new AssetsType { TYPEID = "09", EXPIRYDATE = 10, EXPIRYDATEUNIT = 1, ISENABLE = 1, NAME = "��ʾ��", TLEVEL = 2, PARENTTYPEID = "02", CREATEUSER = "12345678912" },
                new AssetsType { TYPEID = "10", EXPIRYDATE = 10, EXPIRYDATEUNIT = 1, ISENABLE = 1, NAME = "��̬Ӳ��", TLEVEL = 2, PARENTTYPEID = "02", CREATEUSER = "12345678912" },
                new AssetsType { TYPEID = "11", EXPIRYDATE = 10, EXPIRYDATEUNIT = 1, ISENABLE = 1, NAME = "Ӳ��", TLEVEL = 2, PARENTTYPEID = "02", CREATEUSER = "12345678912" },
                new AssetsType { TYPEID = "12", EXPIRYDATE = 10, EXPIRYDATEUNIT = 1, ISENABLE = 1, NAME = "�ڴ���", TLEVEL = 2, PARENTTYPEID = "02", CREATEUSER = "12345678912" },
                new AssetsType { TYPEID = "13", EXPIRYDATE = 10, EXPIRYDATEUNIT = 1, ISENABLE = 1, NAME = "����", TLEVEL = 2, PARENTTYPEID = "03", CREATEUSER = "12345678912" },
                new AssetsType { TYPEID = "14", EXPIRYDATE = 10, EXPIRYDATEUNIT = 1, ISENABLE = 1, NAME = "���", TLEVEL = 2, PARENTTYPEID = "03", CREATEUSER = "12345678912" },
                new AssetsType { TYPEID = "15", EXPIRYDATE = 10, EXPIRYDATEUNIT = 1, ISENABLE = 1, NAME = "·����", TLEVEL = 2, PARENTTYPEID = "04", CREATEUSER = "12345678912" },
                new AssetsType { TYPEID = "16", EXPIRYDATE = 10, EXPIRYDATEUNIT = 1, ISENABLE = 1, NAME = "������", TLEVEL = 2, PARENTTYPEID = "04", CREATEUSER = "12345678912" },
                new AssetsType { TYPEID = "17", EXPIRYDATE = 10, EXPIRYDATEUNIT = 1, ISENABLE = 1, NAME = "ͶӰ��", TLEVEL = 2, PARENTTYPEID = "05", CREATEUSER = "12345678912" },
                new AssetsType { TYPEID = "18", EXPIRYDATE = 10, EXPIRYDATEUNIT = 1, ISENABLE = 1, NAME = "�෽ͨ����", TLEVEL = 2, PARENTTYPEID = "05", CREATEUSER = "12345678912" },
                new AssetsType { TYPEID = "19", EXPIRYDATE = 10, EXPIRYDATEUNIT = 1, ISENABLE = 1, NAME = "��ӡ��", TLEVEL = 2, PARENTTYPEID = "05", CREATEUSER = "12345678912" },
                new AssetsType { TYPEID = "20", EXPIRYDATE = 10, EXPIRYDATEUNIT = 1, ISENABLE = 1, NAME = "���ڻ�", TLEVEL = 2, PARENTTYPEID = "05", CREATEUSER = "12345678912" },
                new AssetsType { TYPEID = "21", EXPIRYDATE = 10, EXPIRYDATEUNIT = 1, ISENABLE = 1, NAME = "��ֽ��", TLEVEL = 2, PARENTTYPEID = "05", CREATEUSER = "12345678912" }
                );
//            context.AssLocations.AddOrUpdate(
//                new AssLocation { LOCATIONID = "01", NAME = "����", ISENABLE = 1, MANAGER = "12345678912" },
//                new AssLocation { LOCATIONID = "02", NAME = "�Ϻ�", ISENABLE = 1, MANAGER = "12345678913" },
//                new AssLocation { LOCATIONID = "04", NAME = "����", ISENABLE = 0, MANAGER = "12345678913" },
//                new AssLocation { LOCATIONID = "03", NAME = "֣��", ISENABLE = 1, MANAGER = "12345678914" }
//                );
            context.Assetss.AddOrUpdate(
                new Assets { ASSID = "AS2018041101", BUYDATE = DateTime.Now, TEMPLATEID = "AT20180401", EXPIRYDATE = DateTime.Now.AddYears(2), IMAGE = "2014.jpg", SLID = "01", CREATEDATE = DateTime.Now, CREATEUSER = "12345678912", MODIFYDATE = DateTime.Now, MODIFYUSER = "12345678912", TYPEID = "01", STATUS = 0, NAME = "����E999", UNIT = "̨", PRICE = 5000, SN = "2001",WAREID = "01",STID = "01",ISINWAREHOUSE = 1},
                new Assets { ASSID = "AS2018041102", BUYDATE = DateTime.Now, TEMPLATEID = "AT20180401", EXPIRYDATE = DateTime.Now.AddYears(2), IMAGE = "2014.jpg", SLID = "02", CREATEDATE = DateTime.Now, CREATEUSER = "12345678912", MODIFYDATE = DateTime.Now, MODIFYUSER = "12345678912", TYPEID = "01", STATUS = 0, NAME = "����E998", UNIT = "̨", PRICE = 5100, SN = "2002", WAREID = "02", STID = "02", ISINWAREHOUSE = 1 },
                new Assets { ASSID = "AS2018041103", BUYDATE = DateTime.Now, TEMPLATEID = "AT20180401", EXPIRYDATE = DateTime.Now.AddYears(2), IMAGE = "2014.jpg", SLID = "03", CREATEDATE = DateTime.Now, CREATEUSER = "12345678912", MODIFYDATE = DateTime.Now, MODIFYUSER = "12345678912", TYPEID = "01", STATUS = 0, NAME = "����E997", UNIT = "̨", PRICE = 5200, SN = "2003", WAREID = "03", STID = "03", ISINWAREHOUSE = 1 },
                new Assets { ASSID = "AS2018041104", BUYDATE = DateTime.Now, TEMPLATEID = "AT20180401", EXPIRYDATE = DateTime.Now.AddYears(2), IMAGE = "2014.jpg", SLID = "01", CREATEDATE = DateTime.Now, CREATEUSER = "12345678912", MODIFYDATE = DateTime.Now, MODIFYUSER = "12345678912", TYPEID = "01", STATUS = 0, NAME = "����E996", UNIT = "̨", PRICE = 5300, SN = "2004", WAREID = "01", STID = "01", ISINWAREHOUSE = 1 },
                new Assets { ASSID = "AS2018041105", BUYDATE = DateTime.Now, TEMPLATEID = "AT20180401", EXPIRYDATE = DateTime.Now.AddYears(2), IMAGE = "2014.jpg", SLID = "02", CREATEDATE = DateTime.Now, CREATEUSER = "12345678912", MODIFYDATE = DateTime.Now, MODIFYUSER = "12345678912", TYPEID = "01", STATUS = 0, NAME = "����E995", UNIT = "̨", PRICE = 5400, SN = "2005", WAREID = "02", STID = "02", ISINWAREHOUSE = 1 },
                new Assets { ASSID = "AS2018041106", BUYDATE = DateTime.Now, TEMPLATEID = "AT20180401", EXPIRYDATE = DateTime.Now.AddYears(2), IMAGE = "2014.jpg", SLID = "01", CREATEDATE = DateTime.Now, CREATEUSER = "12345678912", MODIFYDATE = DateTime.Now, MODIFYUSER = "12345678912", TYPEID = "01", STATUS = 0, NAME = "����E994", UNIT = "̨", PRICE = 5500, SN = "2006", WAREID = "03", STID = "03", ISINWAREHOUSE = 1 }
                );
            context.AssTemplates.AddOrUpdate(
                new AssTemplate { TEMPLATEID = "AT20180401", IMAGE = "2014.jpg", MANAGER = "12345678912", NAME = "����", NOTE = "��ע", PRICE = 5000, SPECIFICATION = "50*40", UNIT = "̨",TYPEID = "01"},
                new AssTemplate { TEMPLATEID = "AT20180402", IMAGE = "2015.jpg", MANAGER = "12345678913", NAME = "��ʾ��", NOTE = "��ע", PRICE = 2000, SPECIFICATION = "50*40", UNIT = "̨", TYPEID = "01" },
                new AssTemplate { TEMPLATEID = "AT20180403", IMAGE = "2016.jpg", MANAGER = "12345678914", NAME = "�ֻ�", NOTE = "��ע", PRICE = 4000, SPECIFICATION = "50*40", UNIT = "̨", TYPEID = "01" }
                );
            context.AssProcessRecords.AddOrUpdate(
                new AssProcessRecord { ASSID = "AS2018041101", CREATEDATE = DateTime.Now, CREATEUSER = "12345678912", HANDLEDATE = DateTime.Now, HANDLEMAN = "12345678912", MODIFYDATE = DateTime.Now, MODIFYUSER = "12345678912", PRID = 1, PROCESSCONTENT = "���", PROCESSMODE = 8, QUANTITY = 1 },
                new AssProcessRecord { ASSID = "AS2018041102", CREATEDATE = DateTime.Now, CREATEUSER = "12345678912", HANDLEDATE = DateTime.Now, HANDLEMAN = "12345678912", MODIFYDATE = DateTime.Now, MODIFYUSER = "12345678912", PRID = 2, PROCESSCONTENT = "���", PROCESSMODE = 8, QUANTITY = 1 },
                new AssProcessRecord { ASSID = "AS2018041103", CREATEDATE = DateTime.Now, CREATEUSER = "12345678912", HANDLEDATE = DateTime.Now, HANDLEMAN = "12345678912", MODIFYDATE = DateTime.Now, MODIFYUSER = "12345678912", PRID = 3, PROCESSCONTENT = "���", PROCESSMODE = 8, QUANTITY = 1 },
                new AssProcessRecord { ASSID = "AS2018041104", CREATEDATE = DateTime.Now, CREATEUSER = "12345678912", HANDLEDATE = DateTime.Now, HANDLEMAN = "12345678912", MODIFYDATE = DateTime.Now, MODIFYUSER = "12345678912", PRID = 4, PROCESSCONTENT = "���", PROCESSMODE = 8, QUANTITY = 1 },
                new AssProcessRecord { ASSID = "AS2018041105", CREATEDATE = DateTime.Now, CREATEUSER = "12345678912", HANDLEDATE = DateTime.Now, HANDLEMAN = "12345678912", MODIFYDATE = DateTime.Now, MODIFYUSER = "12345678912", PRID = 5, PROCESSCONTENT = "���", PROCESSMODE = 8, QUANTITY = 1 },
                new AssProcessRecord { ASSID = "AS2018041106", CREATEDATE = DateTime.Now, CREATEUSER = "12345678912", HANDLEDATE = DateTime.Now, HANDLEMAN = "12345678912", MODIFYDATE = DateTime.Now, MODIFYUSER = "12345678912", PRID = 6, PROCESSCONTENT = "���", PROCESSMODE = 8, QUANTITY = 1 },

                new AssProcessRecord { CID = "C201804001", CREATEDATE = DateTime.Now, CREATEUSER = "12345678912", HANDLEDATE = DateTime.Now, HANDLEMAN = "12345678912", MODIFYDATE = DateTime.Now, MODIFYUSER = "12345678912", PRID = 7, PROCESSCONTENT = "���", PROCESSMODE = 8, QUANTITY = 30 },
                new AssProcessRecord { CID = "C201804001", CREATEDATE = DateTime.Now, CREATEUSER = "12345678912", HANDLEDATE = DateTime.Now, HANDLEMAN = "12345678912", MODIFYDATE = DateTime.Now, MODIFYUSER = "12345678912", PRID = 8, PROCESSCONTENT = "���", PROCESSMODE = 8, QUANTITY = 50 },
                new AssProcessRecord { CID = "C201804002", CREATEDATE = DateTime.Now, CREATEUSER = "12345678912", HANDLEDATE = DateTime.Now, HANDLEMAN = "12345678912", MODIFYDATE = DateTime.Now, MODIFYUSER = "12345678912", PRID = 9, PROCESSCONTENT = "���", PROCESSMODE = 8, QUANTITY = 80 }

                );
            context.Consumableses.AddOrUpdate(
                new Consumables {CID = "C201804001",CREATEDATE = DateTime.Now,CREATEUSER = "12345678912",IMAGE = "2018.jpg",MODIFYDATE = DateTime.Now,MODIFYUSER = "12345678912",NAME = "ֽ��",NOTE = "",SAFECEILING = 200,SAFEFLOOR = 20,SPECIFICATION = "20*20",SPQ = 12,UNIT = "��"},
                new Consumables {CID = "C201804002",CREATEDATE = DateTime.Now,CREATEUSER = "12345678912",IMAGE = "2019.jpg",MODIFYDATE = DateTime.Now,MODIFYUSER = "12345678912",NAME = "���±�",NOTE = "",SAFECEILING = 100,SAFEFLOOR = 10,SPECIFICATION = "60*20",SPQ = 12,UNIT = "��"},
                new Consumables {CID = "C201804003",CREATEDATE = DateTime.Now,CREATEUSER = "12345678912",IMAGE = "2017.jpg",MODIFYDATE = DateTime.Now,MODIFYUSER = "12345678912",NAME = "���",NOTE = "",SAFECEILING = 50,SAFEFLOOR = 20,SPECIFICATION = "20*20",SPQ = 12,UNIT = "��"}
                );
            context.ConQuants.AddOrUpdate(
                new ConQuant{CID = "C201804001",CREATEDATE = DateTime.Now,CREATEUSER = "12345678912", SLID = "01",MODIFYUSER = "12345678912",MODIFYDATE = DateTime.Now,QID = 1,QUANTITY = 30,WAREID = "01",STID = "01"},
                new ConQuant{CID = "C201804001",CREATEDATE = DateTime.Now,CREATEUSER = "12345678912", SLID = "02",MODIFYUSER = "12345678912",MODIFYDATE = DateTime.Now,QID = 2,QUANTITY = 50, WAREID = "02", STID = "02" },
                new ConQuant{CID = "C201804002",CREATEDATE = DateTime.Now,CREATEUSER = "12345678912", SLID = "01",MODIFYUSER = "12345678912",MODIFYDATE = DateTime.Now,QID = 3,QUANTITY = 80, WAREID = "03", STID = "03" }
                );
            context.WareHouses.AddOrUpdate(
                new WareHouse { WAREID = "01", NAME = "���˲ֿ�", ISENABLE = 1, PLACE = "���˲ֿ�1", MANAGER = "12345678912", CREATEUSER = "12345678912", CREATEDATE = DateTime.Now, MODIFYUSER = "12345678912", MODIFYDATE = DateTime.Now },
                new WareHouse { WAREID = "02", NAME = "�Ϻ��ֿ�", ISENABLE = 1, PLACE = "�Ϻ��ֿ�1", MANAGER = "12345678913", CREATEUSER = "12345678913", CREATEDATE = DateTime.Now, MODIFYUSER = "12345678913", MODIFYDATE = DateTime.Now },
                new WareHouse { WAREID = "03", NAME = "֣�ݲֿ�", ISENABLE = 1, PLACE = "֣�ݲֿ�1", MANAGER = "12345678915", CREATEUSER = "12345678915", CREATEDATE = DateTime.Now, MODIFYUSER = "12345678915", MODIFYDATE = DateTime.Now }
            );
            context.WHStorageTypes.AddOrUpdate(
                new WHStorageType { STID = "01", WAREID = "01", NAME = "����1", ISENABLE = 1, CREATEUSER = "13123456789", CREATEDATE = DateTime.Now, MODIFYUSER = "13123456789", MODIFYDATE = DateTime.Now },
                new WHStorageType { STID = "02", WAREID = "02", NAME = "����2", ISENABLE = 1, CREATEUSER = "13123456789", CREATEDATE = DateTime.Now, MODIFYUSER = "13123456789", MODIFYDATE = DateTime.Now },
                new WHStorageType { STID = "03", WAREID = "03", NAME = "����3", ISENABLE = 1, CREATEUSER = "13123456789", CREATEDATE = DateTime.Now, MODIFYUSER = "13123456789", MODIFYDATE = DateTime.Now }
            );
            context.WHStorageLocations.AddOrUpdate(
                new WHStorageLocation { SLID = "01",NAME = "��λ1",MANAGER = "13123456789", WAREID = "01", STID = "01", STATUS = 0, CREATEUSER = "13123456789", CREATEDATE = DateTime.Now, MODIFYUSER = "13123456789", MODIFYDATE = DateTime.Now },
                new WHStorageLocation { SLID = "02", NAME = "��λ2", MANAGER = "13123456789", WAREID = "01", STID = "01", STATUS = 0, CREATEUSER = "13123456789", CREATEDATE = DateTime.Now, MODIFYUSER = "13123456789", MODIFYDATE = DateTime.Now },
                new WHStorageLocation { SLID = "03", NAME = "��λ3", MANAGER = "13123456789", WAREID = "01", STID = "01", STATUS = 0, CREATEUSER = "13123456789", CREATEDATE = DateTime.Now, MODIFYUSER = "13123456789", MODIFYDATE = DateTime.Now },
                new WHStorageLocation { SLID = "01", NAME = "��λ4", MANAGER = "13123456789", WAREID = "02", STID = "02", STATUS = 0, CREATEUSER = "13123456789", CREATEDATE = DateTime.Now, MODIFYUSER = "13123456789", MODIFYDATE = DateTime.Now },
                new WHStorageLocation { SLID = "02", NAME = "��λ5", MANAGER = "13123456789", WAREID = "02", STID = "02", STATUS = 0, CREATEUSER = "13123456789", CREATEDATE = DateTime.Now, MODIFYUSER = "13123456789", MODIFYDATE = DateTime.Now },
                new WHStorageLocation { SLID = "03", NAME = "��λ6", MANAGER = "13123456789", WAREID = "02", STID = "02", STATUS = 0, CREATEUSER = "13123456789", CREATEDATE = DateTime.Now, MODIFYUSER = "13123456789", MODIFYDATE = DateTime.Now },
                new WHStorageLocation { SLID = "01", NAME = "��λ7", MANAGER = "13123456789", WAREID = "03", STID = "03", STATUS = 0, CREATEUSER = "13123456789", CREATEDATE = DateTime.Now, MODIFYUSER = "13123456789", MODIFYDATE = DateTime.Now },
                new WHStorageLocation { SLID = "02", NAME = "��λ8", MANAGER = "13123456789", WAREID = "03", STID = "03", STATUS = 0, CREATEUSER = "13123456789", CREATEDATE = DateTime.Now, MODIFYUSER = "13123456789", MODIFYDATE = DateTime.Now },
                new WHStorageLocation { SLID = "03", NAME = "��λ9", MANAGER = "13123456789", WAREID = "03", STID = "03", STATUS = 0, CREATEUSER = "13123456789", CREATEDATE = DateTime.Now, MODIFYUSER = "13123456789", MODIFYDATE = DateTime.Now }
            );

        }
    }
}
