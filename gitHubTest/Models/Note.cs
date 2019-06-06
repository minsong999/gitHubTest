using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gitHubTest.Models
{
    public class Note
    {
        public int NoteNo { get; set; }

        public string NoticeTitle { get; set; }

        public string NoteContents { get; set; }

        public int UserNo { get; set; }
    }
}
