using System;
// Strategy pattern.
// Common "aspects" have been extracted into an abstract class
// The stage uses a port for communication that has to be configured during initialization.
// The communication port/device 
namespace StageCtrl
{
    public interface ICommDev
    {
        void SetPort(string portName);
    }
    public abstract class TranStage
    {
        private ICommDev _commDev;

        public abstract void Initialize();
        public abstract void Move();
        public abstract void Stop();
        public abstract double GetSetPosition();
        public abstract double GetActualPosition();
        public abstract double GetSetVelocity();
        public abstract double GetActualVelocity();
        public abstract double GetAcceleration();
        public abstract double SetSetPosition();
        public abstract double SetActualPosition();
        public abstract double SetSetVelocity();
        public abstract double SetActualVelocity();
        public abstract double SetAcceleration();
    }
}
