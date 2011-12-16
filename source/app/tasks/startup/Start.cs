using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using app.tasks.startup.steps;

namespace app.tasks.startup
{
    public class Start
    {
        private ConfiguringInfrastructureServices by;
        private ConfiguringInfrastructureServices followed_by;
        private ConfiguringQueries finish_by;

        public Start()
        {
            this.by = by;
            this.followed_by = followed_by;
            this.finish_by = finish_by;
        }

        object by<
    }
}
