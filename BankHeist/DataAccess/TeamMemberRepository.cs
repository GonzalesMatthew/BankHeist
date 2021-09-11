using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankHeist.DataAccess
{
    class TeamMemberRepository
    {
        static List<TeamMember> _teamMembers = new List<TeamMember>
        { 
            new TeamMember
            {
                Name = "Matthew",
                SkillLevel = 200,
                Courage = 1.9M
            },
            new TeamMember
            {
                Name = "Abraham Lincoln",
                SkillLevel = 200,
                Courage = 2M
            }
        };

        internal void Add(TeamMember member)
        {
            _teamMembers.Add(member);
        }
        internal int Count()
        {
            return _teamMembers.Count;
        }

        internal List<TeamMember> GetAll()
        {
            return _teamMembers;
        }

        internal int TeamStrength()
        {
            var totalStrength = 0;
            foreach(TeamMember member in _teamMembers)
            {
                totalStrength += member.SkillLevel;
            }
            return totalStrength;
        }
    }
}
