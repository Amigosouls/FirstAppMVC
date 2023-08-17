﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstApp.Models
{
    public class TraineeDetails
    {
        public string traineeName;
        public string traineeAge;
        public string traineeEmail;

        public TraineeDetails(string name, string age, string email) {
            this.traineeName = name;
            this.traineeAge = age;
            this.traineeEmail = email;
        } 
    }
}