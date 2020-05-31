using LifePlanner.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifePlanner.Models.ViewModels
{
    public class DataViewModel
    {
        public List<Person> People { get; internal set; }
    }
}
