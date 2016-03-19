using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabiticaClientMiddleman.Models
{

    public class Daily
    {
        public string text { get; set; }
        public object[] reminders { get; set; }
        public Challenge challenge { get; set; }
        public string attribute { get; set; }
        public float priority { get; set; }
        public float value { get; set; }
        public Tags tags { get; set; }
        public string notes { get; set; }
        public DateTime dateCreated { get; set; }
        public string id { get; set; }
        public int streak { get; set; }
        public object[] checklist { get; set; }
        public bool collapseChecklist { get; set; }
        public Repeat repeat { get; set; }
        public bool completed { get; set; }
        public History[] history { get; set; }
        public DateTime startDate { get; set; }
        public int everyX { get; set; }
        public string frequency { get; set; }
        public string type { get; set; }
        public DateTime dateCompleted { get; set; }
    }

    public class Challenge
    {
    }

    public class Tags
    {
        public bool dddf29a89a204251842c682c5fb942db { get; set; }
        public bool _2a1de4d02505407db97d5b5ec936a374 { get; set; }
        public bool c2527f8a1c454fc1ab965fc6269fc9e3 { get; set; }
    }

    public class Repeat
    {
        public bool su { get; set; }
        public bool s { get; set; }
        public bool f { get; set; }
        public bool th { get; set; }
        public bool w { get; set; }
        public bool t { get; set; }
        public bool m { get; set; }
    }

    public class History
    {
        public object date { get; set; }
        public float value { get; set; }
    }

}
