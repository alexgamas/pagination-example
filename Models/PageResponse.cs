
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace sorteio.models
{

    [DataContract]
    public class PageResponse<T>
    {

        [DataMember(Name = "content")]
        public List<T> Content { get; set; }

        [DataMember(Name = "page")]
        public Page Page { get; set; }

        public PageResponse(List<T> content, int pageNumber, int pageLimit, int totalResult): this(content, PageRequest.Of(pageNumber, pageLimit), totalResult)
        {

        }

        public PageResponse(List<T> content, PageRequest pr, long totalResult)
        {
            this.Content = content;

            Page page = new Page();

            page.Number = pr.Number;
            page.Limit = pr.Limit;

            page.Total = (int)Math.Ceiling((double)totalResult / (double)page.Limit);

            page.First = page.Number == 1;
            page.Last = page.Number >= page.Total;

            this.Page = page;

        }


    }


}
