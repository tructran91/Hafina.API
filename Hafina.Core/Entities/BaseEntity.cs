using System;
using System.ComponentModel.DataAnnotations;

namespace Hafina.Core.Entities
{
    public abstract class BaseEntity
    {
        public virtual string CreatedBy { get; set; }

        public virtual DateTime CreatedAt { get; set; }

        public virtual string UpdatedBy { get; set; }

        public virtual DateTime? UpdatedAt { get; set; }

        public virtual bool IsDeleted { get; set; }
    }
}
