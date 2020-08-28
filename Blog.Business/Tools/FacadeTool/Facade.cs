using Blog.Business.Tools.LogTool;
using Microsoft.Extensions.Caching.Memory;

namespace Blog.Business.Tools.FacadeTool
{
    public class Facade : IFacade
    {
        public IMemoryCache MemoryCache { get; set; }
        public ICustomLogger CustomLogger { get; set; }

        public Facade(IMemoryCache memoryCache, ICustomLogger customLogger)
        {
            MemoryCache = memoryCache;
            CustomLogger = customLogger;
        }
    }
}
