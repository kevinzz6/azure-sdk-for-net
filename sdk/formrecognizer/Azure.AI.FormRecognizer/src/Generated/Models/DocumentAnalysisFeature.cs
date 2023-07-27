// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> The DocumentAnalysisFeature. </summary>
    public readonly partial struct DocumentAnalysisFeature : IEquatable<DocumentAnalysisFeature>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DocumentAnalysisFeature"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DocumentAnalysisFeature(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OcrHighResolutionValue = "ocr.highResolution";
        private const string OcrFormulaValue = "ocr.formula";
        private const string OcrFontValue = "ocr.font";
        private const string QueryFieldsPremiumValue = "queryFields.premium";

        /// <summary> Perform OCR at a higher resolution to handle documents with fine print. </summary>
        public static DocumentAnalysisFeature OcrHighResolution { get; } = new DocumentAnalysisFeature(OcrHighResolutionValue);
        /// <summary> Enable the detection of mathematical expressions the document. </summary>
        public static DocumentAnalysisFeature OcrFormula { get; } = new DocumentAnalysisFeature(OcrFormulaValue);
        /// <summary> Enable the recognition of various font styles. </summary>
        public static DocumentAnalysisFeature OcrFont { get; } = new DocumentAnalysisFeature(OcrFontValue);
        /// <summary> Enable extraction of additional fields via the queryFields query parameter. </summary>
        public static DocumentAnalysisFeature QueryFieldsPremium { get; } = new DocumentAnalysisFeature(QueryFieldsPremiumValue);
        /// <summary> Determines if two <see cref="DocumentAnalysisFeature"/> values are the same. </summary>
        public static bool operator ==(DocumentAnalysisFeature left, DocumentAnalysisFeature right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DocumentAnalysisFeature"/> values are not the same. </summary>
        public static bool operator !=(DocumentAnalysisFeature left, DocumentAnalysisFeature right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DocumentAnalysisFeature"/>. </summary>
        public static implicit operator DocumentAnalysisFeature(string value) => new DocumentAnalysisFeature(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DocumentAnalysisFeature other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DocumentAnalysisFeature other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
