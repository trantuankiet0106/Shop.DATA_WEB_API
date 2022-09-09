using My_shop.Application.System.Roles;
using My_shop.Data.EF;
using My_shop.Data.Entities;
using My_shop.ViewModels.System.Roles;
using My_shop.ViewModels.Utilities.Slides;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_shop.Application.Utilities.Slides
{
    public class SlideService : ISlideService
    {
        private readonly EDBcontext _context;

        public SlideService(EDBcontext context)
        {
            _context = context;
        }

        public async Task<List<SlideVm>> GetAll()
        {
            var slides = await _context.Slides.OrderBy(x => x.SortOrder)
                .Select(x => new SlideVm()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Url = x.Url,
                    Image = x.Image
                }).ToListAsync();

            return slides;
        }
    }
}