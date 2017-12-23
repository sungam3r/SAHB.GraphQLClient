﻿using System.Threading.Tasks;
using SAHB.GraphQLClient.Batching.Internal;

namespace SAHB.GraphQLClient.Batching
{
    // ReSharper disable once InconsistentNaming
    /// <inheritdoc />
    internal class GraphQLBatchQuery<T> : IGraphQLQuery<T>
        where T : class
    {
        private readonly GraphQLBatchMerger _batch;
        private readonly string _identitifer;

        internal GraphQLBatchQuery(GraphQLBatchMerger batch, string identitifer)
        {
            _batch = batch;
            _identitifer = identitifer;
        }

        /// <inheritdoc />
        public Task<T> Execute()
        {
            return _batch.GetValue<T>(_identitifer);
        }
    }
}