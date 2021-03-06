﻿using System.Text.RegularExpressions;

namespace jwldnr.VisualLinter.Helpers
{
    internal static class RegexHelper
    {
        private const string Pattern =
            "^[\t ]*$|[^\\s\\/\\\\\\(\\)\"\':,\\.;<>~!@#\\$%\\^&\\*\\|\\+=\\[\\]\\{\\}`\\?\\-…]+";

        internal static Match GetWord(string value)
        {
            return Regex.Match(value, Pattern);
        }
    }
}