﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

namespace Microsoft.DigitalWorkplace.Integration.Models.Generator;

internal abstract class PropertyAccessor : Writable
{
    private string body;

    internal string Body
    {
        get => body;
        set
        {
            body = ReindentText(TrimWhitespace(value));
        }
    }

    private string TrimWhitespace(string text)
    {
        return text.Trim();
    }

    private string ReindentText(string text)
    {
        var reindented = Regex.Replace(text, @"(\r\n|\n)\s*", $"$1{indent}{indent}{indent}{indent}");
        return $"{indent}{indent}{indent}{indent}" + reindented;
    }
}