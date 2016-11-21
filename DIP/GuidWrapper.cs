using System;

namespace SolidTraining.DIP
{
    public class GuidWrapper : IGuidWrapper
    {
        private Guid _guid;

        public GuidWrapper()
        {
            _guid = Guid.NewGuid();
        }

        public Guid GetGuid()
        {
            return _guid;
        }
    }
}