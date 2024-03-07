﻿namespace Domain.Entities.Exceptions.Images
{
    public class ImageNotFound : GlobalException
    {
        public ImageNotFound()
        {
            StatusCode = System.Net.HttpStatusCode.NotFound;
            TitleMessage = "Image Not Found !";
        }
    }
}
