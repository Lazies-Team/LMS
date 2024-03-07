﻿namespace Domain.Entities.Exceptions.Tasks
{
    public class TaskResultFileNotFound : GlobalException
    {
        public TaskResultFileNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "Task Result File Not Found !";
        }
    }
}
