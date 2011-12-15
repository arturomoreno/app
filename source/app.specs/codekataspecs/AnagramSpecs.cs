using System;
using System.Collections.Generic;
using System.Linq;
using Machine.Specifications;
using developwithpassion.specifications.extensions;
using developwithpassion.specifications.rhinomocks;

namespace app.specs.codekataspecs
{
	[Subject(typeof(Anagaram))]
	public class AnagramSpecs
	{

		public class when_reading_input_words
		{
			Establish c = () =>
			{

			};

			Because b = () =>
			{

			};

			It should_receive_file ;

			It should_iterate_through_each_line;

			It should_iterate_through_each_letter_of_each_line;
		}

		
	}

}
