using System.Collections.Generic;
using Machine.Specifications;
using app.web.application.catalogbrowsing;
using app.web.core;
using developwithpassion.specifications.rhinomocks;
using developwithpassion.specifications.extensions;
using System.Diagnostics;

namespace app.specs
{
	//[Subject(typeof())]
	public class LogCommandPerformanceTime
	{
		public abstract class concern : Observes<ICollectData>
		{

		}
		
		//decorator?

		public class when_processing_a_command
		{
			Establish c = () =>
			{

			};

			Because b = () =>
			{

			};

			It should_log_command_performance_time = () =>
			    log_time.received(x => x.process(time));

			static ILogTimeOnRequests log_time;
		}
	}


}
