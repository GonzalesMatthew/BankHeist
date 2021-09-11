using System;
using BankHeist.DataAccess;
using BankHeist.Model;

namespace BankHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist.");

            Console.WriteLine("Enter bank's difficulty.");
            var difficulty = Int32.Parse(Console.ReadLine());

            var _teamMembersRepo = new TeamMemberRepository();
            var incompleteTeam = true;
            while (incompleteTeam)
            {
                Console.WriteLine("Build your team. Enter a name to add a teammate, or enter blank to move on.\n");
                var newMember = new TeamMember();
                Console.WriteLine("Enter a Name.");
                var name = Console.ReadLine();
                if (name.Length == 0)
                {
                    incompleteTeam = false;
                    break;
                }
                newMember.Name = name;
                var emptySkill = true;
                while (emptySkill)
                {
                    Console.WriteLine("Enter a skill level (between 0 and 255).");
                    var skillLevel = Int32.Parse(Console.ReadLine());
                    if (skillLevel >= 0 && skillLevel <= 255)
                    {
                        emptySkill = false;
                        newMember.SkillLevel = Convert.ToByte(skillLevel);
                    }
                }
                var emptyCourage = true;
                while (emptyCourage)
                {
                    Console.WriteLine("Enter a courage factor (between 0 and 2.0).");
                    var courageFactor = Decimal.Parse(Console.ReadLine());
                    if (courageFactor >= 0 && courageFactor <= 2)
                    {
                        emptyCourage = false;
                        newMember.Courage = Convert.ToDecimal(courageFactor);
                    }
                }
                _teamMembersRepo.Add(newMember);
            }
            Console.WriteLine($"Your team size is {_teamMembersRepo.Count()}\n");

            var fullTeamList = _teamMembersRepo.GetAll();
            foreach(TeamMember member in fullTeamList)
            {
                Console.WriteLine($"Name: {member.Name}\nSkill Level: {member.SkillLevel} \nCourage: {member.Courage}\n");
            }
      
            Console.WriteLine("Enter the number of trials to run.\n");
            var simulations = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Running simulation...\n");
            var count = 0;
            var successes = 0;
            var failures = 0;
            while (count < simulations)
            {
                var bank = new Bank();
                bank.Difficulty = difficulty + new Random().Next(-10,10);
                Console.WriteLine($"The team's total skill strength is {_teamMembersRepo.TeamStrength()}");
                Console.WriteLine($"The bank's difficulty is {bank.Difficulty}");

                
                if (_teamMembersRepo.TeamStrength() >= bank.Difficulty)
                {
                    Console.WriteLine("Success.\n");
                    successes += 1;
                }
                if (_teamMembersRepo.TeamStrength() < bank.Difficulty)
                {
                    Console.WriteLine("Failure.\n");
                    failures += 1;
                }
                count += 1;
            }
            Console.WriteLine($"Simulation results:\nSuccesses: {successes}\nFailures: {failures}");

        }
    }
}
