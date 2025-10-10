using Lecture_4_lab.Model.Entities;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.SqlServer;

using var context = new DatabaseContext(OptionsBuilder Options);
        var students = context.Students.ToList();
        foreach (var s in students){
            Console.WriteLine($"(s.Id) - (s.Name) - (s.Age)");
        }
