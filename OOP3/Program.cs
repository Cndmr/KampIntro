using OOP3;
using System.Collections.Generic;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

BasvuruManager basvuruManager = new BasvuruManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService = new FileLoggerService();

basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService) ;

List<IKrediManager> krediler =new List<IKrediManager>() {ihtiyacKrediManager, konutKrediManager, tasitKrediManager };
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);