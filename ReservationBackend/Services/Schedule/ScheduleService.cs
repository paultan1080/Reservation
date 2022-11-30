using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaComposer.Data.Entities;
using Microsoft.EntityFrameworkCore;

using ReservationBackend.Data;
using ReservationBackend.Data.Entities;
using ReservationBackend.DTO;

namespace ReservationBackend.Services
{




    public class ScheduleService : IScheduleService
    {
        private RBDBContext _context;

        public ScheduleService(RBDBContext context)
        {
            _context = context;

        }


        public int AddSchedule(int providerId, DateTime startTime, DateTime endTime)
        {

            var dbSchedule = new Schedule();
            dbSchedule.StartTime = startTime;
            dbSchedule.EndTime = endTime;
            dbSchedule.ProviderId = providerId;
            _context.Schedule.Add(dbSchedule);
            return dbSchedule.ScheduleId;
        }


        public List<ScheduleDTO> ListFreeTimeSlots()
        {
            var dbSchedules = (from s in _context.Schedule
                               join p in _context.Provider on s.ProviderId equals p.ProviderId
                               where s.IsReserved == false
                               select new DTO.ScheduleDTO {
                                   ProviderId = s.ProviderId,
                                   ProviderName = p.ProviderName,
                                   StartTime = s.StartTime,
                                   EndTime = s.EndTime,
                                   IsConfirmed = s.IsConfirmed,
                                   IsReserved = s.IsReserved
                               }).ToList();

            return dbSchedules;
        }

        public void ReserveTimeSlot(int scheduleId)
        {

            var dbSchedule = _context.Schedule.Where(x => x.ScheduleId == scheduleId).FirstOrDefault();
            if (dbSchedule != null)
            {
                dbSchedule.IsReserved = true; ;
                _context.SaveChanges();
            }

        }

        public void ConfirmTimeSlot(int scheduleId)
        {

            var dbSchedule = _context.Schedule.Where(x => x.ScheduleId == scheduleId).FirstOrDefault();
            if (dbSchedule != null)
            {
                dbSchedule.IsConfirmed = true; ;
                _context.SaveChanges();
            }

        }

    }


}
