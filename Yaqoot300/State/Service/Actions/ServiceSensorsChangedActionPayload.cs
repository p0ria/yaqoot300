using System.Collections.Generic;

namespace Yaqoot300.State.Service.Actions
{
    public class ServiceSensorsChangedActionPayload
    {
        public ServiceSensorsChangedActionPayload(List<bool> sensors, int startIndex, int endIndex)
        {
            this.Sensors = sensors;
            this.StartIndex = startIndex;
            this.EndIndex = endIndex;
        }

        public int StartIndex { get; set; }
        public int EndIndex { get; set; }
        public List<bool> Sensors { get; set; }
    }
}