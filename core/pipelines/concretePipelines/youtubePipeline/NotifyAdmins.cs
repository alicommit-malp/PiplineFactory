using System;
using System.Threading.Tasks;
using EasyPipeLine;

namespace core.pipelines.concretePipelines.youtubePipeline
{
    public class NotifyAdmins : Handler
    {
        protected override async Task Handle(IHandlerData data)
        {
            Console.WriteLine("Notifying Admins ...");
            await base.Handle(data);
        }
    }
}