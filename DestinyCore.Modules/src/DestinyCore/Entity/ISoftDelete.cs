﻿namespace DestinyCore.Entity
{
    /// <summary>
    /// 软删除
    /// </summary>
    public interface ISoftDelete
    {

        bool IsDeleted { get; set; }

    }
}
