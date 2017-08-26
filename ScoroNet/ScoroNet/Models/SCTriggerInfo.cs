namespace ScoroNet.Models
{
    public class SCTriggerInfo
    {
        public SCTrigger AfterFind { get; set; }
        public SCTrigger AfterInsert { get; set; }
        public SCTrigger AfterRemove { get; set; }
        public SCTrigger AfterUpdate { get; set; }
        public SCTrigger BeforeInstert { get; set; }
        public SCTrigger BeforeRemove { get; set; }
        public SCTrigger BeforeUpdate { get; set; }
    }
}
