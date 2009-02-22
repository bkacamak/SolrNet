﻿#region license
// Copyright (c) 2007-2009 Mauricio Scheffer
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
//  
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System.Collections.Generic;
using SolrNet.Impl;

namespace SolrNet {
	/// <summary>
	/// Query results.
	/// </summary>
	/// <typeparam name="T">Document type</typeparam>
	public interface ISolrQueryResults<T> : IList<T>  {
		/// <summary>
		/// Total documents found
		/// </summary>
		int NumFound { get; }

        /// <summary>
        /// Max score in these results
        /// </summary>
		double? MaxScore { get; }

        /// <summary>
        /// Facet queries results
        /// </summary>
		IDictionary<string, int> FacetQueries { get; set; }

        /// <summary>
        /// Facet field queries results
        /// </summary>
		IDictionary<string, ICollection<KeyValuePair<string, int>>> FacetFields { get; set; }

        /// <summary>
        /// Query response header
        /// </summary>
		ResponseHeader Header { get; set; }

        /// <summary>
        /// Highlight results
        /// </summary>
		IDictionary<T, IDictionary<string, string>> Highlights { get; set; }

        /// <summary>
        /// Spell checking results
        /// </summary>
	    SpellCheckResults SpellChecking { get; set; }

        /// <summary>
        /// More-like-this results
        /// </summary>
        IDictionary<T, IList<T>> SimilarResults { get; set; }

	}
}