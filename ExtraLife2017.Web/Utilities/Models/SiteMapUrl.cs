﻿using System;

// ReSharper disable once CheckNamespace
namespace ExtraLife2017.Web.Utilities
{
    public class SitemapUrl
    {
        public string Url { get; set; }
        public DateTime? Modified { get; set; }
        public ChangeFrequency? ChangeFrequency { get; set; }
        public double? Priority { get; set; }
    }
}