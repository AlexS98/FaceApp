﻿using System;

using FaceDetector.Abstractions.Entities;

namespace FaceDetector.Domain.Models.Entities
{
    public class ImageFolder : CommonModel<Guid>, IUserOwned
    {
        public Guid UserId { get; set; }
        public BaseUser User { get; set; }
        public string FolderName { get; set; }
    }
}
