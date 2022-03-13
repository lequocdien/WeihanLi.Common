﻿// Copyright (c) Weihan Li. All rights reserved.
// Licensed under the Apache license.

namespace WeihanLi.Common.Helpers;

public static class TaskHelper
{
#if ValueTaskSupport
    /// <summary>
    /// A cached completed value task
    /// </summary>
    public static ValueTask CompletedValueTask =>
#if NET6_0_OR_GREATER
        ValueTask.CompletedTask
#else
    default
#endif
    ;
#endif
}
