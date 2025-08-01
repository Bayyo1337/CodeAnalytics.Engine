﻿using System.Runtime.InteropServices;
using CodeAnalytics.Engine.Common.Buffers.Dynamic;
using CodeAnalytics.Engine.Contracts.Components.Inerfaces;
using CodeAnalytics.Engine.Contracts.Ids;

namespace CodeAnalytics.Engine.Contracts.Components.Members;

[StructLayout(LayoutKind.Auto)]
public struct ConstructorComponent 
   : IEquatable<ConstructorComponent>, IComponent
{
   public NodeId NodeId => Id;
   public NodeId Id = NodeId.Empty;

   public int CyclomaticComplexity;
   
   public PooledSet<NodeId> ParameterIds = [];
   
   public ConstructorComponent()
   {
      
   }

   public void Dispose()
   {
      ParameterIds.Dispose();
   }
   
   public bool Equals(ConstructorComponent other)
   {
      return Id.Equals(other.Id);
   }

   public override bool Equals(object? obj)
   {
      return obj is ConstructorComponent other && Equals(other);
   }

   public override int GetHashCode()
   {
      return HashCode.Combine(Id);
   }

   public static bool operator ==(ConstructorComponent left, ConstructorComponent right)
   {
      return left.Equals(right);
   }

   public static bool operator !=(ConstructorComponent left, ConstructorComponent right)
   {
      return !(left == right);
   }
}