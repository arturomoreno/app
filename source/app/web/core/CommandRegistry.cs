using System.Collections.Generic;
using System.Linq;

namespace app.web.core
{
  public class CommandRegistry : IFindCommands
  {
    IEnumerable<IProcessASingleRequest> commands;
  	IProcessASingleRequest special_case;

    public CommandRegistry(IEnumerable<IProcessASingleRequest> commands, IProcessASingleRequest special_case)
    {
      this.commands = commands;
    	this.special_case = special_case;
    }

    public IProcessASingleRequest get_the_command_that_can_process(IProvideDetailsToCommands request)
    {
      //return commands.First(x => x.can_process(request));
    	return commands.FirstOrDefault(x => x.can_process(request)) ?? special_case;
    }
  }
}