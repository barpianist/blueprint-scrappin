using System.Collections.Generic;

namespace BlueprintScrappin 
{
    public class BlueprintController 
    {
        public bool? Active { get; set; }
        public ICollection<BlueprintControllerReference> Controllers { get; set; }
        public BlueprintControllerAudioIndex? AudioIndex { get; set; }
        public int Id { get; set; }
        public int? Length { get; set; }
        public double? Pitch { get; set; }
        public int? Volume { get; set; }
        public int? Speed { get; set; }
        public int? StiffnessLevel { get; set; }
        public ICollection<BlueprintJointReference> Joints { get; set; }
        public BlueprintControllerMode? Mode { get; set; }
    }
}