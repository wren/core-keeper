#pragma warning disable 0219
#line 1 "D:/CK-ModSDK/Temp/GeneratedCode/CK-QOL//NoDeathPenaltySystem__System_14410053500.g.cs"
using Inventory;
using Unity.Entities;
using Unity.NetCode;
namespace CK_QOL.Features.NoDeathPenalty.Systems
{
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    public partial struct NoDeathPenaltySystem : global::Unity.Entities.ISystemCompilerGenerated
    {
        [global::Unity.Entities.DOTSCompilerPatchedMethod("OnUpdate_T0_ref_Unity.Entities.SystemState&")]

		
		
		
		void __OnUpdate_6D4E9467(ref SystemState state)
		{
			#line 41 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoDeathPenalty/Systems/NoDeathPenaltySystem.cs"
			if (!NoDeathPenalty.Instance.IsEnabled)
			#line 42 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoDeathPenalty/Systems/NoDeathPenaltySystem.cs"
			{
				#line 43 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoDeathPenalty/Systems/NoDeathPenaltySystem.cs"
				return;
			}
						#line 47 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoDeathPenalty/Systems/NoDeathPenaltySystem.cs"

			
			var initialMoveInventoryFromLookup = global::Unity.Entities.Internal.InternalCompilerInterface.GetComponentLookup<global::InitialMoveInventoryFromCD>(ref __TypeHandle.__InitialMoveInventoryFromCD_RW_ComponentLookup, ref state);
						#line 50 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoDeathPenalty/Systems/NoDeathPenaltySystem.cs"

			
			foreach (var (initialMoveInventoryFromCD, entity) in IFE_1451888476_0.Query(__query_1451888476_0, __TypeHandle.__IFE_1451888476_0_TypeHandle, ref state))
			#line 51 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoDeathPenalty/Systems/NoDeathPenaltySystem.cs"
			{
				#line 52 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoDeathPenalty/Systems/NoDeathPenaltySystem.cs"
				initialMoveInventoryFromLookup.SetComponentEnabled(entity, false);
				#line 53 "D:/CK-ModSDK/Assets/CK-QOL/Features/NoDeathPenalty/Systems/NoDeathPenaltySystem.cs"
				initialMoveInventoryFromCD.ValueRW.entityFrom = Entity.Null;
#line hidden
			}
		}

        #line 44 "D:/CK-ModSDK/Temp/GeneratedCode/CK-QOL//NoDeathPenaltySystem__System_14410053500.g.cs"
        readonly struct IFE_1451888476_0
        {
            public struct ResolvedChunk
            {
                public global::System.IntPtr item1_IntPtr;
                public global::System.IntPtr Entity_IntPtr;
                [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                public Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRW<global::InitialMoveInventoryFromCD>> Get(int index) => new Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRW<global::InitialMoveInventoryFromCD>>(Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetUncheckedRefRW<global::InitialMoveInventoryFromCD>(item1_IntPtr, index),Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetCopyOfNativeArrayPtrElement<Unity.Entities.Entity>(Entity_IntPtr, index));
            }
            public struct TypeHandle
            {
                Unity.Entities.ComponentTypeHandle<global::InitialMoveInventoryFromCD> item1_ComponentTypeHandle_RW;
                Unity.Entities.EntityTypeHandle Entity_TypeHandle;
                public TypeHandle(ref global::Unity.Entities.SystemState systemState)
                {
                    item1_ComponentTypeHandle_RW = systemState.GetComponentTypeHandle<global::InitialMoveInventoryFromCD>(isReadOnly: false);
                    Entity_TypeHandle = systemState.GetEntityTypeHandle();
                }
                public void Update(ref global::Unity.Entities.SystemState systemState)
                {
                    item1_ComponentTypeHandle_RW.Update(ref systemState);
                    Entity_TypeHandle.Update(ref systemState);
                }
                [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                public ResolvedChunk Resolve(global::Unity.Entities.ArchetypeChunk archetypeChunk)
                {
                    var resolvedChunk = new ResolvedChunk();
                    resolvedChunk.item1_IntPtr = Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayIntPtrWithoutChecks<global::InitialMoveInventoryFromCD>(archetypeChunk, ref item1_ComponentTypeHandle_RW);
                    resolvedChunk.Entity_IntPtr = Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkEntityArrayIntPtr(archetypeChunk, Entity_TypeHandle);
                    return resolvedChunk;
                }
            }
            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public static Enumerator Query(global::Unity.Entities.EntityQuery entityQuery, TypeHandle typeHandle, ref Unity.Entities.SystemState state) => new Enumerator(entityQuery, typeHandle, ref state);
            public struct Enumerator : global::System.Collections.Generic.IEnumerator<Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRW<global::InitialMoveInventoryFromCD>>>
            {
                global::Unity.Entities.Internal.InternalEntityQueryEnumerator _entityQueryEnumerator;
                TypeHandle _typeHandle;
                ResolvedChunk _resolvedChunk;
                
                int _currentEntityIndex;
                int _endEntityIndex;
                
                public Enumerator(global::Unity.Entities.EntityQuery entityQuery, TypeHandle typeHandle, ref Unity.Entities.SystemState state)
                {
                    if (!entityQuery.IsEmptyIgnoreFilter)
                    {
                        IFE_1451888476_0.CompleteDependencies(ref state);
                        typeHandle.Update(ref state);
                        
                    }
                    
                    _entityQueryEnumerator = new global::Unity.Entities.Internal.InternalEntityQueryEnumerator(entityQuery);
                    
                    _currentEntityIndex = -1;
                    _endEntityIndex = -1;
                    
                    _typeHandle = typeHandle;
                    _resolvedChunk = default;
                }
                
                public void Dispose() => _entityQueryEnumerator.Dispose();
                
                [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
                public bool MoveNext()
                {
                    _currentEntityIndex++;
                    
                    if (_currentEntityIndex >= _endEntityIndex)
                    {
                        if (_entityQueryEnumerator.MoveNextEntityRange(out bool movedToNewChunk, out global::Unity.Entities.ArchetypeChunk chunk, out int entityStartIndex, out int entityEndIndex))
                        {
                            if (movedToNewChunk)
                            {
                                _resolvedChunk = _typeHandle.Resolve(chunk);
                            }
                            
                            _currentEntityIndex = entityStartIndex;
                            _endEntityIndex = entityEndIndex;
                            return true;
                        }
                        return false;
                    }
                    return true;
                }
                
                public Unity.Entities.QueryEnumerableWithEntity<Unity.Entities.Internal.InternalCompilerInterface.UncheckedRefRW<global::InitialMoveInventoryFromCD>> Current => _resolvedChunk.Get(_currentEntityIndex);
                
                public Enumerator GetEnumerator() => this;
                public void Reset() => throw new global::System.NotImplementedException();
                object global::System.Collections.IEnumerator.Current => throw new global::System.NotImplementedException();
            }
            public static void CompleteDependencies(ref SystemState state)
            {
                state.EntityManager.CompleteDependencyBeforeRW<global::InitialMoveInventoryFromCD>();
            }
        }
        
        TypeHandle __TypeHandle;
        global::Unity.Entities.EntityQuery __query_1451888476_0;
        struct TypeHandle
        {
            public IFE_1451888476_0.TypeHandle __IFE_1451888476_0_TypeHandle;
            public global::Unity.Entities.ComponentLookup<global::InitialMoveInventoryFromCD> __InitialMoveInventoryFromCD_RW_ComponentLookup;
            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void __AssignHandles(ref global::Unity.Entities.SystemState state)
            {
                __IFE_1451888476_0_TypeHandle = new IFE_1451888476_0.TypeHandle(ref state);
                __InitialMoveInventoryFromCD_RW_ComponentLookup = state.GetComponentLookup<global::InitialMoveInventoryFromCD>(false);
            }
            
        }
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        void __AssignQueries(ref global::Unity.Entities.SystemState state)
        {
            var entityQueryBuilder = new global::Unity.Entities.EntityQueryBuilder(global::Unity.Collections.Allocator.Temp);
            __query_1451888476_0 = 
                entityQueryBuilder
                    .WithAllRW<global::InitialMoveInventoryFromCD>()
                    .Build(ref state);
            entityQueryBuilder.Reset();
            entityQueryBuilder.Dispose();
        }
        
        public void OnCreateForCompiler(ref SystemState state)
        {
            __AssignQueries(ref state);
            __TypeHandle.__AssignHandles(ref state);
        }
    }
}
