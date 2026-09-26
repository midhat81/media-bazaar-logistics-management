using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Role
    {
        public int id { get;private set; }
        public string role {  get; private set; }

        public Role(int id, string role)
        {
            if (id != null && id > 0)
                this.id = id;
            else
                throw new Exception("id needs to exist and needs to be higher than 0");
            this.role = role ?? throw new ArgumentNullException(nameof(role));
        }
    }
}
