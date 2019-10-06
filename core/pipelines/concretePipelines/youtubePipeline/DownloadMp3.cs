using System;
using System.Threading.Tasks;
using EasyPipeLine;

namespace core.pipelines.concretePipelines.youtubePipeline
{
    public class DownloadMp3 : Handler
    {
        protected override async Task Handle(IHandlerData data)
        {
            Console.WriteLine("Downloading ... ");
            await base.Handle(data);
        }
    }
}