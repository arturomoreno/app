using System;
using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;

namespace app.specs.codekataspecs
{
	[Subject(typeof(AnagramBasic))]
	public class AnagramBasicSpecs
	{

		public class when_reading_input
		{
			Establish c = () =>
			{

			};

			Because b = () =>
			{

			};

			It should_receive_file ;

			It should_confirm_connection_validity_of_file;

			//It should_iterate_through_each_letter_of_each_line;
		}

		
	}

}
