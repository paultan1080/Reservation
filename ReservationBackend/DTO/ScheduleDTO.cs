using System;
using System.Collections.Generic;
using System.Text;

namespace ReservationBackend.DTO
{
    public class ScheduleDTO
    {
        public int ProviderId { get; set; }

        public string ProviderName { get; set; }
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public bool IsReserved { get; set; }

        public bool IsConfirmed { get; set; }
    }
}
