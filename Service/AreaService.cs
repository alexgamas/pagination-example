using System;
using System.Collections.Generic;
using System.Linq;
using sorteio.controller.viewmodels;
using sorteio.models;
using sorteio.repository;

namespace sorteio.service
{
    public class AreaService
    {
        private readonly AreaRepository repository;

        public AreaService(AreaRepository repository)
        {
            this.repository = repository;
        }
        public PageResponse<SearchAreaResponse> SearchPaged(PageRequest pr) {

            List<Area> areas = repository.SearchPaged(pr);
            long total = repository.SearchPagedCount();

            List<SearchAreaResponse> sar = areas.Select((a) => new SearchAreaResponse(a.Id, a.Name)).ToList();

            return new PageResponse<SearchAreaResponse>(sar, pr, total);
        }

    }
}
