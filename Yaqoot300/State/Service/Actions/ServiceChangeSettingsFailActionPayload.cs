using System;

namespace Yaqoot300.State.Service.Actions
{
    public class ServiceChangeSettingsFailActionPayload
    {
        public string Error { get; set; }
        public Guid? PendingId { get; set; }

        public ServiceChangeSettingsFailActionPayload(string error):this(error, null) { }
        public ServiceChangeSettingsFailActionPayload(Guid pendingId) : this(null, pendingId) { }

        public ServiceChangeSettingsFailActionPayload(string error, Guid? pendingId)
        {
            this.Error = error;
            this.PendingId = pendingId;
        }
    }
}