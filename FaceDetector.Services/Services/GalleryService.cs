﻿using AutoMapper;

using FaceDetector.Abstractions.Repositories;
using FaceDetector.Domain.Database.Repositories.Abstract;
using FaceDetector.Domain.Models.Entities;
using FaceDetector.Dtos;
using FaceDetector.Services.Abstract;

namespace FaceDetector.Services.Services
{
    public class GalleryService : BaseModelService<Gallery, GalleryDto>, IGalleryService
    {
        public GalleryService(IMapper mapper, IGalleryRepository tRepository)
            : base(mapper, tRepository)
        {
        }
    }
}
