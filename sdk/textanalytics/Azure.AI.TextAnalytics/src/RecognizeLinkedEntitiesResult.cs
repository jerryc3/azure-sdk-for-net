﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Azure.AI.TextAnalytics
{
    /// <summary>
    /// The result of the recognize linked entities operation on a single
    /// document, containing a collection of the <see cref="LinkedEntity"/>
    /// objects identified in that document.
    /// </summary>
    public class RecognizeLinkedEntitiesResult : TextAnalyticsResult
    {
        private readonly IReadOnlyCollection<LinkedEntity> _linkedEntities;

        internal RecognizeLinkedEntitiesResult(string id, TextDocumentStatistics statistics, IList<LinkedEntity> linkedEntities)
            : base(id, statistics)
        {
            _linkedEntities = new ReadOnlyCollection<LinkedEntity>(linkedEntities);
        }

        internal RecognizeLinkedEntitiesResult(string id, TextAnalyticsError error) : base(id, error) { }

        /// <summary>
        /// Gets the collection of linked entities identified in the input document.
        /// </summary>
        public IReadOnlyCollection<LinkedEntity> Entities
        {
            get
            {
                if (HasError)
                {
#pragma warning disable CA1065 // Do not raise exceptions in unexpected locations
                    throw new InvalidOperationException($"Cannot access result for document {Id}, due to error {Error.Code}: {Error.Message}");
#pragma warning restore CA1065 // Do not raise exceptions in unexpected locations
                }
                return _linkedEntities;
            }
        }
    }
}
