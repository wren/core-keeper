#pragma warning disable 0219
#line 1 "C:/Users/berky/Desktop/ModDev/CoreKeeperModDevelopment/Temp/GeneratedCode/Exp Multiplier//ExpMultiplier__System_448009040.g.cs"
using PugMod;
using UnityEngine;
using Unity.Entities;
using Unity.NetCode;
using CoreLib.Data.Configuration;
using System.Linq;
namespace MaskoliverMods
{
    [global::System.Runtime.CompilerServices.CompilerGenerated]
    public partial class ExperienceMultiplierSystem
    {
        [global::Unity.Entities.DOTSCompilerPatchedMethod("OnUpdate_T0")]
        void __OnUpdate_450AADF4()
        {
            #line 54 "C:/Users/berky/Desktop/ModDev/CoreKeeperModDevelopment/Assets/Exp Multiplier/ExpMultiplier.cs"
            if (!ExpMultiplier.Instance.IsEnabled)
            #line 55 "C:/Users/berky/Desktop/ModDev/CoreKeeperModDevelopment/Assets/Exp Multiplier/ExpMultiplier.cs"
            {
                #line 56 "C:/Users/berky/Desktop/ModDev/CoreKeeperModDevelopment/Assets/Exp Multiplier/ExpMultiplier.cs"
                return;
            }
            #line 59 "C:/Users/berky/Desktop/ModDev/CoreKeeperModDevelopment/Assets/Exp Multiplier/ExpMultiplier.cs"

            int experienceMultiplier = ExpMultiplier.ExperienceMultiplier.Value;
            #line 61 "C:/Users/berky/Desktop/ModDev/CoreKeeperModDevelopment/Assets/Exp Multiplier/ExpMultiplier.cs"

            ExperienceMultiplierSystem_749F18F_LambdaJob_0_Execute(ref experienceMultiplier);
        }

        #line 33 "C:/Users/berky/Desktop/ModDev/CoreKeeperModDevelopment/Temp/GeneratedCode/Exp Multiplier//ExpMultiplier__System_448009040.g.cs"
        [global::Unity.Burst.NoAlias]
        [global::Unity.Burst.BurstCompile]
        struct ExperienceMultiplierSystem_749F18F_LambdaJob_0_Job : global::Unity.Entities.IJobChunk
        {
            public int experienceMultiplier;
            public global::Unity.Entities.ComponentTypeHandle<global::AddSkillValueCD> __addSkillValueTypeHandle;
            public static readonly global::Unity.Profiling.ProfilerMarker s_ProfilerMarker = new global::Unity.Profiling.ProfilerMarker(new global::Unity.Profiling.ProfilerCategory("Burst", global::Unity.Profiling.ProfilerCategoryColor.BurstJobs), "ExperienceMultiplierSystem_749F18F_LambdaJob_0");
            
            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            void OriginalLambdaBody([Unity.Burst.NoAlias] ref global::AddSkillValueCD addSkillValue)
            {
#line 65 "C:\Users\berky\Desktop\ModDev\CoreKeeperModDevelopment\Assets/Exp Multiplier/ExpMultiplier.cs"
addSkillValue.amount *= experienceMultiplier;
                }
            #line 48 "C:/Users/berky/Desktop/ModDev/CoreKeeperModDevelopment/Temp/GeneratedCode/Exp Multiplier//ExpMultiplier__System_448009040.g.cs"
            [global::System.Runtime.CompilerServices.CompilerGenerated]
            public void Execute(in global::Unity.Entities.ArchetypeChunk chunk, int batchIndex, bool useEnabledMask, in global::Unity.Burst.Intrinsics.v128 chunkEnabledMask)
            {
                #line 52 "C:/Users/berky/Desktop/ModDev/CoreKeeperModDevelopment/Temp/GeneratedCode/Exp Multiplier//ExpMultiplier__System_448009040.g.cs"
                var addSkillValueArrayPtr = global::Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetChunkNativeArrayIntPtr<global::AddSkillValueCD>(chunk, ref __addSkillValueTypeHandle);
                int chunkEntityCount = chunk.Count;
                if (!useEnabledMask)
                {
                    for(var entityIndex = 0; entityIndex < chunkEntityCount; ++entityIndex)
                    {
                        OriginalLambdaBody(ref global::Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::AddSkillValueCD>(addSkillValueArrayPtr, entityIndex));
                    }
                }
                else
                {
                    int edgeCount = global::Unity.Mathematics.math.countbits(chunkEnabledMask.ULong0 ^ (chunkEnabledMask.ULong0 << 1)) + global::Unity.Mathematics.math.countbits(chunkEnabledMask.ULong1 ^ (chunkEnabledMask.ULong1 << 1)) - 1;
                    bool useRanges = edgeCount <= 4;
                    if (useRanges)
                    {
                        int entityIndex = 0;
                        int batchEndIndex = 0;
                        while (global::Unity.Entities.Internal.InternalCompilerInterface.UnsafeTryGetNextEnabledBitRange(chunkEnabledMask, batchEndIndex, out entityIndex, out batchEndIndex))
                        {
                            while (entityIndex < batchEndIndex)
                            {
                                OriginalLambdaBody(ref global::Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::AddSkillValueCD>(addSkillValueArrayPtr, entityIndex));
                                entityIndex++;
                            }
                        }
                    }
                    else
                    {
                        ulong mask64 = chunkEnabledMask.ULong0;
                        int count = global::Unity.Mathematics.math.min(64, chunkEntityCount);
                        for (var entityIndex = 0; entityIndex < count; ++entityIndex)
                        {
                            if ((mask64 & 1) != 0)
                            {
                                OriginalLambdaBody(ref global::Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::AddSkillValueCD>(addSkillValueArrayPtr, entityIndex));
                            }
                            mask64 >>= 1;
                        }
                        mask64 = chunkEnabledMask.ULong1;
                        for (var entityIndex = 64; entityIndex < chunkEntityCount; ++entityIndex)
                        {
                            if ((mask64 & 1) != 0)
                            {
                                OriginalLambdaBody(ref global::Unity.Entities.Internal.InternalCompilerInterface.UnsafeGetRefToNativeArrayPtrElement<global::AddSkillValueCD>(addSkillValueArrayPtr, entityIndex));
                            }
                            mask64 >>= 1;
                        }
                    }
                }
            }
            [global::Unity.Burst.BurstCompile]
            public static void RunWithoutJobSystem(ref global::Unity.Entities.EntityQuery query, global::System.IntPtr jobPtr)
            {
                try
                {
                    ref var jobData = ref global::Unity.Entities.Internal.InternalCompilerInterface.UnsafeAsRef<ExperienceMultiplierSystem_749F18F_LambdaJob_0_Job>(jobPtr);
                    global::Unity.Entities.Internal.InternalCompilerInterface.JobChunkInterface.RunWithoutJobsInternal(ref jobData, ref query);
                }
                finally
                {
                }
            }
        }
        void ExperienceMultiplierSystem_749F18F_LambdaJob_0_Execute(ref int experienceMultiplier)
        {
            __TypeHandle.__AddSkillValueCD_RW_ComponentTypeHandle.Update(ref this.CheckedStateRef);
            var __job = new ExperienceMultiplierSystem_749F18F_LambdaJob_0_Job
            {
                experienceMultiplier = experienceMultiplier,
                __addSkillValueTypeHandle = __TypeHandle.__AddSkillValueCD_RW_ComponentTypeHandle
            };
            
            using (ExperienceMultiplierSystem_749F18F_LambdaJob_0_Job.s_ProfilerMarker.Auto())
            {
                if(!__query_612737900_0.IsEmptyIgnoreFilter)
                {
                    this.CheckedStateRef.CompleteDependency();
                    var __jobPtr = global::Unity.Entities.Internal.InternalCompilerInterface.AddressOf(ref __job);
                    ExperienceMultiplierSystem_749F18F_LambdaJob_0_Job.RunWithoutJobSystem(ref __query_612737900_0, __jobPtr);
                }
            }
            experienceMultiplier = __job.experienceMultiplier;
        }
        
        TypeHandle __TypeHandle;
        global::Unity.Entities.EntityQuery __query_612737900_0;
        struct TypeHandle
        {
            public Unity.Entities.ComponentTypeHandle<global::AddSkillValueCD> __AddSkillValueCD_RW_ComponentTypeHandle;
            [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
            public void __AssignHandles(ref global::Unity.Entities.SystemState state)
            {
                __AddSkillValueCD_RW_ComponentTypeHandle = state.GetComponentTypeHandle<global::AddSkillValueCD>(false);
            }
            
        }
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        void __AssignQueries(ref global::Unity.Entities.SystemState state)
        {
            var entityQueryBuilder = new global::Unity.Entities.EntityQueryBuilder(global::Unity.Collections.Allocator.Temp);
            __query_612737900_0 = 
                entityQueryBuilder
                    .WithAllRW<global::AddSkillValueCD>()
                    .Build(ref state);
            entityQueryBuilder.Reset();
            entityQueryBuilder.Dispose();
        }
        
        protected override void OnCreateForCompiler()
        {
            base.OnCreateForCompiler();
            __AssignQueries(ref this.CheckedStateRef);
            __TypeHandle.__AssignHandles(ref this.CheckedStateRef);
        }
    }
}
