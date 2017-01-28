﻿using System;

namespace AlexanderTsema.Storage.Entities.Entities
{
    public class Certificate : BaseEntity
    {
        public String Name { get; set; }
        public String Authority { get; set; }
        public DateTime RecieveDate { get; set; }
        public String Image { get; set; }
    }
}