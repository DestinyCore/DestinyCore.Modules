﻿using DestinyCore.Filter.Abstract;

namespace DestinyCore.Filter
{
    /// <summary>
    /// 分页所需的参数
    /// </summary>
    public class PageParameters : IPagedRequest, IFilteredPagedRequest, IOrderRequest
    {




        /// <summary>
        /// 分页索引
        /// </summary>

        public virtual int PageIndex { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        public virtual int PageSize { get; set; }

        /// <summary>
        /// 排序条件集合
        /// </summary>
        public OrderCondition[] OrderConditions { get; set; }

        /// <summary>
        /// 查询过滤
        /// </summary>
        public QueryFilter Filter { get; set; }
    }
}
