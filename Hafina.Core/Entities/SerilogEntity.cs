using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hafina.Core.Entities
{
    public class SerilogEntity
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string MessageTemplate { get; set; }
        public string Level { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
        public string Exception { get; set; }
        [Column(TypeName = "xml")]
        public string Properties { get; set; }
        public string LogEvent { get; set; }
    }
}
