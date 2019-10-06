using System.Threading.Tasks;
using core.pipelines.concretePipelines.youtubePipeline;
using EasyPipeLine;

namespace core.pipelines
{
    public class YoutubePipeline :IPipeline
    {
        public async Task Handle(IHandlerData telegram)
        {
            await new ExceptionHandler()
                .SetRoot()
                .Next(new DownloadMp3())
                .Next((new SendMp3ToUser()))
                .Next(new NotifyAdmins())
                .Run(telegram);
        }
    }
}