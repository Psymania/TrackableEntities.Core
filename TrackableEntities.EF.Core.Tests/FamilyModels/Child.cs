﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TrackableEntities.Common.Core;

namespace TrackableEntities.EF.Core.Tests.FamilyModels
{
    public class Child : ITrackable
    {
        public Child() { }
        public Child(string name)
        {
            Name = name;
        }

        [Key]
        public string Name { get; set; }
        public List<Child> Children { get; set; }

        [NotMapped]
        public TrackingState TrackingState { get; set; }
        [NotMapped]
        public ICollection<string> ModifiedProperties { get; set; }
    }
}
