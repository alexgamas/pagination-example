using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using sorteio.controller.viewmodels;
using sorteio.models;
using sorteio.service;

namespace sorteio.controllers
{

    [Route("api/area")]
    public class AreaController : Controller
    {
        private readonly AreaService service;

        public AreaController(AreaService service)
        {
            this.service = service;
        }

        [HttpGet("search")]
        public ActionResult<PageResponse<SearchAreaResponse>> Search(
            [FromQuery]Nullable<int> page,
            [FromQuery]Nullable<int> limit,
            [FromQuery]Dictionary<string, string> order)
        {

            PageRequest pr = PageRequest.Of(page, limit);

            PageResponse<SearchAreaResponse> pagedResponse = service.SearchPaged(pr);

            return Ok(pagedResponse);
        }

    }
}
