using System;
using System.Threading.Tasks;
using EasyPipeLine;

namespace core.pipelines.concretePipelines.youtubePipeline
{
    public class SendMp3ToUser :Handler
    {
        protected override async Task Handle(IHandlerData data)
        {
            Console.WriteLine("Sending MP3 to user ...");
            await base.Handle(data);
        }
    }
}