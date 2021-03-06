using System;
using System.Collections.Generic;

namespace Crt.Data.Database.Entities
{
    public partial class CrtElement
    {
        public CrtElement()
        {
            CrtFinTargets = new HashSet<CrtFinTarget>();
        }

        public decimal ElementId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        /// <summary>
        /// Lookup ID for the program within the program category to which the element belongs (e.g. RSIP, SRIP)
        /// </summary>
        public decimal? ProgramLkupId { get; set; }
        /// <summary>
        /// Lookup ID for the funding vertical within which the element belongs (e.g. Transit, Preservation, Capital)
        /// </summary>
        public decimal? ProgramCategoryLkupId { get; set; }
        /// <summary>
        /// Lookup ID for the code to which Element is charged
        /// </summary>
        public decimal? ServiceLineLkupId { get; set; }
        /// <summary>
        /// Active flag for Element
        /// </summary>
        public bool? IsActive { get; set; }
        /// <summary>
        /// Number with which project element is ordered on the UI
        /// </summary>
        public decimal? DisplayOrder { get; set; }
        public DateTime? EndDate { get; set; }
        public long ConcurrencyControlNumber { get; set; }
        public string AppCreateUserid { get; set; }
        public DateTime AppCreateTimestamp { get; set; }
        public Guid AppCreateUserGuid { get; set; }
        public string AppLastUpdateUserid { get; set; }
        public DateTime AppLastUpdateTimestamp { get; set; }
        public Guid AppLastUpdateUserGuid { get; set; }
        public string DbAuditCreateUserid { get; set; }
        public DateTime DbAuditCreateTimestamp { get; set; }
        public string DbAuditLastUpdateUserid { get; set; }
        public DateTime DbAuditLastUpdateTimestamp { get; set; }

        public virtual CrtCodeLookup ProgramCategoryLkup { get; set; }
        public virtual CrtCodeLookup ProgramLkup { get; set; }
        public virtual CrtCodeLookup ServiceLineLkup { get; set; }
        public virtual ICollection<CrtFinTarget> CrtFinTargets { get; set; }
    }
}
