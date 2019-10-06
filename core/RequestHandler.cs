using core.data.Domain;
using core.data.DTO;
using core.messageTypes;
using core.data;

namespace core
{
    public class RequestHandler
    {
        public void HandleRequest(DataDtoDomain dataDto)
        {
            PipelineFactory.Get(Parse(dataDto)).Handle(dataDto);
        }

        private IMessageType Parse(DataDto dataDto)
        {
            if (dataDto.Value.StartsWith("@")) return new AdminMessageType();
            else if(dataDto.Value.StartsWith("/"))
            {
                return new CommandMessageType();
            }
            else if(dataDto.Value.StartsWith("http://you"))
            {
                return new YoutubeMessageType();
            }
            else if(dataDto.Value.StartsWith("http://wiki"))
            {
                return new WikiMessageType();
            }
            return null;
        }
    }
}