using System;
using System.Collections.Generic;

using ReservationBackend.Data.Entities;
using ReservationBackend.DTO;

namespace ReservationBackend.Services
{
    public interface IScheduleService
    {
        int AddSchedule(int providerId, DateTime startTime, DateTime endTime);
        void ConfirmTimeSlot(int scheduleId);
        List<ScheduleDTO> ListFreeTimeSlots();
        void ReserveTimeSlot(int scheduleId);
    }
}