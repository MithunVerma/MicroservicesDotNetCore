using Catalog.Application.Responses;
using Catalog.Core.Specs;
using MediatR;

namespace Catalog.Application.Queries
{
    public class GetAllProductQuery : IRequest<Pagination<ProductResponse>>
    {
        public CatalagSpecParams CatalagSpecParams { get; set; }
        public GetAllProductQuery(CatalagSpecParams catalagSpecParams)
        {
          CatalagSpecParams = catalagSpecParams;
        }

    }
}
