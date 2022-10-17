using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork_7_7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var army = new Army();
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
            _squadSoldiers1.Add(new Soldier("Brandon"));
            _squadSoldiers1.Add(new Soldier("Kevin"));
            _squadSoldiers1.Add(new Soldier("Kenneth"));
            _squadSoldiers1.Add(new Soldier("Bruce"));
            _squadSoldiers1.Add(new Soldier("Billy"));
            _squadSoldiers1.Add(new Soldier("Joseph"));
            _squadSoldiers1.Add(new Soldier("Paul"));
            _squadSoldiers1.Add(new Soldier("Richard"));
            _squadSoldiers1.Add(new Soldier("Billy"));
            _squadSoldiers1.Add(new Soldier("Timothy"));
            _squadSoldiers1.Add(new Soldier("Bryan"));
            _squadSoldiers1.Add(new Soldier("Bob"));
            _squadSoldiers1.Add(new Soldier("Bobby"));

            _squadSoldiers2 = new List<Soldier>();
            _squadSoldiers2.Add(new Soldier("Benjamin"));
            _squadSoldiers2.Add(new Soldier("John"));
            _squadSoldiers2.Add(new Soldier("Kevin"));
            _squadSoldiers2.Add(new Soldier("Patrick"));
            _squadSoldiers2.Add(new Soldier("Nathan"));
            _squadSoldiers2.Add(new Soldier("Ronald"));
            _squadSoldiers2.Add(new Soldier("Bruce"));
            _squadSoldiers2.Add(new Soldier("Thomas"));
            _squadSoldiers2.Add(new Soldier("Eugene"));
            _squadSoldiers2.Add(new Soldier("Johnny"));
            _squadSoldiers2.Add(new Soldier("Philip"));
        }

        public void TransferSoldier()
        {
            var word = "B";
            var squad = _squadSoldiers1.Where(soldier => soldier.Name.StartsWith(word));
            _squadSoldiers2 = squad.Union(_squadSoldiers2).ToList();
            _squadSoldiers1 = _squadSoldiers1.Except(squad).ToList();
        }

        public void Start()
        {
            Console.WriteLine("Squad Solisers1:");
            ShowArmy(_squadSoldiers1);
            Console.WriteLine("\nSquad Solisers2:");
            ShowArmy(_squadSoldiers2);
            Console.ReadLine();
        }

        private void ShowArmy(List<Soldier> soldiers)
        {
            foreach (var solider in soldiers) solider.ShowInfo();
        }
    }

    internal class Soldier
    {
        public Soldier(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}");
        }
    }
}