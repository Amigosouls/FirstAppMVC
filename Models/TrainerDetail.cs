using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApp.Models
{
    public class TrainerDetail
    {
        public string trainerName;
        public string trainerAge;
        public string trainerEmail;


        public TrainerDetail(string name, string age, string email)
        {
            this.trainerName = name;
            this.trainerAge = age;
            this.trainerEmail = email;
        }
    }

    public class Trainer2Detail
    {
        public string TrainerName { get; set; }
        public string TrainerAge { get; set; }
        public string TrainerEmail { get; set; }
    }
}