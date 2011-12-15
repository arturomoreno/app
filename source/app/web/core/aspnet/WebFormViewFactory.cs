using System.Web;

namespace app.web.core.aspnet
{
  public class WebFormViewFactory:ICreateWebFormViewsToDisplayReports
  {
    public IHttpHandler create_view_that_can_display<ReportModel>(ReportModel the_report)
    {
    	IFindPathsToWebForms view_path_registry;

public WebFormViewFactory(IFindPathsToWebForms view_path_registry)
    	{
    		
    	}
    	;

    }
  }
}