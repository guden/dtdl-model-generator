﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Microsoft.DigitalWorkplace.DigitalTwins.Models.Generator;

internal class RelationshipProperty : Property
{
    internal RelationshipProperty(DTRelationshipInfo relationship, ModelGeneratorOptions options, IList<string> generatedFiles) : base(options)
    {
        var relationshipEntity = new RelationshipEntity(relationship, options, generatedFiles);
        var relationshipCollectionEntity = new RelationshipCollectionEntity(relationship, options, generatedFiles);
        Type = relationshipCollectionEntity.Name;
        Name = relationship.Name;
        JsonIgnore = true;
        Initialized = true;
        Obsolete = relationship.IsObsolete();
        ProducedEntities.Add(relationshipEntity);
        ProducedEntities.Add(relationshipCollectionEntity);
    }
}