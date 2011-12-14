using System;
using System.Web;

namespace app.web.core.aspnet
{
  public class ASPHandler : IHttpHandler
  {
    IProcessRequests front_controller;
  	private ICreateControllerRequests request_factory;

    public ASPHandler(IProcessRequests front_controller)
    {
      this.front_controller = front_controller;
    }

    public void ProcessRequest(HttpContext context)
    {

      front_controller.process(request_factory.create_request_from(context));
    }

    public bool IsReusable
    {
      get { throw new System.NotImplementedException(); }
    }
  }
}