
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace sorteio.models
{
    public abstract class Orderable
    //<TEntity> where TEntity : class
    {
        private Dictionary<string, string> order;

        protected void AddOrder(string key, string predicate) {
            if (order == null) 
            {
                order = new Dictionary<string, string>();
            }

            order.Add(key, predicate);
        }
        public abstract void SetupOrderExpressions();
    }
}