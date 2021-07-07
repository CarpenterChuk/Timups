using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timups.Data.Interfaces;
using Timups.Models;

namespace Timups.Data.Mocks
{
    public class MockWatchRepository: IWatchRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Watch> Watches
        {
            get
            {
                return new List<Watch>
                {
                    new Watch {
                        Name = "AARK Accent Sky ",
                        Price = 101.95M, 
                        ShortDescription = "The Accent watch celebrates color through an unconventional lens;",
                        LongDescription = "The Accent watch celebrates color through an unconventional lens; muted base tones subtly play hero to a restrained use of accent hues balanced in a graphic execution that is quintessentially AARK.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "",
                        InStock = true,
                        IsPreferredWatch = true,
                        ImageThumbnailUrl = ""
                    },
                    new Watch {
                        Name = "Archetype Archer Automatic Gold Black ",
                        Price = 251.95M, 
                        ShortDescription = "Individually numbered to 500 pieces.",
                        LongDescription = "A limited edition dual time zone machine with a glimpse of the mechanics viewable through the dial. Individually numbered to 500 pieces.",
                        Category =  _categoryRepository.Categories.First(),
                        ImageUrl = "",
                        InStock = true,
                        IsPreferredWatch = false,
                        ImageThumbnailUrl = ""
                    },
                    new Watch {
                        Name = "Auteur Revolution I Silver Walnut ",
                        Price = 126.95M, 
                        ShortDescription = "Each watch is unique.",
                        LongDescription = "The iconic pebble-shaped case of REVOLUTION is outlined by a solid walnut wood ring, showing a myriad of shades and textures. Each watch is unique.",
                        Category =  _categoryRepository.Categories.First(),
                        ImageUrl = "",
                        InStock = true,
                        IsPreferredWatch = false,
                        ImageThumbnailUrl = ""
                    },
                    new Watch
                    {
                        Name = "Bulova Computron LED Black ",
                        Price = 196.95M,
                        ShortDescription = "Water resistance to 30 meters.",
                        LongDescription = "Infusing some of Bulova’s most iconic and nostalgic timepieces with modern elements, the Archive Series continues with the digital LED Computron. The sleek stainless steel design features a blue LED display, expanded digital functionality now with dual time zone capabilities, and a distinct retro design that is as relevant today as it was in the 1970’s. Water resistance to 30 meters.",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "g",
                        InStock = true,
                        IsPreferredWatch = false,
                        ImageThumbnailUrl = ""
                    }
                };
                
            }
        }
        public IEnumerable<Watch> PreferredWatches { get; }
        public Watch GetWatchById(int watchId)
        {
            throw new NotImplementedException();
        }
    }
}
