﻿using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YmypMovieProject.Entity.Entities
{
    public sealed class Movie : BaseEntity
    {
      
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal? IMDB { get; set; }
        public DateTime PublishDate { get; set; }
        public string? ImageUrl { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public Guid DirectorId { get; set; }
        public Director Director { get; set; }
        public ICollection<Actor> Actors { get; set; }

    }
}
