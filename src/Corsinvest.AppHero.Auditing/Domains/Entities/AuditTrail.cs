﻿/*
 * SPDX-FileCopyrightText: Copyright Corsinvest Srl
 * SPDX-License-Identifier: AGPL-3.0-only
 */
using Corsinvest.AppHero.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Corsinvest.AppHero.Auditing.Domains.Entities;

public class AuditTrail : IAggregateRoot<int>
{
    [Key] public int Id { get; set; }
    public string? UserId { get; set; }
    public AuditType AuditType { get; set; }
    public string? TableName { get; set; }
    public DateTime DateTime { get; set; }
    public Dictionary<string, object> OldValues { get; } = [];
    public Dictionary<string, object> NewValues { get; } = [];
    public ICollection<string>? AffectedColumns { get; } = new List<string>();
    public Dictionary<string, object> PrimaryKey { get; } = [];
    [NotMapped] public List<PropertyEntry> TemporaryProperties { get; } = [];
}
