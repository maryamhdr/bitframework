﻿using System;

namespace Bit.Owin.Contracts
{
    public interface ITimeZoneManager
    {
        DateTimeOffset MapFromServerToClient(DateTimeOffset dateTimeOffset);

        DateTimeOffset MapFromClientToServer(DateTimeOffset dateTimeOffset);

        TimeZoneInfo? GetClientCurrentTimeZone(DateTimeOffset dateTimeOffset);

        TimeZoneInfo? GetClientDesiredTimeZone(DateTimeOffset dateTimeOffset);
    }
}
