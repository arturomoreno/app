namespace app.web.core
{
  public class FrontController : IProcessRequests
  {
  	IFindCommands command_registry;

	  public FrontController(IFindCommands command_registry)
	  {
	  	this.command_registry = command_registry;
	  }
    public void process(IProvideDetailsToCommands request)
    {
      throw new System.NotImplementedException();
    }
  }
}