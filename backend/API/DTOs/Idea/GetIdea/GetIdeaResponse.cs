﻿using API.DTOs.Category;
using API.DTOs.Event.GetEvent;
using API.DTOs.User.GetUser;

namespace API.DTOs.Idea.GetIdea
{
    public class GetIdeaResponse
    {
        public GetIdeaResponse(Data.Entities.Idea idea)
        {
            Id = idea.Id;
            IdeaTitle = idea.IdeaTitle;
            IdeaDescription = idea.IdeaDescription;
            DateSubmitted = DateTime.UtcNow;
            File = idea.File;
            HashTag = idea.HashTag;
            UserName = idea.User.UserName;
            Faculty = idea.User.Faculty;
            EventName = idea.Event.EventName;
            FirstClosingDate = idea.Event.FirstClosingDate.ToString("dd/MM/yyyy");
            LastClosingDate = idea.Event.LastClosingDate.ToString("dd/MM/yyyy");
            Categories = idea.Categories
                .Select(category => new CategoryModel
                {
                    Id = category.Id,
                    CategoryName = category.CategoryName,
                    CategoryDescription = category.CategoryDescription,
                }).ToList();
        }

        public int Id { get; set; }

        public string IdeaTitle { get; set; }

        public string IdeaDescription { get; set; }

        public DateTime DateSubmitted { get; set; }

        public string File { get; set; }

        public string HashTag { get; set; }

        public string UserName { get; set; }

        public string Faculty { get; set; }

        public string EventName { get; set; }

        public string FirstClosingDate { get; set; }

        public string LastClosingDate { get; set; }

        public List<CategoryModel> Categories { get; set; }
    }
}
