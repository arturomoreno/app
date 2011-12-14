using System.Collections.Generic;
using Machine.Specifications;
using app.web.application.catalogbrowsing;
using app.web.core;
using developwithpassion.specifications.rhinomocks;

namespace app.specs
{
  [Subject(typeof(ViewTheProductsInADepartment))]
  public class ViewTheProductsInADepartmentSpecs
  {
    public abstract class concern : Observes<ISupportAStory,
                                      ViewTheProductsInADepartment>
    {
    }

    public class when_run : concern
    {
    	private Establish c = () =>
		{
    		display_engine = depends.on<IDisplayReports>();
    		request = fake.an<IProvideDetailsToCommands>();

		};

    	private Because b = () =>
    	{
			sut.pr
    	};

		It should_display_products_in_a_department = () =>
    	    display_engine.recieved(x => display(sub_department_products));


		static IFindDepartments department_repository;
		static IProvideDetailsToCommands request;
		static IDisplayReports display_engine;
		static DepartmentItem the_main_department;
		static IEnumerable<DepartmentItem> the_sub_departments;

    }
  }
}