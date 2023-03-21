using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternativeTool.Web.Shared.Dtos
{
    public class CompetitiveProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public List<string> ProductNames { get; set; }
    }
}
