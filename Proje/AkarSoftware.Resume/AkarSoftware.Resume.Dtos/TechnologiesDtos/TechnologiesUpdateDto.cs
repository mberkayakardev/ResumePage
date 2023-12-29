﻿using AkarSoftware.Resume.Core.Dtos.Abstract;

namespace AkarSoftware.Resume.Dtos.TechnologiesDtos
{
    public class TechnologiesUpdateDto : BaseUpdateDto
    {
        public string Name { get; set; }
        public string UrlPath { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
