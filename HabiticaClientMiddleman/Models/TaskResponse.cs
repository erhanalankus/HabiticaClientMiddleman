using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabiticaClientMiddleman.Models
{

    public class TaskResponse
    {
        public float delta { get; set; }
        public _Tmp _tmp { get; set; }
        public Training training { get; set; }
        public Buffs buffs { get; set; }
        public int per { get; set; }
        public int _int { get; set; }
        public int con { get; set; }
        public int str { get; set; }
        public int points { get; set; }
        public string _class { get; set; }
        public int lvl { get; set; }
        public float gp { get; set; }
        public int exp { get; set; }
        public int mp { get; set; }
        public float hp { get; set; }
    }

    public class _Tmp
    {
    }

    public class Training
    {
        public int con { get; set; }
        public int str { get; set; }
        public int per { get; set; }
        public int _int { get; set; }
    }

    public class Buffs
    {
        public bool seafoam { get; set; }
        public bool shinySeed { get; set; }
        public bool spookDust { get; set; }
        public bool snowball { get; set; }
        public bool streaks { get; set; }
        public int stealth { get; set; }
        public int con { get; set; }
        public int per { get; set; }
        public int _int { get; set; }
        public int str { get; set; }
    }

}
