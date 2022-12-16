using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Design_Pattern.TemplateDesignPattern
{
    public class KingUserCardTemplate : UserCardTemplate
    {
        protected override string SetFooter()
        {
            var sb = new StringBuilder();
            sb.Append("<a href='#' class='btn btn-warning'>Profili Gör</a>");
            sb.Append("<a href='#' class='btn btn-danger'>Mesaj Gönder</a>");
            sb.Append("<a href='#' class='btn btn-success'>Mesaj Gönder</a>");
            return sb.ToString();
        }

        protected override string SetImage()
        {
            return $"<img class='car-img-top' src ='{AppUser.Image} style='width:80px; height:80px;'>";
        }
    }
}
