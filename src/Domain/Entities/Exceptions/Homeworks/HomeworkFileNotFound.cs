﻿namespace Domain.Entities.Exceptions.Homeworks
{
    public class HomeworkFileNotFound : GlobalException
    {
        public HomeworkFileNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "HomeworkFile Not Found !";
        }
    }
}
