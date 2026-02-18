using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo.Model
{
    internal class Trainer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int ExperienceInYears { get; set; }

        public List<Batch> batches { get; set; } = new List<Batch>();
    }
}
