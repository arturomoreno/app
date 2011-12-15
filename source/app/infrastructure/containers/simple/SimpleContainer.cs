namespace app.infrastructure.containers.simple
{
  public class SimpleContainer : IFetchDependencies
  {
    IFindFactoriesThatCanCreateDependencies factories;
    ItemCreationExceptionFactory exception;

    public SimpleContainer(IFindFactoriesThatCanCreateDependencies factories, ItemCreationExceptionFactory exception)
    {
      this.factories = factories;
        this.exception = exception;
    }

    public Dependency an<Dependency>()
    {
      return (Dependency)factories.get_factory_that_can_create(typeof(Dependency)).create();
    }
  }
}