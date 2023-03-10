using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template_Design_Pattern.TemplateDesignPattern
{
    public class DefaultUserCardTemplate : UserCardTemplate
    {
        protected override string SetFooter()
        {
            return string.Empty;
        }

        protected override string SetImage()
        {
            return $"<img class='car-img-top' src ='/images/user1.png' style='width:80px; height:80px;'>";
        }
    }
}
