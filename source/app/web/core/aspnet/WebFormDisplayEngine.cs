using System.Web;


namespace app.web.core.aspnet
{
  public class WebFormDisplayEngine : IDisplayReports
  {
    ICreateWebFormViewsToDisplayReports view_factory;
  	private HttpContext the_current_context;

    public WebFormDisplayEngine(ICreateWebFormViewsToDisplayReports view_factory, HttpContext the_current_context)
    {
      this.view_factory = view_factory;
    	this.the_current_context = the_current_context;
    }

    public void display<Report>(Report report)
    {
      view_factory.create_view_that_can_display(report);
    	view_factory.create_view_that_can_display(report).ProcessRequest(the_current_context);
    }
  }
}