using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gitHubTest.Models
{
    public class User
    {
        //사용자 번호
        public int UserNo { get; set; }
        //사용자 이름
        public string UserName { get; set; }

        public string UserId { get; set; }

        public string UserPassword { get; set; }
    }
}
