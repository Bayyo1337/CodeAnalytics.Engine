﻿namespace CodeAnalytics.Web.Common.Constants.Source;

public static class SourceApiConstants
{
   public const string BasePath = "/Api/Source";

   public const string PathGetSourceSpansByPath = "/GetSourceSpansByPath";
   public const string FullPathGetSourceSpansByPath = BasePath + PathGetSourceSpansByPath;

   public const string PathGetExplorerTreeItems = "/GetExplorerTreeItems";
   public const string FullPathGetExplorerTreeItems = BasePath + PathGetExplorerTreeItems;
}