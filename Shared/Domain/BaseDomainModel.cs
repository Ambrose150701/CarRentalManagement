using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Domain
{
    public abstract class BaseDomainModel
    {
        public int Id{get; set;}
        public DateTime DateCreated {get; set;}
        public DateTime DateUpdated {get; set;}
        public string CreatedBy { get; set;}
        public string Updatedby {get; set;}
    }
}

namespace CarRentalManagement.Shared.Domain
{
    public class Make : BaseDomainModel
    {
        public string Name { get; set; }
    }
}


namespace CarRentalManagement.Shared.Domain
{
    public class Model : BaseDomainModel
    {
        public string Name { get; set; }
    }
}

namespace CarRentalManagement.Shared.Domain
{
    public class Colour : BaseDomainModel
    {
        public string Name { get; set; }
    }
}
