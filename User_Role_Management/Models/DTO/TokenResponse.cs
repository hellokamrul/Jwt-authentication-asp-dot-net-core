﻿namespace User_Role_Management.Models.DTO
{
    public class TokenResponse
    {
        public string? TokenString { get; set; }
        public DateTime ValidTo { get; set; }   
    }
}
