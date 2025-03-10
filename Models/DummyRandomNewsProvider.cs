namespace NewsGenerator.Models
{
    public class DummyRandomNewsProvider : IRandomNewsProvider
    {
        private static Random random = new Random();

        private static News[] news = {
            new News()
            {
                Id = 1,
                 Source = "Forbes",
                 OriginalNewsLink = "https://news.google.com/read/CBMipAFBVV95cUxQa1BxcjRrREE2OFNiZjRsYWtIbE0tS0NuTUg3R1BiS1JJZ3JuRktITWVtWVlGMnc1Z1pDOGQyLVg1TU1ObjNOczZicTJHdXg2QzgxdE1xekRtUVF6RmtKNzBoSTBoRVZidXRaQWVyNXhnaDVNQ0dUQXZvU05HRUgzeXM4OTAyV0htVWlXVURodDZtS1QtNlZ2eFMwMEpUWm5YOHBjeA?hl=en-US&gl=US&ceid=US%3Aen",
                Title = "3 Takeaways From The White House Crypto Summit",
                ImageLink = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQGveC2hJldLGGhNXDgGYvDQA0VWfe0EfjwXe0k9Q62JESlIyEXSzqe8OEjHLqXi_Xzwlc&fopt=w560-h336-rw-dcJZEM"
             },
             new News()
             {
                 Id = 2,
                 Source = "Seeking Alpha",
                 OriginalNewsLink = "https://news.google.com/read/CBMivAFBVV95cUxPLW4tQzBhS1hidGlPblBpTUlNTEpsSng1VC02cWxkb3FHbDM0alBTM2l1UXpTZEEtalJDcFRRSVp1VngzdkFsWHVrcTdKZEplSHpWM3pQY3NhMENjT3NUSXpVTUJCZGZ4OFRBS2QyM3p2cEZOd3Q5cnJZTXN4RmdUM0NlbXYxUlZoWkY4bDRPMGl4TmJMNmdaR1lHUUthWk02cGZvVG5ZcUtkUXBXMTB1WFhWMUREanVVTG13SA?hl=en-US&gl=US&ceid=US%3Aen",
                 Title = "Energy Transfer Stock: Is This High-Yielding Blue-Chip A Buy After A 16% Drop (NYSE:ET)",
                 ImageLink = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcRbs0x5vCWHpH4qhiOtDpZgL75iMnVgSZqyBgBHmLbxdCmjM_hleb5ZSF_fTl6SV4v56pQ&fopt=w400-h224-rw-dcuUKSESEH"
             },
        };

        public News GetRandomNews()
        {
            return news[random.Next(0, news.Length)];
        }
    }
}
