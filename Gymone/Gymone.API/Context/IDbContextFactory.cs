
namespace Gymone.API.Context
{
    public interface IDbContextFactory<out T>
    {
        T GetContext();
    }
}
