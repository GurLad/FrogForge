using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogmanGaidenLevelEditor
{
    class Unit
    {
        public Point Pos;
        public Team Team;
        public int Level;
        public string Class;
        public AIType AIType;

        public Unit(Team team, int level, string @class)
        {
            Team = team;
            Level = level;
            Class = @class;
        }

        public Unit(Team team, int level, string @class, AIType aIType) : this(team, level, @class)
        {
            AIType = aIType;
        }

        public Unit(string source)
        {
            FromSaveString(source);
        }

        public string ToSaveString()
        {
            return (int)Team + "," + Class + "," + Level + "," + (int)AIType + "," + Pos.X + "," + Pos.Y;
        }
        public void FromSaveString(string source)
        {
            string[] parts = source.Split(',');
            Team = (Team)int.Parse(parts[0]);
            Class = parts[1];
            Level = int.Parse(parts[2]);
            AIType = (AIType)int.Parse(parts[3]);
            Pos.X = int.Parse(parts[4]);
            Pos.Y = int.Parse(parts[5]);
        }

        public override string ToString()
        {
            return Team.ToString()[0] + ",C:" + Class + ",L:" + Level + ";(" + Pos.X + "," + Pos.Y + ")";
        }
    }
}
