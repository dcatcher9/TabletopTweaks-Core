﻿using Kingmaker.Blueprints.JsonSystem;
using Kingmaker.UnitLogic;
using TabletopTweaks.Core.NewUnitParts;

namespace TabletopTweaks.Core.NewComponents.AbilitySpecific {
    [TypeId("1034d09d808c4a39b9d59c8a3097e126")]
    public class AeonGazeResouceLogic : UnitFactComponentDelegate {
        public override void OnActivate() {
            var unitPart = Owner.Ensure<UnitPartAeonGazeManager>();
            unitPart.AddEntry(this.Fact);
        }
        public override void OnDeactivate() {
            var unitPart = Owner.Get<UnitPartAeonGazeManager>();
            if (unitPart != null) {
                unitPart.RemoveEntry(this.Fact);
            }
        }
    }
}
