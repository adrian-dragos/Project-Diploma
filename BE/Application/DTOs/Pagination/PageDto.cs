﻿
namespace Application.DTOs.Paging
{
    public sealed class PageDto
    {
        public int PageSize { get; set; } = 10;
        public int Page { get; set; } = 1;
        public string Sort { get; set; }
        public bool Ascending { get; set; }
    }
}
