using System;
using System.Collections.Generic;

namespace taskApi.Models
{
    public partial class Task
    {
        public int Id { get; set; }
        public string Descript { get; set; }
        public bool Done { get; set; }
    }
}
