using System;
using System.Collections.Generic;

namespace app.tasks.startup
{
  public class StartupChainBuilder : ICreateStartupChains
  {
      private IList<Type> all_steps;
     
      public StartupChainBuilder (IList<Type> all_steps, List<Type> first_step)
      {
          this.all_steps = all_steps;
          
      }
  }
}