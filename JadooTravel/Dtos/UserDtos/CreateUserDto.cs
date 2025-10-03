﻿namespace JadooTravel.Dtos.UserDtos
{
    public class CreateUserDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string? ImageUrl { get; set; }
    }
}
