﻿using DestinyCore.Enums;

namespace DestinyCore.Filter
{
    public class FilterCondition
    {

        public FilterCondition()
        { 
        
        }

        public FilterCondition(string field, object value) : this(field, value, FilterOperator.Equal)
        { 
        
        }
        public FilterCondition(string field, object value, FilterOperator @operator)
        {
            this.Field = field;
            this.Value = value;
            this.Operator = @operator;
        }

        /// <summary>
        /// 字段名称
        /// </summary>
        public string Field { get; set; }
        /// <summary>
        /// 值
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// 过滤操作器
        /// </summary>
        public FilterOperator Operator { get; set; } = FilterOperator.Equal;
    }
}
