﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
   public class Clinic
    {
        private List<Pet> data;

        public Clinic(int capacity)
        {
            this.Capacity = capacity;
            this.data = new List<Pet>();

        }

        public int Capacity { get; set; }
        public int Count => this.data.Count;

        public void Add(Pet pet)
        {
            if (data.Count+1<=this.Capacity)
            {
                data.Add(pet);
            }
        }

        public bool Remove(string name)
        {
            if (data.Any(p=>p.Name==name))
            {
                this.data.Remove(this.data.FirstOrDefault(p => p.Name == name));
                return true;
            }

            return false;
        }

        public Pet GetPet(string name, string owner)
        {

            return data.FirstOrDefault(p => p.Name == name && p.Owner == owner);
        }

        public Pet GetOldestPet()
        {
            return data.OrderByDescending(p => p.Age).FirstOrDefault();
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");
            foreach (var pet in data)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
