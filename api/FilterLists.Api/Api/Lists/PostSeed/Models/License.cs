﻿namespace FilterLists.Api.Api.Lists.PostSeed.Models;

public record License
{
    public long Id { get; init; }
    public string Name { get; init; } = default!;
    public string? Url { get; init; }
    public bool PermitsModification { get; init; }
    public bool PermitsDistribution { get; init; }
    public bool PermitsCommercialUse { get; init; }
}