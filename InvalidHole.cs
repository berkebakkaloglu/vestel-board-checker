using System;
using System.Collections.Generic;

namespace SimpleDrawer
{
    public class InvalidHole
    {
        public HoleInfo holeInfo { get; set; }
        public List<String> errorType { get; set; }

        public InvalidHole(HoleInfo holeInfo, List<String> errorType)
        {
            this.holeInfo = holeInfo;
            this.errorType = errorType;
        }
    }
}
