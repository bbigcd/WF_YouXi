using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_YouXi
{
    public class StepInfo
    {
        private int p1;
        private int p2;
        private byte afterBrickIndex;
        private byte afterFacingIndex;

        public StepInfo(int p1, int p2, byte afterBrickIndex, byte afterFacingIndex)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
            this.afterBrickIndex = afterBrickIndex;
            this.afterFacingIndex = afterFacingIndex;
        }
    }
}
