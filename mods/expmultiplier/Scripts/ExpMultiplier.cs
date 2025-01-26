using PugMod;
using UnityEngine;
using Unity.Entities;
using Unity.NetCode;
using CoreLib.Data.Configuration;
using System.Linq;

namespace MaskoliverMods
{
    public class ExpMultiplier : IMod
    {
        public const string VERSION = "1.0.0";
        public const string NAME = "Exp Multiplier";
        public const string INTERNAL_NAME = "ExpMultiplier";
        public const string AUTHOR = "Maskoliver";

        public static ExpMultiplier Instance { get; private set; }
        public bool IsEnabled { get; private set; } = true;

        private ConfigFile configFile;
        public static ConfigEntry<int> ExperienceMultiplier;

        public void EarlyInit()
        {
            Debug.Log($"[{INTERNAL_NAME}]: Version: {VERSION} by {AUTHOR}");
            Instance = this;

            configFile = new ConfigFile($"{INTERNAL_NAME}/config.cfg", true, API.ModLoader.LoadedMods.FirstOrDefault(mod => mod.Handlers.Contains(this)));
            ExperienceMultiplier = configFile.Bind("General", "ExperienceMultiplier", 10, "Multiplier for experience gain.");
            Debug.Log($"[{INTERNAL_NAME}]: Config loaded with ExperienceMultiplier = {ExperienceMultiplier.Value}");
        }

        public void Init()
        {
            Debug.Log($"[{INTERNAL_NAME}]: Successfully initiated {NAME} v{VERSION} by {AUTHOR}");
        }

        public void Shutdown()
        {
            IsEnabled = false;
        }

        public void ModObjectLoaded(Object obj) { }
        public void Update() { }
    }

    [WorldSystemFilter(WorldSystemFilterFlags.ServerSimulation)]
    [UpdateInGroup(typeof(PredictedSimulationSystemGroup))]
    [UpdateBefore(typeof(AddSkillValueSystem))]
    public partial class ExperienceMultiplierSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            if (!ExpMultiplier.Instance.IsEnabled)
            {
                return;
            }

            int experienceMultiplier = ExpMultiplier.ExperienceMultiplier.Value;

            Entities
                .WithAll<AddSkillValueCD>()
                .ForEach((ref AddSkillValueCD addSkillValue) =>
                {
                    addSkillValue.amount *= experienceMultiplier;
                }).Run();
        }
    }
}
