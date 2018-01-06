using System;
using System.Collections.Generic;
using System.Text;

namespace StageCtrl
{
    public class LTS300 : StageBase
    {
        private int _stageId;
        private ICommDev _stageCommPort;


        public LTS300()
        {
            _stageId = 0;
        }

        public LTS300(ICommDev commDev)
        {
            _stageId = 0;
            _stageCommPort = commDev;
        }

        public override void Initialize()
        {
            throw new NotImplementedException();
        }


        public override double GetAcceleration()
        {
            throw new NotImplementedException();
        }

        public override double GetActualPosition()
        {
            throw new NotImplementedException();
        }

        public override double GetActualVelocity()
        {
            throw new NotImplementedException();
        }

        public override double GetSetPosition()
        {
            throw new NotImplementedException();
        }

        public override double GetSetVelocity()
        {
            throw new NotImplementedException();
        }

        public override void Move()
        {
            throw new NotImplementedException();
        }

        public override double SetAcceleration()
        {
            throw new NotImplementedException();
        }

        public override double SetActualPosition()
        {
            throw new NotImplementedException();
        }

        public override double SetActualVelocity()
        {
            throw new NotImplementedException();
        }

        public override double SetSetPosition()
        {
            throw new NotImplementedException();
        }

        public override double SetSetVelocity()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
