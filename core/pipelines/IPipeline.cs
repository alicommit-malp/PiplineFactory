using System.Threading.Tasks;
using EasyPipeLine;
using core.data;
using core.data.DTO;

namespace core.pipelines
{
    public interface IPipeline
    {
        Task Handle(IHandlerData telegram);
    }
}