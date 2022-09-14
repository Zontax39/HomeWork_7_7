using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace HomeWork_7_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Army army = new Army();
            army.TransferSoldier();
            army.Start();
        }
    }
    internal class Army
    {
        private List<Soldier> _squadSoldiers1;
        private List<Soldier> _squadSoldiers2;

        public Army()
        {
            _squadSoldiers1 = new List<Soldier>();
            _squadSoldiers1.Add(new Soldier(name: "Brandon"));
            _squadSoldiers1.Add(new Soldier(name: "Kevin"));
            _squadSoldiers1.Add(new Soldier(name: "Kenneth"));
            _squadSoldiers1.Add(new Soldier(name: "Bruce"));
            _squadSoldiers1.Add(new Soldier(name: "Billy"));
            _squadSoldiers1.Add(new Soldier(name: "Joseph"));
            _squadSoldiers1.Add(new Soldier(name: "Paul"));
            _squadSoldiers1.Add(new Soldier(name: "Richard"));
            _squadSoldiers1.Add(new Soldier(name: "Billy"));
            _squadSoldiers1.Add(new Soldier(name: "Timothy"));
            _squadSoldiers1.Add(new Soldier(name: "Bryan"));
            _squadSoldiers1.Add(new Soldier(name: "Bob"));
            _squadSoldiers1.Add(new Soldier(name: "Bobby"));

            _squadSoldiers2 = new List<Soldier>();
            _squadSoldiers2.Add(new Soldier(name: "Benjamin"));
            _squadSoldiers2.Add(new Soldier(name: "John"));
            _squadSoldiers2.Add(new Soldier(name: "Kevin"));
            _squadSoldiers2.Add(new Soldier(name: "Patrick"));
            _squadSoldiers2.Add(new Soldier(name: "Nathan"));
            _squadSoldiers2.Add(new Soldier(name: "Ronald"));
            _squadSoldiers2.Add(new Soldier(name: "Bruce"));
            _squadSoldiers2.Add(new Soldier(name: "Thomas"));
            _squadSoldiers2.Add(new Soldier(name: "Eugene"));
            _squadSoldiers2.Add(new Soldier(name: "Johnny"));
            _squadSoldiers2.Add(new Soldier(name: "Philip"));
        }

        public void TransferSoldier()
        {
            string word = "B";
            var squad = _squadSoldiers1.Where(soldier => soldier.Name.StartsWith(word));
            _squadSoldiers2 = squad.Union(_squadSoldiers2).ToList();
            _squadSoldiers1 = _squadSoldiers1.Except(squad).ToList();
        }

        public void Start()
        {
            Console.WriteLine($"Squad Solisers1:");
            ShowArmy(_squadSoldiers1);
            Console.WriteLine($"\nSquad Solisers2:");
            ShowArmy(_squadSoldiers2);
            Console.ReadLine();
        }

        private void ShowArmy(List<Soldier> soldiers)
        {
            foreach (Soldier solider in soldiers)
            {
                solider.ShowInfo();
            }
        }
    }

    class Soldier
    {
        public string Name { get; private set; }

        public Soldier(string name) => Name = name;

        public void ShowInfo() => Console.WriteLine($"Name:{Name}");
    }
}