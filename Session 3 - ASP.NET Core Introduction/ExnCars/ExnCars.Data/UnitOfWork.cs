using ExnCars.DataAccess;

namespace ExnCars.Data
{
  public class UnitOfWork : IDisposable, IUnitOfWork
  {
    private readonly ExnCarsContext exnCarsContext;

    public UnitOfWork(ExnCarsContext exnCarsContext)
    {
      this.exnCarsContext = exnCarsContext;
    }

    public void SaveChanges()
    {
      exnCarsContext.SaveChanges();
    }

    private bool disposed = false;
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        if (disposing)
        {
          exnCarsContext.Dispose();
        }
        disposed = true;
      }
    }

    public void Dispose()
    {
      Dispose(disposing: true);
      GC.SuppressFinalize(this);
    }
  }
}
