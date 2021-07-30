using FrogForge.Editors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public class Unit
    {
        private Point _pos;
        public UnityPoint Pos
        {
            get
            {
                return _pos;
            }
            set
            {
                _pos.X = value.x;
                _pos.Y = value.y;
            }
        }
        public Team Team { get; set; }
        public int Level { get; set; }
        public string Class { get; set; }
        public AIType AIType { get; set; }
        public int ReinforcementTurn { get; set; }
        public bool Statue { get; set; }
        public Image image; // Editor only

        [System.Text.Json.Serialization.JsonConstructorAttribute]
        public Unit(Team team, int level, string @class, AIType aIType, int reinforcementTurn, bool statue)
        {
            Team = team;
            Level = level;
            Class = @class;
            AIType = aIType;
            ReinforcementTurn = reinforcementTurn;
            Statue = statue;
        }

        public override string ToString()
        {
            return Team.ToString()[0] + ",C:" + Class + ",L:" + Level + ";(" + Pos.x + "," + Pos.y + ")";
        }
    }
}
