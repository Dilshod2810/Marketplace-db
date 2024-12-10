
using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services.QueryService;

public class QueryService : IQueryService
{
    private readonly DapperContext _context;

    public QueryService()
    {
        _context = new DapperContext();
    }
    public  List<QueryClass> ShowUsersMarkets()
    {
        var sql = $"select users.firstname, markets.market_name from users join markets on markets.userid=users.id;";
        var showUser = _context.Connection().Query<QueryClass>(sql).ToList();
        return showUser;
    }
    
    public  List<QueryClass> ShowProductCategorie()
    {
        var sql =
            "select products.name, categories.name from products join categories on categories.id=products.categoryid;";
        var showProduct = _context.Connection().Query<QueryClass>(sql).ToList();
        return showProduct;
    }

   
}