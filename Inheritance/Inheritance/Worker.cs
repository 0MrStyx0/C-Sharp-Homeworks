using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.ClassWorker
{
    internal abstract class Worker
    {
        public int Experience {  get; set; }

        public Worker(int experience)
        {
            Experience = experience;
        }   

        public void Print() { }
    }

    class President : Worker
    {
        public string Branch { get; set; }

        public President(string branch,int experience): base(experience)
        {
            Branch = branch;
        }
        public void Print()
        {
            Console.WriteLine($"Branch: {Branch} Experience: {Experience} year");
        }
    }

    class Security : Worker
    {
        public string Weapon {  get; set; }

        public Security(string Weapon, int experience) : base(experience)
        {
            this.Weapon = Weapon;
        }
        public void Print()
        {
            Console.WriteLine($"Weapon: {Weapon} Experience: {Experience} year");
        }
    }

    class Manager:Worker
    {
        public int groupNumber {  get; set; }

        public Manager(int groupNumber, int experience) : base(experience)
        {
            this.groupNumber = groupNumber;
        }
        public void Print()
        {
            Console.WriteLine($"Group Number: {groupNumber} Experience: {Experience} year");
        }
    }

    class Engineer: Worker
    {
        public string accessLevel {  get; set; }

        public Engineer(string accessLevel, int experience) : base(experience)
        {
            this.accessLevel = accessLevel;
        }
        public void Print()
        {
            Console.WriteLine($"Access Level: {accessLevel} Experience: {Experience} year");
        }
    }
}
