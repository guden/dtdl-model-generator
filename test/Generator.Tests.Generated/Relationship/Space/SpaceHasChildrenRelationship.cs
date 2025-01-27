// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Generator.Tests.Generated
{
    using Azure;
    using Azure.DigitalTwins.Core;
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    public class SpaceHasChildrenRelationship : Relationship<Space>, IEquatable<SpaceHasChildrenRelationship>
    {
        public SpaceHasChildrenRelationship()
        {
            Name = "hasChildren";
        }

        public SpaceHasChildrenRelationship(Space source, Space target) : this()
        {
            InitializeFromTwins(source, target);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as SpaceHasChildrenRelationship);
        }

        public bool Equals(SpaceHasChildrenRelationship? other)
        {
            var targetsAreEqual = (Target is null && other?.Target is null) || (!(Target is null) && !(other?.Target is null) && Target == other.Target);
            return !(other is null) && Id == other.Id && SourceId == other.SourceId && TargetId == other.TargetId && targetsAreEqual;
        }

        public static bool operator ==(SpaceHasChildrenRelationship left, SpaceHasChildrenRelationship right)
        {
            return EqualityComparer<SpaceHasChildrenRelationship>.Default.Equals(left, right);
        }

        public static bool operator !=(SpaceHasChildrenRelationship left, SpaceHasChildrenRelationship right)
        {
            return !(left == right);
        }

        public override int GetHashCode()
        {
            return this.CustomHash(Id?.GetHashCode(), SourceId?.GetHashCode(), TargetId?.GetHashCode(), Target?.GetHashCode());
        }

        public override bool Equals(BasicRelationship? other)
        {
            return Equals(other as SpaceHasChildrenRelationship) || new RelationshipEqualityComparer().Equals(this, other);
        }
    }
}