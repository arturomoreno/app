namespace app.web.core.aspnet
{
  public class WebFormDisplayEngine : IDisplayReports
  {
    public void display<Report>(Report report)
    {
    	 ICreateWebFormViewsToDisplayReports view_factory;

      public display(ICreateWebFormViewsToDisplayReports view_factory)
    	{
    		this.view_factory = view_factory;
    	}
    }
  }
}