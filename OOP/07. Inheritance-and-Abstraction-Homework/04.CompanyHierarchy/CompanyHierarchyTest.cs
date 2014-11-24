using System;
using System.Collections.Generic;

public class CompanyHierarchyTest
{
    public static void Main()
    {
        IProject infoPortal = new Project(
            "Info Portal",
            new DateTime(2013, 1, 30),
            "Information portal for retirees",
            State.Closed);

        IProject brainGame = new Project(
           "Brainiac",
           new DateTime(2014, 6, 15),
           "Set of games which develop kids's logical thinking",
           State.Open);

        IProject greatDevelop = new Project(
           "Great Develop",
           new DateTime(2014, 9, 10),
           "Revolutional IDE for JavaScript developing",
           State.Open);

        ISale infoPortalSale = new Sale("Info Portal", new DateTime(2014, 4, 12), 2100);
        ISale fingerPrint = new Sale("IFinger", new DateTime(2014, 1, 8), 4299);
        ISale nightVision = new Sale("IVision", new DateTime(2014, 7, 1), 5900);
        ISale hologramObject = new Sale("IHologram", new DateTime(2013, 12, 14), 5200);
        ISale knowledgeSetter = new Sale("IFunnel", new DateTime(2012, 8, 19), 7500);

        IEmployee koko = new SalesEmployee(
            12,
            "Koicho",
            "Koichev",
            2200m,
            Department.Sales,
            new List<ISale> { fingerPrint, hologramObject });

        IEmployee sisko = new SalesEmployee(
            321,
            "Slavi",
            "Colov",
            1200.03m,
            Department.Sales,
            new List<ISale> { infoPortalSale, nightVision });

        IEmployee bobi = new SalesEmployee(
            122,
            "Bina",
            "Bobeva",
            1200.32m,
            Department.Sales,
            new List<ISale> { knowledgeSetter });

        IEmployee margarit = new Developer(
            20,
            "Margarit",
            "Margaritkov",
            1300.54m,
            Department.Production,
            new List<IProject> { brainGame, infoPortal });

        IEmployee iglika = new Developer(
        25,
        "Iglika",
        "Minzuharova",
        1100.12m,
        Department.Production,
        new List<IProject> { brainGame, greatDevelop });

        IEmployee pamukov = new Developer(
            620,
            "Vejdi",
            "Pamukov",
            1420.90m,
            Department.Production,
            new List<IProject> { brainGame, infoPortal, greatDevelop });

        IEmployee prokopi = new Manager(
            119,
            "Prokopi",
            "Prokopiev",
            960.35m,
            Department.Marketing,
            new List<IEmployee> { koko, bobi, pamukov });

        IEmployee zlatan = new Manager(
           199,
           "Zlatan",
           "Zlatanov",
           830.90m,
           Department.Marketing,
           new List<IEmployee> { iglika, margarit, sisko });

        IEmployee bogdanka = new Manager(
           119,
           "Bogdanka",
           "Bogdanova",
           1130.87m,
           Department.Accounting,
           new List<IEmployee> { zlatan, prokopi });

        IList<IEmployee> employess = new List<IEmployee>
        {
            koko,
            sisko,
            bobi,
            margarit,
            iglika,
            pamukov,
            prokopi,
            zlatan,
            bogdanka
        };

        foreach (IEmployee employee in employess)
        {
            Console.WriteLine(employee);
        }
    }
}