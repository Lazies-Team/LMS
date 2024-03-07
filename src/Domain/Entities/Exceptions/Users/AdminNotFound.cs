﻿namespace Domain.Entities.Exceptions.Users
{
    public class AdminNotFound : GlobalException
    {
        public AdminNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "Admin Not Found !";
        }
    }
}
