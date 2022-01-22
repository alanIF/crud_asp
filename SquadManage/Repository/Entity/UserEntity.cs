using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class UserEntity
    {
        public int id { get; set; }

        public string Password { get; set; }
        // 1-admkin 0 leitura
        public string Type { get; set; }
        public string ResetHash{ set; get; }
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public PersonEntity Person { get; set; }
    }
}
