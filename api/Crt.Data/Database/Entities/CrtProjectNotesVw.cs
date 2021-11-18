using System;
using System.Collections.Generic;

namespace Crt.Data.Database.Entities
{
    public partial class CrtProjectNotesVw
    {
        public decimal ProjectId { get; set; }
        public decimal? NoteId { get; set; }
        public string NoteType { get; set; }
        public DateTime? NoteCreateDate { get; set; }
        public string AppCreateUserid { get; set; }
        public string Notes { get; set; }
    }
}
