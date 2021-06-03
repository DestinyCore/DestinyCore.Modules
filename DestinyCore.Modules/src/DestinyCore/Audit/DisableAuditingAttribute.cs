﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DestinyCore.Audit
{
    /// <summary>
    /// 禁用审计
    /// </summary
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]
    public class DisableAuditingAttribute : Attribute
    {

    }
}
