﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FilterLists.Directory.Infrastructure.Persistence.Queries.Entities
{
    [SuppressMessage("ReSharper", "AutoPropertyCanBeMadeGetOnly.Local")]
    public class Language
    {
        public string Iso6391 { get; private set; } = null!;
        public string Name { get; private set; } = null!;
        public IReadOnlyCollection<FilterListLanguage> FilterListLanguages { get; private set; } = new HashSet<FilterListLanguage>();
    }

    internal class LanguageTypeConfiguration : IEntityTypeConfiguration<Language>
    {
        public virtual void Configure(EntityTypeBuilder<Language> builder)
        {
            _ = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.HasKey(l => l.Iso6391);
        }
    }
}