using System;
using System.Collections.Generic;
using System.Linq;

namespace Cine.Modules.Movies.Api.DTO
{
    public class MovieDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<string> Genres { get; set; } = Enumerable.Empty<string>();
        public int Length { get; set; }
        public DateTime PremiereDate { get; set; }
        public PersonDto Director { get; set; }
        public IEnumerable<PersonDto> Stars { get; set; } = Enumerable.Empty<PersonDto>();
        public IEnumerable<RateDto> Ratings { get; set; } = Enumerable.Empty<RateDto>();
        public double OverallRating => Ratings?.Average(r => r.Value) ?? 0;
        public int RatesNumber => Ratings?.Count() ?? 0;
    }
}