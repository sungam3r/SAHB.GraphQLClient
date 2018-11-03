﻿using System;
using System.Collections.Generic;
using SAHB.GraphQL.Client.FieldBuilder;
using SAHB.GraphQLClient.FieldBuilder;
using SAHB.GraphQLClient.FieldBuilder.Attributes;

namespace SAHB.GraphQLClient.QueryGenerator
{
    // ReSharper disable once InconsistentNaming
    /// <summary>
    /// Builds a GraphQL query or mutation from the specified <see cref="GraphQLField"/>s and the <see cref="GraphQLQueryArgument"/>s
    /// </summary>
    public interface IGraphQLQueryGeneratorFromFields
    {
        /// <summary>
        /// Builds a GraphQL query from the specified <see cref="IGraphQLOperation"/>s and the <see cref="GraphQLQueryArgument"/>s
        /// </summary>
        /// <param name="operation">The GraphQL operation to generate the query from</param>
        /// <param name="arguments">The argument values which is inserted using a variable on specified arguments with the <see cref="GraphQLArgumentsAttribute"/></param>
        /// <returns>The generated query</returns>
        string GenerateQuery(IGraphQLOperation operation, params GraphQLQueryArgument[] arguments);
    }
}