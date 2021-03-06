' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

Imports System.Threading
Imports Microsoft.CodeAnalysis.Completion.Providers
Imports Microsoft.CodeAnalysis.VisualBasic.Extensions.ContextQuery

Namespace Microsoft.CodeAnalysis.VisualBasic.Completion.KeywordRecommenders.Queries
    ''' <summary>
    ''' Recommends the ""Group Join" query clause when it appears inside a normal Join clause.
    ''' </summary>
    Friend Class GroupJoinKeywordRecommender
        Inherits AbstractKeywordRecommender

        Protected Overrides Function RecommendKeywords(context As VisualBasicSyntaxContext, cancellationToken As CancellationToken) As IEnumerable(Of RecommendedKeyword)
            If context.IsAdditionalJoinOperatorContext(cancellationToken) Then
                Return SpecializedCollections.SingletonEnumerable(New RecommendedKeyword("Group Join", VBFeaturesResources.Combines_the_elements_of_two_sequences_and_groups_the_results_The_join_operation_is_based_on_matching_keys))
            End If

            Return SpecializedCollections.EmptyEnumerable(Of RecommendedKeyword)()
        End Function
    End Class
End Namespace
