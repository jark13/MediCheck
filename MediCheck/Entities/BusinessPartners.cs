﻿namespace MediCheck.Entities
{
    public class BusinessPartners: EntityBase
    {
        public string? Name { get; set; }

        public override string ToString() => $"Id: {Id}, Name: {Name}"; 
    }
}
