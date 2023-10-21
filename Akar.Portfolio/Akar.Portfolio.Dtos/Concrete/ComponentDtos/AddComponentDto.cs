﻿using Akar.Portfolio.Shared.Entities.Abstract;

namespace Akar.Portfolio.Dtos.Concrete.ComponentDtos
{
    public class AddComponentDto :IDto
    {
        public int OrderNumber { get; set; }
        public string ComponentName { get; set; }
        public string ComponentProjectName { get; set; }
        public string ComponentDivId { get; set; }

        public bool IsActive { get; set; }

    }
}
