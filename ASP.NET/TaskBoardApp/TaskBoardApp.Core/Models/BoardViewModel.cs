﻿using TaskBoardApp.Core.Models.Tasks;

namespace TaskBoardApp.Core.Models
{
    public class BoardViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<TaskViewModel> Tasks { get; set; }
    }
}
