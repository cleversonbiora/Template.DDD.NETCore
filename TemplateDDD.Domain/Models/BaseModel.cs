using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateDDD.Domain.Models
{
    public abstract class BaseModel
    {
        public virtual int Id { get; set; }
    }
}
