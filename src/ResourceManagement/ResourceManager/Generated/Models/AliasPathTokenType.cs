// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Fluent.Models
{
    using Management.ResourceManager;
    using Management.ResourceManager.Fluent;
    using Management.ResourceManager.Fluent.Core;

    using Newtonsoft.Json;
    /// <summary>
    /// Defines values for AliasPathTokenType.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Fluent.Core.ExpandableStringEnumConverter<AliasPathTokenType>))]
    public class AliasPathTokenType : Fluent.Core.ExpandableStringEnum<AliasPathTokenType>
    {
        public static readonly AliasPathTokenType NotSpecified = Parse("NotSpecified");
        public static readonly AliasPathTokenType Any = Parse("Any");
        public static readonly AliasPathTokenType String = Parse("String");
        public static readonly AliasPathTokenType Object = Parse("Object");
        public static readonly AliasPathTokenType Array = Parse("Array");
        public static readonly AliasPathTokenType Integer = Parse("Integer");
        public static readonly AliasPathTokenType Number = Parse("Number");
        public static readonly AliasPathTokenType Boolean = Parse("Boolean");
    }
}