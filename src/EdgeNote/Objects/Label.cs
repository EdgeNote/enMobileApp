﻿using System;
namespace EdgeNote.Library.Objects
{
    public class Label : AbstractVersionedObject
    {
        public string Name { get; set; }

        public string DataType { get; set; }

        public Guid? CounterLabelId { get; set; }
    }
}
