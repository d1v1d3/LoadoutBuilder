using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadoutBuilder.Data.Models
{
    public class SightCategory
    {
        public int SightId { get; set; }
        [ForeignKey(nameof(SightId))]
        public Sight Sight { get; set; }
        public int CotegoryId { get; set; }
        [ForeignKey(nameof(CotegoryId))]
        public virtual Category Category { get; set; }
    }
}
