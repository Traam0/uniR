using System;

namespace UniR.Domain.Common.Attributes;

[AttributeUsage(AttributeTargets.Property)]
public sealed class AuditProperty(string? altName = null) : Attribute
{
    public string? AltName { get; init; } = altName;
}