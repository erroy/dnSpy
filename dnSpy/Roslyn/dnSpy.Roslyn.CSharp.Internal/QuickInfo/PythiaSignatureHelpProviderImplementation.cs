﻿using System.Collections.Immutable;
using System.Composition;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.ExternalAccess.Pythia.Api;

namespace dnSpy.Roslyn.Internal.QuickInfo.CSharp {
	[Export(typeof(IPythiaSignatureHelpProviderImplementation))]
	class PythiaSignatureHelpProviderImplementation : IPythiaSignatureHelpProviderImplementation {
		public Task<(ImmutableArray<PythiaSignatureHelpItemWrapper> items, int? selectedItemIndex)>
			GetMethodGroupItemsAndSelectionAsync(ImmutableArray<IMethodSymbol> accessibleMethods, Document document,
				InvocationExpressionSyntax invocationExpression, SemanticModel semanticModel, SymbolInfo currentSymbol,
				CancellationToken cancellationToken) =>
			Task.FromResult((ImmutableArray<PythiaSignatureHelpItemWrapper>.Empty, (int?)null));
	}
}
