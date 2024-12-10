
using Domain.Models;

namespace Infrastructure.Services.QueryService;

public interface IQueryService
{
    List<QueryClass> ShowUsersMarkets();
    List<QueryClass> ShowProductCategorie();
}