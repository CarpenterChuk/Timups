using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timups.Models
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context = applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Watches.Any())
            {
                context.AddRange
                (
                    new Watch
                    {
                        Name = "Apple Watch SE ",
                        Price = 329.99M,
                        ShortDescription = "The best smartwatch... but you'll need an iPhone",
                        LongDescription = "The Apple Watch SE is the best smartwatch money can buy right now, but it's only the right choice for you if you own an iPhone. Scroll down for our second choice in this list if you've got an Android phone.If you do have an iPhone, you may wonder why the Apple Watch 6 doesn't take our title of the very best smartwatch? That's because the Apple Watch SE does almost everything that smartwatch can, but for a much lower price. The Apple Watch SE comes with some top-end specs, a high-end design and a great range of features that you can't get on every other smartwatch right now. The battery life isn't the best on the market, and there isn't an always-on display, but if you're after a great value for money choice for your next wrist companion you should opt for the Apple Watch SE.",
                        Category = Categories["Smart"],
                        ImageUrl = "smart/Apple Watch SE.jpg",
                        InStock = true,
                        IsPreferredWatch = true,
                        ImageThumbnailUrl = "smart/Apple Watch SE.jpg"
                    },
                    new Watch
                    {
                        Name = "Samsung Galaxy Watch 3 ",
                        Price = 399.99M,
                        ShortDescription = "The best smartwatch for those on Android, and it works with iPhone too",
                        LongDescription = "The best smartwatch money can buy right now if you own an Android phone is the Galaxy Watch 3 from Samsung. It also works with an iPhone though, and this is the company's most accomplished wrist wear yet. It's a sequel to the Galaxy Watch from 2018, and it keeps a lot of that device's design elements but refines them.The Galaxy Watch 3 features a unique rotating bezel that makes navigating around the smartwatch a joy. We find that a lot easier than trying to use the display, which is something you have to do on a lot of the other best smartwatches in this list. Apps available on the watch are more limited than Wear OS or watchOS - two rival smartwatch operating systems - but it still offers the core basics and Samsung has provided a watch that's good at fitness as well as sporting a great design and lots more functionality too. Features are more limited if you're using this with an iPhone, but it's still compatible with those devices. We'd recommend considering the Apple Watch below though if that's your phone of choice. Overall, the Galaxy Watch 3 is the full package if you're looking for a smartwatch to track your fitness, look good on your wrist and a whole lot more.",
                        Category = Categories["Smart"],
                        ImageUrl = "smart/Samsung Galaxy Watch 3.jpg",
                        InStock = true,
                        IsPreferredWatch = true,
                        ImageThumbnailUrl = "smart/Samsung Galaxy Watch 3.jpg"
                    },
                    new Watch
                    {
                        Name = "Apple Watch 6 ",
                        Price = 379.99M,
                        ShortDescription = "The top tier Apple Watch for those willing to spend",
                        LongDescription = "The Apple Watch 6 hasn't taken the top spot in our best smartwatch list, but this is absolute best device you can get if you own an iPhone. Why isn't it ranked above the Apple Watch SE? Because it's a lot more expensive than that option. The Apple Watch 6 works seamlessly with Apple's phones, and it's well worth considering if you plan to stick with the iPhone range for at least a few years. It isn't a huge upgrade over the Apple Watch 5 though. There are new features like blood oxygen monitoring and an upgraded chipset, but largely it's a similar device with the exact same screen and design. All of that said, if you're after an Apple Watch this is the best from the company ever and it may be made specifically for you to strap around your wrist and pair with your iPhone.",
                        Category = Categories["Smart"],
                        ImageUrl = "smart/Apple Watch 6.jpg",
                        InStock = true,
                        IsPreferredWatch = true,
                        ImageThumbnailUrl = "smart/Apple Watch 6.jpg"
                    },
                    new Watch
                    {
                        Name = "Fitbit Versa 3 ",
                        Price = 379.99M,
                        ShortDescription = "Fitbit's best smartwatch is a great choice for fitness",
                        LongDescription = "Don't want something from either Samsung or Apple? The Fitbit Versa 3 may be best for your wrist, and this latest smartwatch from the company is one of the best wrist companions for those who want to focus on fitness features. There's built-in GPS, the design is comfortable to wear and the display is easy to view with a crisp image. Like previous Fitbit smartwatches, this is mostly focused on fitness and won't be for everyone. But for general wearable fans, the Fitbit Versa 3 is a good option, and it's more affordable than some of the other options on this list too.",
                        Category = Categories["Smart"],
                        ImageUrl = "smart/Fitbit Versa 3.jpg",
                        InStock = true,
                        IsPreferredWatch = true,
                        ImageThumbnailUrl = "smart/Fitbit Versa 3.jpg"
                    },
                    new Watch
                    {
                        Name = "Samsung Galaxy Watch Active 2 ",
                        Price = 199.99M,
                        ShortDescription = "Adding in a digital rotating bezel for a nominal price bump",
                        LongDescription = "Samsung shrank the best parts of the the Galaxy Watch into this sportier smartwatch that's slimmer, lighter and, arguably, more comfortable - then released a second version months after the first that included a few coveted features, including a rotating digital bezel and LTE version. Overall, not much has changed - which isn't a bad thing, as it's still a quality smartwatch at a decent price. Galaxy Watch Active 2 features a 1.2-inch 360 x 360 display that is bright and beautiful yet small enough to be strapped around your wrist than a lot of the other devices in this list. It still comes sporting all of the top-end fitness features you'd expect from Samsung's Tizen watch range, with 39 workout modes, a heart rate and ECG sensor, and health app with stress and sleep monitoring. There's even a way to monitor your blood pressure, but that won't be activated for some time. While it's still more affordable than the leading Apple Watch, the price was bumped up from the original Watch Active, shrinking its value compared to the competition. It's certainly not a cheap smartwatch, but when compared to the price of the Galaxy Watch 3 you may prefer to opt for this version that's remarkably similar.",
                        Category = Categories["Smart"],
                        ImageUrl = "smart/.jpg",
                        InStock = true,
                        IsPreferredWatch = true,
                        ImageThumbnailUrl = "smart/.jpg"
                    },
                    new Watch
                    {
                        Name = "Fitbit Versa Lite ",
                        Price = 218.99M,
                        ShortDescription = "Lighter, but not lesser",
                        LongDescription = "The second best Fitbit on our list is the Fitbit Versa Lite, a more affordable version of the Fitbit Versa with a few of the features dropped. The Versa Lite has a good range of fitness features, a battery that'll last you a good few days (and beat out lots of the other devices on this list), and a body that's quite small and light, and will fit on your wrist easily without you noticing it lots of the time. Some of the features the Versa Lite misses over the Versa, or the Versa 2 and 3, include no Fitbit Pay, no on-board GPS and a slightly less impressive screen. If you're looking for a good smartwatch on a budget though, you might not mind some of these omissions.",
                        Category = Categories["Smart"],
                        ImageUrl = "smart/Fitbit Versa Lite.jpg",
                        InStock = true,
                        IsPreferredWatch = true,
                        ImageThumbnailUrl = "smart/Fitbit Versa Lite.jpg"
                    },
                    new Watch
                    {
                        Name = "Fossil Sport ",
                        Price = 239.99M,
                        ShortDescription = "Fossil's latest big smartwatch attempt",
                        LongDescription = "Fossil has developed a lot of expertise in the wearable tech space over the last few years, and this has all culminated in the best smartwatch the company has made so far. The Fossil Sport is a top-end watch with a lower price tag than the two devices above in this list. It features GPS, a lightweight - yet premium - design and at least two days of battery life from a single charge. Fossil has packed a Snapdragon Wear 3100 chipset inside, which is the latest update from Qualcomm that offers a smoother experience than you'll get on a lot of older Wear OS watches. It doesn't sport any truly unique features, but the overall package of the Fossil Sport may be the best watch for you. That'll especially be the case if you're looking for a fitness watch that comes with Wear OS software and won't look odd on your wrist when you're going about your day.",
                        Category = Categories["Smart"],
                        ImageUrl = "smart/Fossil Sport.jpg",
                        InStock = true,
                        IsPreferredWatch = true,
                        ImageThumbnailUrl = "smart/Fossil Sport.jpg"
                    },
                    new Watch
                    {
                        Name = "Bulova Lunar Pilot Chronograph ",
                        Price = 39900.00M,
                        ShortDescription = "Bulova made history in 1971 when the brand equipped astronauts on the Apollo 15 mission with its Lunar Pilot Chronograph",
                        LongDescription = "Bulova made history in 1971 when the brand equipped astronauts on the Apollo 15 mission with its Lunar Pilot Chronograph. Built to endure astronomical conditions, the watch was used to track vital metrics like oxygen supply and battery power, while also serving as a backup timer during re-entry. Now the legend is back and better than ever. Specifically, the special edition Lunar Pilot Chronograph takes design cues from its historic predecessor, but packs in even more power and accuracy in the form of upgraded quartz movement with a 262kHz vibrational frequency. That’s joined by super-luminous hands, a tachymeter scale, calendar function, water resistance to 50m, and a case of stainless steel. The result is one of the best quartz watches you can buy for under $1000.",
                        Category = Categories["Quartz"],
                        ImageUrl = "quartz/Bulova Lunar Pilot Chronograph.jpg",
                        InStock = true,
                        IsPreferredWatch = true,
                        ImageThumbnailUrl = "quartz/Bulova Lunar Pilot Chronograph.jpg"
                    },
                    new Watch
                    {
                        Name = "TAG Heuer Carrera Quartz ",
                        Price = 2900.00M,
                        ShortDescription = "Swiss brand TAG Heuer has always been synonymous with quality, durability, accuracy, and style, and the Carrera Quartz is certainly no exception",
                        LongDescription = "Swiss brand TAG Heuer has always been synonymous with quality, durability, accuracy, and style, and the Carrera Quartz is certainly no exception. It hosts a slim and stately steel polished 36mm case, and sleek black opalin dial. Also featured are beveled sapphire crystal with double anti-reflective treatment, steel polished lugs, a screw-down case-back, super-luminous hands and markers, and a fixed bezel. Powering the watch is TAG Heuer’s own quartz movement, which is pretty much as accurate as it gets. Sealing the deal is a brown strap of calfskin leather and rubber. A classic beauty.",
                        Category = Categories["Quartz"],
                        ImageUrl = "quartz/TAG Heuer Carrera Quartz.jpg",
                        InStock = true,
                        IsPreferredWatch = true,
                        ImageThumbnailUrl = "quartz/TAG Heuer Carrera Quartz.jpg"
                    },
                    new Watch
                    {
                        Name = "Grand Seiko SBGX259G ",
                        Price = 2700.00M,
                        ShortDescription = "Emanating with timeless sophistication and minimalist allure, the Grand Seiko SBGX259G is a symphony of stainless steel and sapphire crystal. Under the skin is trusty Caliber 9F62 quartz movement with date complication",
                        LongDescription = "Emanating with timeless sophistication and minimalist allure, the Grand Seiko SBGX259G is a symphony of stainless steel and sapphire crystal. Under the skin is trusty Caliber 9F62 quartz movement with date complication. This one measures in at 37mm in diameter and 10mm thick, making it as light on the wrist as it is easy on the eyes. Will it cost you a pretty penny? It will, indeed. But you’ll be getting one of the best and most accurate quartz watches on the planet in return.",
                        Category = Categories["Quartz"],
                        ImageUrl = "quartz/Grand Seiko SBGX259G.jpg",
                        InStock = true,
                        IsPreferredWatch = true,
                        ImageThumbnailUrl = "quartz/Grand Seiko SBGX259G.jpg"
                    },
                    new Watch
                    {
                        Name = "Omega Speedmaster Skywalker X-33 ",
                        Price = 5900.00M,
                        ShortDescription = "Designed for space explorers, the Omega Speedmaster Skywalker X-33 comes powered by advanced quartz calibre movement",
                        LongDescription = "Designed for space explorers, the Omega Speedmaster Skywalker X-33 comes powered by advanced quartz calibre movement, which delivers steadfast accuracy and a bevy of functions. Combining analog and digital elements to perfection, the watch offers access to three time zones at once, three alarm clocks, chronograph, countdown function, and perpetual calendar. Meanwhile, thanks to Super-LumiNova treatment, the dial and LCD display remain legible in the deepest and darkest conditions. Similarly dependable is the watch’s 45mm brushed case of grade 2 titanium. The best quartz watches don’t get much better than this.",
                        Category = Categories["Quartz"],
                        ImageUrl = "quartz/Omega Speedmaster Skywalker X-33.jpg",
                        InStock = true,
                        IsPreferredWatch = true,
                        ImageThumbnailUrl = "quartz/Omega Speedmaster Skywalker X-33.jpg"
                    },
                    new Watch
                    {
                        Name = "La montre Merci LMM-01 ",
                        Price = 500.00M,
                        ShortDescription = "The LMM-01 represents La montre Merci’s first design, and one of the best quartz watches",
                        LongDescription = "The LMM-01 represents La montre Merci’s first design, and one of the best quartz watches under $500. Indeed, between the watch’s slim 37.5mm case, military-inspired design, powerful Swiss-made movement, and affordable price tag, there’s virtually nothing left to be desired. Clean and simple, like a great timepiece should be.",
                        Category = Categories["Quartz"],
                        ImageUrl = "quartz/La montre Merci LMM-01.jpg",
                        InStock = true,
                        IsPreferredWatch = true,
                        ImageThumbnailUrl = "quartz/La montre Merci LMM-01.jpg"
                    },
                    new Watch
                    {
                        Name = "Breitling Colt Quartz ",
                        Price = 3200.00M,
                        ShortDescription = "With a name like Colt Quartz, you know this Breitling stunner brings no shortage of power to the table",
                        LongDescription = "With a name like Colt Quartz, you know this Breitling stunner brings no shortage of power to the table. Water resistant to 200m, the stylish and robust timepiece offers a 44mm case of stainless steel, and heaping piles of functionality. Powering the watch is Breitling’s own SuperQuartz, a movement ten times more accurate than the standard fare. Choose between a leather strap or stainless steel bracelet, strap up, and conquer.",
                        Category = Categories["Quartz"],
                        ImageUrl = "quartz/Breitling Colt Quartz.jpg",
                        InStock = true,
                        IsPreferredWatch = true,
                        ImageThumbnailUrl = "quartz/Breitling Colt Quartz.jpg"
                    },
                    new Watch
                    {
                        Name = "Sinn Diving Watch UX S ",
                        Price = 2600.00M,
                        ShortDescription = "If only the top shelf of durability will suffice, look no further than the UX S Diving Watch from Sinn",
                        LongDescription = "If only the top shelf of durability will suffice, look no further than the UX S Diving Watch from Sinn. Made of German Submarine Steel, the watch is resistant to seawater and extreme temperatures, as well as both high and low pressures. Thanks to HYDRO technology–which delivers legibility at any angle and keeps the watch free from fogging–the matte black dial stays crystal clear even fathoms below the ocean’s surface. Also featured is a diver’s bezel with minute ratcheting and luminous key mark. Given that the deep sea is pretty much the one place left on earth where you can’t bring a smartphone (yet), consider this the best quartz watch for providing functionality where it still counts. Dive with confidence.",
                        Category = Categories["Quartz"],
                        ImageUrl = "quartz/Sinn Diving Watch UX S.jpg",
                        InStock = true,
                        IsPreferredWatch = true,
                        ImageThumbnailUrl = "quartz/Sinn Diving Watch UX S.jpg"
                    },
                    new Watch
                    {
                        Name = "MWC Submariner 300m Military",
                        Price = 300.00M,
                        ShortDescription = "A true, tough-as-nails diver, the MWC Submariner 300m Military watch",
                        LongDescription = "A true, tough-as-nails diver, the MWC Submariner 300m Military watch was built to survive some of the harshest environments in the world and keep right on ticking. That’s aided by an ultra-durable PVD-coated steel case with a dive timer bezel, a reliable 24-jewel automatic movement, a screw-down crown, and a NATO nylon strap. If black is your color and you want a watch that can take tons of punishment, this is the mechanical watch for you.",
                        Category = Categories["Mechanical"],
                        ImageUrl = "mechanical/MWC Submariner 300m Military.jpg",
                        InStock = true,
                        IsPreferredWatch = true,
                        ImageThumbnailUrl = "mechanical/MWC Submariner 300m Military.jpg"
                    },
                    new Watch
                    {
                        Name = "Junghans Max Bill ",
                        Price = 658.99M,
                        ShortDescription = "The Junghans Max Bill series of watches are some of the most lauded Bauhaus-inspired minimalist timepieces around",
                        LongDescription = "The Junghans Max Bill series of watches are some of the most lauded Bauhaus-inspired minimalist timepieces around. And this version, the automatic mechanical, is amongst the best therein. Interestingly, though its dial is abundant in its markings — including both 12-hour markers, as well as 60-minute indices — it still manages to have a clean and uncluttered design. It’s also powered by a 38-hour automatic movement, has a stainless steel case, and comes with a gorgeous and simple leather strap.",
                        Category = Categories["Mechanical"],
                        ImageUrl = "mechanical/Junghans Max Bill.jpg",
                        InStock = true,
                        IsPreferredWatch = true,
                        ImageThumbnailUrl = "mechanical/Junghans Max Bill.jpg"
                    },
                    new Watch
                    {
                        Name = "Seiko Prospex 1968 SBDC061 ",
                        Price = 785.99M,
                        ShortDescription = "Include turtle-shaped stainless steel case and offset crown.",
                        LongDescription = "Though not technically a ‘Sumo’ Seiko, the Prospex 1968 SBDC061 shares quite a bit with its highly sought-after brethren — including its turtle-shaped stainless steel case and offset crown. It also features a reliable automatic movement, a steel link band, built-in magnetic resistance, and a 200m water-resistance rating. Unlike its cousins, however, this one is a bit more toned-down and, therefore, better for dress wear — yet it’s still an eye-catching piece that’s sure to strike up a conversation with discerning parties.",
                        Category = Categories["Mechanical"],
                        ImageUrl = "mechanical/Seiko Prospex 1968 SBDC061.jpg",
                        InStock = true,
                        IsPreferredWatch = true,
                        ImageThumbnailUrl = "mechanical/Seiko Prospex 1968 SBDC061.jpg"
                    },
                    new Watch
                    {
                        Name = "Hamilton Khaki Murph ",
                        Price = 792.00M,
                        ShortDescription = "Made specifically by Hamilton for the film, this unique version of the brand’s (arguably) most popular watch",
                        LongDescription = "While Christopher Nolan’s Interstellar gave us one of the most impressive sci-fi epics ever to appear onscreen, the film also resulted in the release of one of the most iconic movie watches ever — the Hamilton Khaki Murph Field Watch. Made specifically by Hamilton for the film, this unique version of the brand’s (arguably) most popular watch features a stainless steel case, an automatic movement, an alligator-style leather strap, and a scratch-resistant sapphire crystal. It’s not going to allow you to wormhole through the universe, but it’s still an exceedingly special timekeeper.",
                        Category = Categories["Mechanical"],
                        ImageUrl = "mechanical/Hamilton Khaki Murph.jpg",
                        InStock = true,
                        IsPreferredWatch = true,
                        ImageThumbnailUrl = "mechanical/Hamilton Khaki Murph.jpg"
                    },
                    new Watch
                    {
                        Name = "Victorinox Airboss Mechanical ",
                        Price = 995.99M,
                        ShortDescription = "Pilot watches, a historically-significant watch style, are a dime-a-dozen nowadays",
                        LongDescription = "Pilot watches, a historically-significant watch style, are a dime-a-dozen nowadays. But they’re not all created equal. In fact, some stand head and shoulders above the rest — like the Victorinox Airboss Mechanical. This beautifully-designed timepiece boasts a Swiss-made automatic movement with a 38-hour power reserve, a fully-featured slide rule bezel for easy on-the-spot calculations, SuperLuminova markings for low-light visibility, and a stainless steel case with a matching link band. For frequent fliers, few other watches will do.",
                        Category = Categories["Mechanical"],
                        ImageUrl = "mechanical/Victorinox Airboss Mechanical.jpg",
                        InStock = true,
                        IsPreferredWatch = true,
                        ImageThumbnailUrl = "mechanical/Victorinox Airboss Mechanical.jpg"
                    },
                    new Watch
                    {
                        Name = "Longines Heritage ",
                        Price = 2150.00M,
                        ShortDescription = "Many of the best watches around are either ripped right from the pages of history or they pay homage to timepieces of old",
                        LongDescription = "Many of the best watches around are either ripped right from the pages of history or they pay homage to timepieces of old. The Longines Heritage Military Field Watch is a little of both, boasting styling from the 1940s and borrowed directly from timepieces designed for the British Royal Air Force. Despite its military leanings, however, this is still very much a dress watch with its stainless steel case, minimalist numerical dial, trio of hands, and a duo of straps — one green leather and one NATO nylon. If history and handsomeness are on your watch docket, go no further.",
                        Category = Categories["Mechanical"],
                        ImageUrl = "mechanical/Longines Heritage.jpg",
                        InStock = true,
                        IsPreferredWatch = true,
                        ImageThumbnailUrl = "mechanical/Longines Heritage.jpg"
                    },
                    new Watch
                    {
                        Name = "Tudor Black Bay ",
                        Price = 379.99M,
                        ShortDescription = "One of the most iconic dive watches anywhere, Tudor’s Black Bay distills a whopping sixty years of diving experience into a single, stunning timepiece",
                        LongDescription = "One of the most iconic dive watches anywhere, Tudor’s Black Bay distills a whopping sixty years of diving experience into a single, stunning timepiece. This particular example features a 41mm stainless steel case complete with a striking red dive timer bezel, black dial with luminous markings, a steel link band, a domed sapphire crystal, and more. It also boasts 200m water-resistance and a screw-down crown to keep it safe both during normal usage and in actual dives. Of course, if you’re just looking for a handsome timekeeper to add to your wardrobe, it still fits the bill in spades.",
                        Category = Categories["Mechanical"],
                        ImageUrl = "mechanical/Tudor Black Bay.jpg",
                        InStock = true,
                        IsPreferredWatch = true,
                        ImageThumbnailUrl = "mechanical/Tudor Black Bay.jpg"
                    }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Smart", Description = "All smart watches" },
                        new Category { CategoryName = "Quartz", Description = "All quartz watches" },
                        new Category { CategoryName = "Mechanical", Description = "All mechanical watches" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
