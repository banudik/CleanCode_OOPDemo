using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode_OOPDemo.Entities;

public class Customer:IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsStudent { get; set; }
    public bool IsOfficer { get; set; }
}
