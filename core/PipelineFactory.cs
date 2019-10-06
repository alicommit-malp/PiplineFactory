using System;
using core.messageTypes;
using core.pipelines;

namespace core
{
    public static class PipelineFactory
    {
        public static IPipeline Get(IMessageType messageType)
        {
            switch (messageType)
            {
                case AdminMessageType adminMessageType:
                    return new AdminActivationPipeline();
                case CommandMessageType commandMessageType:
                    return new AdminCommandPipeLine();
                case WikiMessageType wikiMessageType:
                    return new WikiPipeline();
                case YoutubeMessageType youtubeMessageType:
                    return new YoutubePipeline();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}