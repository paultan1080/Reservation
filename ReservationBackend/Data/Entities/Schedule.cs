using System;
using System.Collections.Generic;
using System.Text;

namespace ReservationBackend.Data.Entities
{
    public  class Schedule
    {
        public  int  ScheduleId { get; set; }

        public int ProviderId { get; set; }
        public DateTime StartTime{ get; set; }

        public DateTime EndTime { get; set; }

        public  bool IsReserved { get; set; }

        public bool IsConfirmed { get; set; }
    }
}
