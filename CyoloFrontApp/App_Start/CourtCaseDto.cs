using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CyoloFrontApp.App_Start
{
    public class CourtCaseDto
    {
        public int ID { get; set; }
        public string CourtCaseNo { get; set; }
        public string HearingGeneral { get; set; }
        public string HearingDateTime { get; set; }
        public string HearingType { get; set; }
        public string CourtType { get; set; }
        public string ChamberID { get; set; }
        public string CourtLocation { get; set; }
        public string LawyerName { get; set; }
        public string LawyerSurename { get; set; }
        public string Country { get; set; }
    }
}