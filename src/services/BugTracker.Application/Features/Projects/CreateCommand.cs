using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugTracker.Application.Features.Projects
{
    public class CreateCommand
    {
        public class Command : IRequest
        {
            public string ProjectName { get; set; }
            public string ProjectType { get; set; }
        }

        public class Handler : RequestHandler<Command>
        {
            //private readonly DBContext db;
            public Handler()
            {

            }

            protected async override void Handle(Command request)
            {
                // check project does not exists with the same name

                // add project to db
            }
        }
    }
}
