﻿namespace FilterLists.Api.Api.Lists.Put.Request;

public record Tag
{
    public long Id { get; init; }
    public string Name { get; init; } = default!;
    public string? Description { get; init; }
}