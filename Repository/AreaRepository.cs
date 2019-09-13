using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using sorteio.models;

namespace sorteio.repository
{
    public class AreaRepository
    {

        private readonly Context context;

        public AreaRepository(Context context)
        {
            this.context = context;
        }

        public List<Area> SearchPaged(PageRequest pageRequest)
        {
            return Pagination<Area>.For(context.Areas, pageRequest).OrderBy((a) => a.Name).ToList();
        }

        internal long SearchPagedCount()
        {
            return context.Areas.Count();
        }
    }


}

