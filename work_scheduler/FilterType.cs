using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_scheduler {
    public enum FilterType {
        ShowAll = 10,
        OnlyUnended,
        OnlyEnded,
        OnlyWithTime,
        WithoutTime,
        BeforeDate
    }
}
