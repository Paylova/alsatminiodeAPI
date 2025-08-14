using F = alsatminiode.Domain.Entities;

namespace alsatminiode.Application.Repositories.FileRepo
{
    public interface IFileWriteRepository : IWriteRepository<F::File>
    {
    }
}
