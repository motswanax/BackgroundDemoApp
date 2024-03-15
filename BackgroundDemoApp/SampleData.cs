using System.Collections.Concurrent;

namespace BackgroundDemoApp
{
    public class SampleData
    {
        // Thread safe list.
        public ConcurrentBag<string> Data { get; set; } = new();
    }
}
