using System;
using System.Threading.Tasks;
using EasyPipeLine;

namespace core.pipelines.concretePipelines.youtubePipeline
{
    public class ExceptionHandler :Handler
    {
        protected override async Task Handle(IHandlerData data)
        {
            try
            {
                await base.Handle(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}