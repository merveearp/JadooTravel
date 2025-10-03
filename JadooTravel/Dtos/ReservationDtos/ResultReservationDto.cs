﻿namespace JadooTravel.Dtos.ReservationDtos
{
    public class ResultReservationDto
    {
        public string ReservationId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ReservationMessage { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
