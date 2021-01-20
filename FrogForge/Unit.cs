using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge
{
    class Unit
    {
        public Point Pos;
        public Team Team;
        public int Level;
        public string Class;
        public AIType AIType;
        public int ReinforcementTurn;
        public bool Statue;
        public Image image; // Editor only

        public Unit(Team team, int level, string @class, AIType aIType, int reinforcementTurn, bool statue)
        {
            Team = team;
            Level = level;
            Class = @class;
            AIType = aIType;
            ReinforcementTurn = reinforcementTurn;
            Statue = statue;
        }

        public Unit(string source)
        {
            FromSaveString(source);
        }

        public string ToSaveString()
        {
            return (int)Team + "," + Class + "," + Level + "," + (int)AIType + "," + Pos.X + "," + Pos.Y + (ReinforcementTurn > 0 ? ("," + ReinforcementTurn + "," + (Statue ? "T" : "F")) : "");
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
            if (parts.Length > 6)
            {
                ReinforcementTurn = int.Parse(parts[6]);
                Statue = parts[7] == "T";
            }
            else
            {
                ReinforcementTurn = 0;
            }
        }

        public override string ToString()
        {
            return Team.ToString()[0] + ",C:" + Class + ",L:" + Level + ";(" + Pos.X + "," + Pos.Y + ")";
        }
    }
}
