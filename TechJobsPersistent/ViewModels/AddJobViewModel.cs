using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage ="Name required")]
        public string Name { get; set; }
        public int EmployerId { get; set; }
        public List<SelectListItem> Employer { get; set; }
        public List<Skill> Skills { get; set; }
        public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        {
            this.Skills = skills;

            Employer = new List<SelectListItem>();

            foreach (Employer employer in employers)
            {
                this.Employer.Add(
                    new SelectListItem
                    {
                        Value = employer.Id.ToString(),
                        Text = employer.Name
                    });
            }
        }

            public AddJobViewModel()
            {

            }
        }
    }

