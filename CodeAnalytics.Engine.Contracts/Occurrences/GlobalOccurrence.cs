﻿using System.Collections.Concurrent;
using CodeAnalytics.Engine.Contracts.Ids;

namespace CodeAnalytics.Engine.Contracts.Occurrences;

public sealed class GlobalOccurrence
{
   public required NodeId NodeId { get; set; }
   
   public ConcurrentDictionary<StringId, ProjectOccurrence> ProjectOccurrences { get; init; } = [];
   
   public ConcurrentDictionary<DeclarationOccurrence, bool> DeclarationMap { get; init; } = [];
   public List<DeclarationOccurrence> Declarations => DeclarationMap.Keys.ToList();
   
   public void AddDeclaration(DeclarationOccurrence occurrence)
   {
      DeclarationMap[occurrence] = true;
   }
   
   public ProjectOccurrence GetOrCreateByProject(StringId pathId)
   {
      return ProjectOccurrences.GetOrAdd(pathId, (_) => new ProjectOccurrence()
      {
         PathId = pathId
      });
   }

   public Dictionary<StringId, ProjectOccurrence> ToDictionary()
   {
      return ProjectOccurrences
         .ToDictionary();
   }
}