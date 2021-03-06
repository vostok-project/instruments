﻿using System;

namespace Vostok.Metrics
{
    public interface IMetricEventWriter
    {
        IMetricEventWriter SetTimestamp(DateTimeOffset timestamp);
        IMetricEventWriter SetTag(string key, string value);
        IMetricEventWriter SetValue(string key, double value);
        void Commit();
    }
}