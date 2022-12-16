using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_Design_Pattern.DAL;

namespace Template_Design_Pattern.TemplateDesignPattern
{
    public class UserCardTagHelper:TagHelper
    {
        public AppUser AppUser { get; set; }


    }
}
