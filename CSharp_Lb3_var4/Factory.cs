using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CSharp_Lb3_Var4
{
    class Factory : IComparable<Factory>
    {
        public string factoryName;
        public int numberWorkshops;
        public int amountWorkers;
        public int amountCraftsmen;
        public int profitWorker;
        public int profitCraftman;
        public int countDetails;

        public List<Worker> listWorkers;
        public List<Master> listMasters;
        public List<Person> listPeople;

        private List<Workshop> listWorkshops;
        private Dictionary<string, Person> employees;

        //getters & setters
        public List<Workshop> GetSetWorkshop
        {
            get { return listWorkshops; }
            set { listWorkshops = value; }
        }
        public Dictionary<string, Person> GetSetEmployees
        {
            get { return employees; }
            set { employees = value; }
        }
        public int GetCountWorkshops
        {
            get { return listWorkshops.Count; }
        }
        public int GetCountWorkers
        {
            get { return listWorkers.Count; }
        }
        public int GetCountMasters
        {
            get { return listMasters.Count; }
        }

        //конструктор без параметрів
        public Factory()
        {
            factoryName = "";
            numberWorkshops = 0;
            amountWorkers = 0;
            amountCraftsmen = 0;
            profitWorker = 0;
            profitCraftman = 0;
            listWorkers = new List<Worker>();
            listMasters = new List<Master>();
            listPeople = new List<Person>();
        }

        //конструктор копіювання
        public Factory(Factory factory)
        {
            factoryName = factory.factoryName + " (copy)";
            numberWorkshops = factory.numberWorkshops;
            amountWorkers = factory.amountWorkers;
            amountCraftsmen = factory.amountCraftsmen;
            profitWorker = factory.profitWorker;
            profitCraftman = factory.profitCraftman;
        }

        //ініціалізуючий конструктор
        public Factory(List<Workshop> workshops, List<Person> people)
        {
            listWorkshops = workshops;
            listPeople = people;
        }

        public int CompareTo(Factory other)
        {
            if (amountWorkers > other.amountWorkers && amountCraftsmen > other.amountCraftsmen && numberWorkshops > other.numberWorkshops)
                return 1;
            else if (amountWorkers < other.amountWorkers && amountCraftsmen > other.amountCraftsmen && numberWorkshops > other.numberWorkshops)
                return 2;
            else if (amountWorkers > other.amountWorkers && amountCraftsmen < other.amountCraftsmen && numberWorkshops > other.numberWorkshops)
                return 3;
            else if (amountWorkers > other.amountWorkers && amountCraftsmen > other.amountCraftsmen && numberWorkshops < other.numberWorkshops)
                return 4;
            else if (amountWorkers < other.amountWorkers && amountCraftsmen < other.amountCraftsmen && numberWorkshops > other.numberWorkshops)
                return 5;
            else if (amountWorkers > other.amountWorkers && amountCraftsmen < other.amountCraftsmen && numberWorkshops < other.numberWorkshops)
                return 6;
            else if (amountWorkers < other.amountWorkers && amountCraftsmen > other.amountCraftsmen && numberWorkshops < other.numberWorkshops)
                return 7;
            else if (amountWorkers < other.amountWorkers && amountCraftsmen < other.amountCraftsmen && numberWorkshops < other.numberWorkshops)
                return 8;
            else if (amountWorkers == other.amountWorkers && amountCraftsmen > other.amountCraftsmen && numberWorkshops > other.numberWorkshops)
                return 9;
            else if (amountWorkers == other.amountWorkers && amountCraftsmen > other.amountCraftsmen && numberWorkshops < other.numberWorkshops)
                return 10;
            else if (amountWorkers == other.amountWorkers && amountCraftsmen < other.amountCraftsmen && numberWorkshops > other.numberWorkshops)
                return 11;
            else if (amountWorkers == other.amountWorkers && amountCraftsmen < other.amountCraftsmen && numberWorkshops < other.numberWorkshops)
                return 12;
            else if (amountWorkers > other.amountWorkers && amountCraftsmen == other.amountCraftsmen && numberWorkshops > other.numberWorkshops)
                return 13;
            else if (amountWorkers < other.amountWorkers && amountCraftsmen == other.amountCraftsmen && numberWorkshops > other.numberWorkshops)
                return 14;
            else if (amountWorkers > other.amountWorkers && amountCraftsmen == other.amountCraftsmen && numberWorkshops < other.numberWorkshops)
                return 15;
            else if (amountWorkers < other.amountWorkers && amountCraftsmen == other.amountCraftsmen && numberWorkshops < other.numberWorkshops)
                return 16;
            else if (amountWorkers > other.amountWorkers && amountCraftsmen > other.amountCraftsmen && numberWorkshops == other.numberWorkshops)
                return 17;
            else if (amountWorkers > other.amountWorkers && amountCraftsmen < other.amountCraftsmen && numberWorkshops == other.numberWorkshops)
                return 18;
            else if (amountWorkers < other.amountWorkers && amountCraftsmen > other.amountCraftsmen && numberWorkshops == other.numberWorkshops)
                return 19;
            else if (amountWorkers < other.amountWorkers && amountCraftsmen < other.amountCraftsmen && numberWorkshops == other.numberWorkshops)
                return 20;
            else if (amountWorkers == other.amountWorkers && amountCraftsmen == other.amountCraftsmen && numberWorkshops > other.numberWorkshops)
                return 21;
            else if (amountWorkers == other.amountWorkers && amountCraftsmen == other.amountCraftsmen && numberWorkshops < other.numberWorkshops)
                return 22;
            else return 23;
        }
    }

    class Workshop : IEnumerable<Workshop>
    {
        public int uniqueNumber;
        public int countWorkspace;
        public int maxCapacityWorkers;
        public int maxCountMasters;
        public int maxCountWorkers;
        public int currentCountMasters;
        public int currentCountWorkers;
        const int constCountDetaisMaster = 15;
        const int constCountDetaisWorker = 5;
        const int constCostDetail = 35;
        public int currentCostDetail;

        public IEnumerator<Workshop> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    class Person : IEnumerable<Person>
    {
        public string surname, name, patronymic;
        public string taxNumber;
        public int numberWorkshop;

        public IEnumerator<Person> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    class Master : Person
    {
        const int constCountSalary = 40000;
        public int countCertificates;
    }

    class Worker : Person
    {
        const int constCountSalary = 15000;
        public bool haveHigherTechnicalEducation;
    }
}
