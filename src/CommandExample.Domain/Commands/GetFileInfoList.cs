using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CommandExample.Domain.Commands
{
    internal class GetFileInfoList : IRequest<List<string>>
    {
        private readonly object _injectedSomethingLikeADatabaseContext;

        public GetFileInfoList(object injectedSomethingLikeADatabaseContext = null)
        {
            _injectedSomethingLikeADatabaseContext = injectedSomethingLikeADatabaseContext;
        }

        // "params"
        public string DirPath { get; set; }
        public string SearchPattern { get; set; }

        internal class Handler : IRequestHandler<GetFileInfoList, List<string>>
        {
            public List<string> Handle(GetFileInfoList getFileInfoList)
            {
                return Directory.GetFiles(getFileInfoList.DirPath, getFileInfoList.SearchPattern).ToList();
            }
        }
    }
}